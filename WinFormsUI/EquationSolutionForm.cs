using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class EquationSolutionForm : Form
    {
        private TableLayoutPanel tableLayoutPanel;
        public EquationSolutionForm(List<string> solutionList)
        {
            InitializeComponent();
            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.RowCount = solutionList.Count;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.Dock = DockStyle.Fill;

            float rowPercentage = 100F / solutionList.Count;
            for (int i = 0; i < solutionList.Count; i++)
            {
                if (i == solutionList.Count - 1)
                {
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100 - i * rowPercentage));
                }
                else
                {
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, rowPercentage));
                }
            }

            for (int i = 0; i < solutionList.Count; i++)
            {
                tableLayoutPanel.Controls.Add(new Label()
                {
                    Text = solutionList.ElementAt(i),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
                }, 0, i);
            }
            panelForSolutions.Controls.Add(tableLayoutPanel);
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
