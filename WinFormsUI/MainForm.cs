using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinearAlgebra;

namespace WinFormsUI
{
    public partial class MainForm : Form
    {
        private int maximumMatrixSize = 10;

        private string helpText = "Welcome to Linear Algebra Calculator!\n\n" +
            "Empty text box represents number 0.";
        

        private InputMatrixPanel inputMatrixPanel;
        private Matrix matrix;
        
        private OperationsPanel operationsPanel;
        private Matrix operand1;
        private Matrix operand2;

        private EquationPanel equationPanel;
        private SystemOfLinearEquations systemOfEquations;

        public MainForm()
        {
            InitializeComponent();
            List<ComboBox> comboBoxes = new List<ComboBox>()
            {
                firstMatrixColumnsCb,
                firstMatrixRowsCb,
                secondMatrixColumnsCb,
                secondMatrixRowsCb,
                numOfVarsCombo,
                numOfEqCombo,
                matrixColumnsCb,
                matrixRowsCb
            };
            List<string> cbItems = new List<string>() { "" };
            for (int i = 1; i <= maximumMatrixSize; i++)
            {
                cbItems.Add(i.ToString());
            }
            foreach (var cb in comboBoxes)
            {
                cb.DataSource = cbItems.ToArray();
            }
            mainTabControl.SelectedIndex = 0;
            
            this.helpTextLabel.Text = helpText;
        }

        private  int acceptSize(string input)
        {
            int output = int.Parse(input); //possibly throws FormatException
            if (output < 1 || output > maximumMatrixSize)
            {
                throw new ArgumentException();
            }
            return output;
        }

        private void createMatrixBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = acceptSize(matrixRowsCb.Text);
                int columns = acceptSize(matrixColumnsCb.Text);
                inputMatrixPanel = new InputMatrixPanel(rows, columns);
                if(matrixPanel.Controls.Count > 1)
                {
                    matrixPanel.Controls.RemoveAt(1);
                }
                matrixPanel.Controls.Add(inputMatrixPanel);
                upperTCheckBox.Checked = false;
                downerTCheckBox.Checked = false;
                rankLbl.Text = "Rank = ";
                determinantLbl.Text = "Determinant = ";
                
                if(rows == columns)
                {
                    inverseBtn.Enabled = true;
                    determinantLbl.Enabled = true;
                    triangularPropsPanel.Enabled = true;
                }
                else
                {
                    inverseBtn.Enabled = false;
                    determinantLbl.Enabled = false;
                    triangularPropsPanel.Enabled = false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Inputs must be non-negative integers.");
            }
            catch (ArgumentException)
            {
                MessageBox.Show($"Maximum matrix size is {maximumMatrixSize}x{maximumMatrixSize}.");
            }
        }

        private void calculateMatrixPropsBtn_Click(object sender, EventArgs e)
        {
            if (!updateMatrix())
            {
                return;
            }
            rankLbl.Text = $"Rank = {matrix.Rank}";
            if (matrix.IsQuadratic)
            {
                determinantLbl.Text ="Determinant = " + NumberFormatter.doubleFormat(matrix.Determinant);
                upperTCheckBox.Checked = matrix.IsUpperTriangular;
                downerTCheckBox.Checked = matrix.IsDownerTriangular;
            }
        }

        private bool updateMatrix()
        {
            //returns true if matrix has been updated successfuly
            if (inputMatrixPanel == null)
            {
                MessageBox.Show("Create matrix firstly.");
                return false;
            }
            try
            {
                this.matrix = inputMatrixPanel.GetMatrix();
            }
            catch (Exception)
            {
                MessageBox.Show("All inputs must be numbers.");
                return false;
            }
            return true;
        }

        private void EchFormBtn_Click(object sender, EventArgs e)
        {
            if (!updateMatrix())
            {
                return;
            }
            var echFormForm = new MatrixForm(matrix.EchelonForm);
            echFormForm.Show();
        }

        private void inverseBtn_Click(object sender, EventArgs e)
        {
            if (!updateMatrix())
            {
                return;
            }
            try
            {
                var inverseMatrixForm = new MatrixForm(matrix.Inverse);
                inverseMatrixForm.Show();
            }
            catch (MatrixNotInvertibileException)
            {
                MessageBox.Show("This matrix has no inverse.");
            }
        }

        private void minorBtn_Click(object sender, EventArgs e)
        {
            if (!updateMatrix())
            {
                return;
            }
            try
            {
                int row = int.Parse(minorRowTb.Text);
                int column = int.Parse(minorColumnTb.Text);
                var minorMatrixForm = new MatrixForm(matrix.GetMinor(row, column));
                minorMatrixForm.Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("Inputs must be non-negative integers.");
            }
            catch (IndexOutOfMatrixException)
            {
                MessageBox.Show("Selected row or column are outside the matrix.");
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void createMatricesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int r1 = acceptSize(firstMatrixRowsCb.Text);
                int c1 = acceptSize(firstMatrixColumnsCb.Text);
                int r2 = acceptSize(secondMatrixRowsCb.Text);
                int c2 = acceptSize(secondMatrixColumnsCb.Text);
                if(panelForOperations.Controls.Count != 0) 
                {
                    panelForOperations.Controls.RemoveAt(0);
                }
                operationsPanel = new OperationsPanel(r1, c1, r2, c2);
                panelForOperations.Controls.Add(operationsPanel);
            }
            catch (FormatException)
            {
                MessageBox.Show("Inputs must be non-negative integers.");
            }
            catch (ArgumentException)
            {
                MessageBox.Show($"Maximum matrix size is {maximumMatrixSize}x{maximumMatrixSize}.");
            }
        }

        private void calculateMatrixOp_Click(object sender, EventArgs e)
        {
            try
            {
                operand1 = operationsPanel.operand1Panel.GetMatrix();
                operand2 = operationsPanel.operand2Panel.GetMatrix();
                if (operationsPanel.operationsCombo.Text == "+")
                {
                    var resultForm = new MatrixForm(Matrix.Add(operand1, operand2));
                    resultForm.Show();
                } else if (operationsPanel.operationsCombo.Text == "-")
                {
                    var resultForm = new MatrixForm(Matrix.Add(operand1, Matrix.MultipyMatrixWithScalar(operand2, -1)));
                    resultForm.Show();
                } else if (operationsPanel.operationsCombo.Text == "*")
                {
                    var resultForm = new MatrixForm(Matrix.Multiply(operand1, operand2));
                    resultForm.Show();
                }
                else
                {
                    MessageBox.Show("Select valid operation (+, -, *).");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Create matrices firstly.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createEquationBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int numOfEq = acceptSize(numOfEqCombo.Text);
                int nuumOfVar = acceptSize(numOfVarsCombo.Text);
                if (panelForEquations.Controls.Count != 0)
                {
                    panelForEquations.Controls.RemoveAt(0);
                }
                equationPanel = new EquationPanel(numOfEq, nuumOfVar);
                panelForEquations.Controls.Add(equationPanel);
            }
            catch (FormatException)
            {
                MessageBox.Show("Inputs must be non-negative integers.");
            }
            catch (ArgumentException)
            {
                MessageBox.Show($"Maximum number of equations is {maximumMatrixSize}.\nMaximum number of variables is {maximumMatrixSize}.");
            }
        }

        private void calculateEquation_Click(object sender, EventArgs e)
        {
            try
            {
                systemOfEquations = new SystemOfLinearEquations(equationPanel.GetAugmentedMatrix());
                var solutionForm = new EquationSolutionForm(systemOfEquations.Solutions);
                solutionForm.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Create equations firstly.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
