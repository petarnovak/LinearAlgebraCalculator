using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LinearAlgebra;

namespace WinFormsUI
{
    public partial class MatrixForm : Form
    {
        private TableLayoutPanel layoutPanel;
        private Label[,] labels;
        public MatrixForm(Matrix matrix)
        {
            InitializeComponent();
            layoutPanel = new TableLayoutPanel();
            layoutPanel.RowCount = matrix.NumOfRows;
            layoutPanel.ColumnCount = matrix.NumOfColumns;

            labels = new Label[layoutPanel.RowCount, layoutPanel.ColumnCount];
            for (int i = 0; i < layoutPanel.RowCount; i++)
            {
                for (int j = 0; j < layoutPanel.ColumnCount; j++)
                {
                    labels[i, j] = new Label() { Text = NumberFormatter.doubleFormat(matrix.GetElementAt(i + 1, j + 1)), Dock = DockStyle.Fill, TextAlign = System.Drawing.ContentAlignment.MiddleCenter };
                    layoutPanel.Controls.Add(labels[i, j], j, i);
                }
            }

            layoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            layoutPanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            float columnPercentage = 100F / layoutPanel.ColumnCount;
            float rowPercentage = 100F / layoutPanel.RowCount;
            for (int i = 0; i < layoutPanel.ColumnCount; i++)
            {
                if (i == layoutPanel.ColumnCount - 1)
                {
                    layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 - i * columnPercentage));
                }
                else
                {
                    layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, columnPercentage));
                }
            }
            for (int i = 0; i < layoutPanel.RowCount; i++)
            {
                if (i == layoutPanel.RowCount - 1)
                {
                    layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100 - i * rowPercentage));
                }
                else
                {
                    layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, rowPercentage));
                }
            }

            layoutPanel.Dock = DockStyle.Fill;
            panelForMatrix.Controls.Add(layoutPanel);
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
