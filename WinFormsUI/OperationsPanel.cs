using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinFormsUI
{
    class OperationsPanel : TableLayoutPanel
    {
        internal InputMatrixPanel operand1Panel;
        internal InputMatrixPanel operand2Panel;
        internal ComboBox operationsCombo;
        private Panel panelForLabel;
        private Panel panelForCombo;

        private int operand1Rows;
        private int operand1Columns;
        private int operand2Rows;
        private int operand2Columns;

        public OperationsPanel(int operand1Rows, int operand1Columns, int operand2Rows, int operand2Columns)
        {
            this.operand1Rows = operand1Rows;
            this.operand1Columns = operand1Columns;
            this.operand2Rows = operand2Rows;
            this.operand2Columns = operand2Columns;

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.RowCount = 1;
            this.ColumnCount = 4;
            this.Dock = DockStyle.Fill;
            float percentage1 = (((float)operand1Columns) / (operand1Columns + operand2Columns)) * 100;
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, percentage1));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F - percentage1));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));

            panelForLabel = new Panel() { Dock = DockStyle.Fill };
            panelForLabel.Controls.Add(new Label()
            {
                Text = "=",
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            });
            this.Controls.Add(panelForLabel, 3, 0);

            panelForCombo = new Panel() { Dock = DockStyle.Fill };
            operationsCombo = new ComboBox()
            {
                Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
                BackColor = System.Drawing.SystemColors.ActiveCaption,
                Anchor = System.Windows.Forms.AnchorStyles.None,
                Size = new System.Drawing.Size(70, 28),
                Location = new System.Drawing.Point((panelForCombo.Size.Width / 2) - 35, (panelForCombo.Size.Height / 2) - 14),
            };
            operationsCombo.Items.AddRange(new object[] { "+", "-", "*" });
            panelForCombo.Controls.Add(operationsCombo);
            this.Controls.Add(panelForCombo, 1, 0);

            operand1Panel = new InputMatrixPanel(operand1Rows, operand1Columns) { CellBorderStyle = TableLayoutPanelCellBorderStyle.Single };
            this.Controls.Add(operand1Panel, 0, 0);

            operand2Panel = new InputMatrixPanel(operand2Rows, operand2Columns) { CellBorderStyle = TableLayoutPanelCellBorderStyle.Single };
            this.Controls.Add(operand2Panel, 2, 0);
        }
    }
}
