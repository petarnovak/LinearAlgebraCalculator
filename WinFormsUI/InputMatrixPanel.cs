using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using LinearAlgebra;

namespace WinFormsUI
{
    class InputMatrixPanel : TableLayoutPanel
    {
        private int rows;
        private int columns;
        public InputMatrixPanel(int rows, int columns)
        {
            if(rows < 1 || columns < 1)
            {
                throw new ArgumentException("Numbers of rows or columns can't be less then 1.");
            }
            this.rows = rows;
            this.columns = columns;
            this.RowCount = rows;
            this.ColumnCount = columns;
            this.Dock = DockStyle.Fill;
            textBoxes = new TextBox[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    TextBox tb = new TextBox();
                    tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                    tb.Dock = DockStyle.None;
                    textBoxes[i, j] = tb;
                    this.Controls.Add(tb, j, i);
                }
            }
            this.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            float columnPercentage = 100F / columns;
            float rowPercentage = 100F / rows;
            for (int i = 0; i < columns; i++)
            {
                if (i == columns - 1)
                {
                    this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 - i * columnPercentage));
                }
                else
                {
                    this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, columnPercentage));
                }
            }
            for (int i = 0; i < rows; i++)
            {
                if (i == rows - 1)
                {
                    this.RowStyles.Add(new RowStyle(SizeType.Percent, 100 - i * rowPercentage));
                }
                else
                {
                    this.RowStyles.Add(new RowStyle(SizeType.Percent, rowPercentage));
                }
            }
        }

        private TextBox[,] textBoxes;

        public Matrix GetMatrix()
        {
            double[,] numbers = new double[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    try
                    {
                        if (String.IsNullOrEmpty(textBoxes[i, j].Text))
                        {
                            numbers[i, j] = 0.0;
                        }
                        else
                        {
                            numbers[i, j] = Double.Parse(textBoxes[i, j].Text.Replace('.',','));
                        }
                    }
                    catch (Exception)
                    {

                        throw new ArgumentException("All inputs must be numbers.");
                    }
                    
                }
            }
            return new Matrix(rows, columns, numbers);
        }
    }
}
