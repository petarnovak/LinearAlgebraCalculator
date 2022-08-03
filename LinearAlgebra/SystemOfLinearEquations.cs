using System;
using System.Collections.Generic;
using System.Text;

namespace LinearAlgebra
{

    public class SystemOfLinearEquations
    {
        private AugmentedMatrix equation;
        private AugmentedMatrix echelonForm;
        private string[] variableNames;

        /// <param name="equation">Augmented matrix representing system of linear equations.</param>
        /// <exception cref="ArgumentException">When augmented matrix does not represent system of linear equations 
        /// (right matrix of the augmented matrix has more than one column).</exception>
        public SystemOfLinearEquations(AugmentedMatrix equation)
        {
            if(equation.RightMatrix.NumOfColumns != 1)
            {
                throw new ArgumentException("Augmented matrix does not represent" +
                    "system of linear equations.");
            }
            this.equation = equation;
            echelonForm = equation.EchelonForm;
            switch (equation.LeftMatrix.NumOfColumns)
            {
                case 1:
                    variableNames = new string[] { "x" };
                    break;
                case 2:
                    variableNames = new string[] { "x", "y" };
                    break;
                case 3:
                    variableNames = new string[] { "x", "y", "z" };
                    break;
                default:
                    variableNames = new string[equation.LeftMatrix.NumOfColumns];
                    for (int i = 0; i < variableNames.Length; i++)
                    {
                        variableNames[i] = String.Format("x{0}", i + 1);
                    }
                    break;
            }
        }
        public SolutionType TypeOfSolution { get => getSolutionType(); }
        private SolutionType getSolutionType()
        {
            if (echelonForm.LeftMatrix.IsDiagonal) return SolutionType.UNIQUE;
            for (int i = 1; i <= this.equation.LeftMatrix.NumOfRows; i++)
            {
                if (Helper.IsZeroArray(echelonForm.LeftMatrix.GetRow(i)) && !Helper.IsZeroArray(echelonForm.RightMatrix.GetRow(i)))
                {
                    return SolutionType.NONE;
                }
            }
            return SolutionType.MULTIPLE;
        }

        /// <returns>
        /// List of string representing the solutions of the given system of equations.
        /// </return>
        public List<String> Solutions
        {
            get
            {
                if(this.TypeOfSolution == SolutionType.NONE)
                {
                    return new List<string>() { "There are no real solutions." };
                } else if(this.TypeOfSolution == SolutionType.UNIQUE)
                {
                    List<string> output = new List<string>();
                    for (int i = 1; i <= equation.NumOfRows; i++)
                    {
                        output.Add(String.Format("{0} = {1}", variableNames[i-1], doubleFormat(echelonForm.RightMatrix.GetElementAt(i,1))));
                    }
                    return output;
                }
                else
                {
                    if (equation.EchelonForm.LeftMatrix.IsZeroMatrix)
                    {
                        return new List<string>() { "All real numbers are solutions to the equation." };
                    }
                    List<string> output = new List<string>();

                    for (int i = 1; i <= equation.NumOfRows; i++)
                    {
                        if (Helper.IsZeroArray(echelonForm.LeftMatrix.GetRow(i))) continue;
                        string solution = "";
                        bool leadingCoefFound = false;
                        for (int j = 1; j <= equation.LeftMatrix.NumOfColumns; j++)
                        {
                            if (Helper.DoubleEquals(echelonForm.LeftMatrix.GetElementAt(i, j), 0))
                            {
                                continue;
                            }
                            if (leadingCoefFound)
                            {
                                solution += someFormatting(-echelonForm.LeftMatrix.GetElementAt(i, j), variableNames[j - 1], equation.LeftMatrix.NumOfColumns > 3);
                                continue;
                            }
                            if (Helper.DoubleEquals(echelonForm.LeftMatrix.GetElementAt(i, j), 1))
                            {
                                leadingCoefFound = true;
                                solution += String.Format("{0} = ", variableNames[j - 1]);
                            }
                        }

                        double freeElement = echelonForm.RightMatrix.GetElementAt(i, 1);
                        if(!Helper.DoubleEquals(freeElement, 0))
                        {
                            solution += String.Format("{0} {1}", ((freeElement > 0) ? "+ " : "- "), doubleFormat(Math.Abs(freeElement)));
                        }
                        solution = solution.Replace("= +", "= ");
                        if(solution.EndsWith("= "))
                        {
                            solution += "0";
                        }
                        output.Add(solution);
                    }

                    return output;
                }
                
            }
        }

        private string doubleFormat(double d)
        {

            string output = d.ToString("F" + 10);

            while (output.EndsWith('0'))
            {
                output = output.Remove(output.Length - 1);
            }
            if (output.EndsWith(','))
            {
                output = output.Remove(output.Length - 1);
            }
            if (output.Equals("-0"))
            {
                output = "0";
            }

            return output;
        }

        private string someFormatting(double number, string varName, bool brackets)
        {
            if (Helper.DoubleEquals(number, 0)) return "";
            string output = (number > 0) ? "+ " : "- ";
            if (!Helper.DoubleEquals(number, 1) && !Helper.DoubleEquals(number, -1))
            {
                output += doubleFormat(Math.Abs(number));
                output += "*";
            }
            if (brackets)
            {
                output += String.Format("({0}) ", varName);
            }
            else
            {
                output += String.Format("{0} ", varName);
            }

            return output;
        }
    }
}
