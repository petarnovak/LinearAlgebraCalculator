using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using LinearAlgebra;

namespace WinFormsUI
{
    class EquationPanel : TableLayoutPanel
    {
        private int numOfEquations;
        private int numOfVariables;
        private string[] variableNames;
        private TextBox[,] textBoxes;

        public EquationPanel(int numOfEquations, int numOfVariables)
        {
            if (numOfEquations < 1 || numOfVariables < 1)
            {
                throw new ArgumentException("Numbers of rows or columns can't be less then 1.");
            }
            this.numOfEquations = numOfEquations;
            this.numOfVariables = numOfVariables;

            this.Dock = DockStyle.Fill;
            this.RowCount = numOfEquations;
            this.ColumnCount = numOfVariables * 2 + 1;

            switch (numOfVariables)
            {
                case 1:
                    variableNames = new string[] { "x" };
                    break;
                case 2:
                    variableNames = new string[] { "x", "y" };
                    break;
                case 3:
                    variableNames = new string[] { "x","y","z" };
                    break;
                default:
                    variableNames = new string[numOfVariables];
                    for (int i = 0; i < variableNames.Length; i++)
                    {
                        variableNames[i] = String.Format("x{0}", i + 1);
                    }
                    break;
            }

            textBoxes = new TextBox[numOfEquations, numOfVariables + 1];
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    if ((j % 2) == 0)
                    {
                        TextBox tb = new TextBox();
                        tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                        tb.Dock = DockStyle.None;
                        textBoxes[i, (j / 2)] = tb;
                        this.Controls.Add(tb, j, i);
                    }
                    else
                    {
                        string lblText = variableNames[(j - 1)/2];
                        if(j == ColumnCount - 2)
                        {
                            lblText += " = ";
                        } else
                        {
                            lblText += " + ";
                        }
                        this.Controls.Add(new Label() {Text = lblText,
                            Dock = DockStyle.Fill,
                            TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                        }, j, i);
                    }
                }
            }

            float rowPercentage = 100F / numOfEquations;
            for (int i = 0; i < numOfEquations; i++)
            {
                if (i == numOfEquations - 1)
                {
                    this.RowStyles.Add(new RowStyle(SizeType.Percent, 100 - i * rowPercentage));
                }
                else
                {
                    this.RowStyles.Add(new RowStyle(SizeType.Percent, rowPercentage));
                }
            }

            float columnPercentage = 100F / (numOfVariables + 1);
            float pixelsForLblColumn = 50F;
            for (int i = 0; i < ColumnCount; i++)
            {
                if ((i % 2) == 0)
                {
                    if (i == ColumnCount - 1)
                    {
                        this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 - numOfVariables * columnPercentage));
                    }
                    else
                    {
                        this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, columnPercentage));
                    }
                } else
                {
                    this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, pixelsForLblColumn));
                }
            }
        }

        public AugmentedMatrix GetAugmentedMatrix()
        {
            double[,] leftMatrixElements = new double[numOfEquations, numOfVariables];
            double[,] rightMatrixElements = new double[numOfEquations, 1];
            for (int i = 0; i < numOfEquations; i++)
            {
                for (int j = 0; j < numOfVariables + 1; j++)
                {
                    try
                    {
                        if(j == numOfVariables)
                        {
                            //right
                            if (String.IsNullOrEmpty(textBoxes[i, j].Text))
                            {
                                rightMatrixElements[i, 0] = 0.0;
                            }
                            else
                            {
                                rightMatrixElements[i, 0] = Double.Parse(textBoxes[i, j].Text.Replace('.', ','));
                            }
                        }
                        else
                        {
                            //left
                            if (String.IsNullOrEmpty(textBoxes[i, j].Text))
                            {
                                leftMatrixElements[i, j] = 0.0;
                            }
                            else
                            {
                                leftMatrixElements[i, j] = Double.Parse(textBoxes[i, j].Text.Replace('.', ','));
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        throw new ArgumentException("All inputs must be numbers.");
                    }
                }
            }

            return new AugmentedMatrix(new Matrix(numOfEquations, numOfVariables, leftMatrixElements),
                new Matrix(numOfEquations, 1, rightMatrixElements));

        }

    }
}
