namespace WinFormsUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.equationsTab = new System.Windows.Forms.TabPage();
            this.panelForEquations = new System.Windows.Forms.Panel();
            this.leftPanelEqTab = new System.Windows.Forms.Panel();
            this.downerPanelEqTab = new System.Windows.Forms.Panel();
            this.calculateEquation = new System.Windows.Forms.Button();
            this.upperPanelEqTab = new System.Windows.Forms.Panel();
            this.eqPropsPanel = new System.Windows.Forms.Panel();
            this.createEquationBtn = new System.Windows.Forms.Button();
            this.numOfVarsCombo = new System.Windows.Forms.ComboBox();
            this.numOfEqCombo = new System.Windows.Forms.ComboBox();
            this.numOfVarsLbl = new System.Windows.Forms.Label();
            this.numOfEqLbl = new System.Windows.Forms.Label();
            this.matrixTab = new System.Windows.Forms.TabPage();
            this.matrixPanel = new System.Windows.Forms.Panel();
            this.calculateMatrixPropsBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.downerPanelMTab = new System.Windows.Forms.TableLayoutPanel();
            this.inverseBtn = new System.Windows.Forms.Button();
            this.triangularPropsPanel = new System.Windows.Forms.Panel();
            this.downerTCheckBox = new System.Windows.Forms.CheckBox();
            this.upperTCheckBox = new System.Windows.Forms.CheckBox();
            this.EchFormBtn = new System.Windows.Forms.Button();
            this.determinantLbl = new System.Windows.Forms.Label();
            this.rankLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.minorPanel = new System.Windows.Forms.Panel();
            this.minorBtn = new System.Windows.Forms.Button();
            this.minorColumnTb = new System.Windows.Forms.TextBox();
            this.minorRowTb = new System.Windows.Forms.TextBox();
            this.minorColumnLbl = new System.Windows.Forms.Label();
            this.minorRowLbl = new System.Windows.Forms.Label();
            this.upperPannelMTab = new System.Windows.Forms.Panel();
            this.matrixPropsPanel = new System.Windows.Forms.Panel();
            this.createMatrixBtn = new System.Windows.Forms.Button();
            this.xLbl2 = new System.Windows.Forms.Label();
            this.matrixColumnsCb = new System.Windows.Forms.ComboBox();
            this.matrixRowsCb = new System.Windows.Forms.ComboBox();
            this.operationsTab = new System.Windows.Forms.TabPage();
            this.panelForOperations = new System.Windows.Forms.Panel();
            this.leftPanelOpTab = new System.Windows.Forms.Panel();
            this.downerPanelOpTab = new System.Windows.Forms.Panel();
            this.calculateMatrixOp = new System.Windows.Forms.Button();
            this.upperPanelOpTab = new System.Windows.Forms.Panel();
            this.opPropsPanel = new System.Windows.Forms.Panel();
            this.createMatricesBtn = new System.Windows.Forms.Button();
            this.secondMatrixColumnsCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.secondMatrixRowsCb = new System.Windows.Forms.ComboBox();
            this.firstMatrixColumnsCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstMatrixRowsCb = new System.Windows.Forms.ComboBox();
            this.secondMatrixLbl = new System.Windows.Forms.Label();
            this.firstMatrixLbl = new System.Windows.Forms.Label();
            this.helpTab = new System.Windows.Forms.TabPage();
            this.developerInfo = new System.Windows.Forms.Label();
            this.helpTextLabel = new System.Windows.Forms.Label();
            this.bottomPanelHelp = new System.Windows.Forms.Panel();
            this.sidePanelHelp = new System.Windows.Forms.Panel();
            this.mainTabControl.SuspendLayout();
            this.equationsTab.SuspendLayout();
            this.downerPanelEqTab.SuspendLayout();
            this.upperPanelEqTab.SuspendLayout();
            this.eqPropsPanel.SuspendLayout();
            this.matrixTab.SuspendLayout();
            this.matrixPanel.SuspendLayout();
            this.downerPanelMTab.SuspendLayout();
            this.triangularPropsPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.minorPanel.SuspendLayout();
            this.upperPannelMTab.SuspendLayout();
            this.matrixPropsPanel.SuspendLayout();
            this.operationsTab.SuspendLayout();
            this.downerPanelOpTab.SuspendLayout();
            this.upperPanelOpTab.SuspendLayout();
            this.opPropsPanel.SuspendLayout();
            this.helpTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.equationsTab);
            this.mainTabControl.Controls.Add(this.matrixTab);
            this.mainTabControl.Controls.Add(this.operationsTab);
            this.mainTabControl.Controls.Add(this.helpTab);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 2;
            this.mainTabControl.Size = new System.Drawing.Size(1110, 541);
            this.mainTabControl.TabIndex = 0;
            // 
            // equationsTab
            // 
            this.equationsTab.Controls.Add(this.panelForEquations);
            this.equationsTab.Controls.Add(this.leftPanelEqTab);
            this.equationsTab.Controls.Add(this.downerPanelEqTab);
            this.equationsTab.Controls.Add(this.upperPanelEqTab);
            this.equationsTab.Location = new System.Drawing.Point(4, 29);
            this.equationsTab.Name = "equationsTab";
            this.equationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.equationsTab.Size = new System.Drawing.Size(1102, 508);
            this.equationsTab.TabIndex = 0;
            this.equationsTab.Text = "System of Equations";
            this.equationsTab.UseVisualStyleBackColor = true;
            // 
            // panelForEquations
            // 
            this.panelForEquations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForEquations.Location = new System.Drawing.Point(53, 128);
            this.panelForEquations.Name = "panelForEquations";
            this.panelForEquations.Size = new System.Drawing.Size(1046, 317);
            this.panelForEquations.TabIndex = 3;
            // 
            // leftPanelEqTab
            // 
            this.leftPanelEqTab.BackColor = System.Drawing.Color.Orange;
            this.leftPanelEqTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanelEqTab.Location = new System.Drawing.Point(3, 128);
            this.leftPanelEqTab.Name = "leftPanelEqTab";
            this.leftPanelEqTab.Size = new System.Drawing.Size(50, 317);
            this.leftPanelEqTab.TabIndex = 2;
            // 
            // downerPanelEqTab
            // 
            this.downerPanelEqTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.downerPanelEqTab.Controls.Add(this.calculateEquation);
            this.downerPanelEqTab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downerPanelEqTab.Location = new System.Drawing.Point(3, 445);
            this.downerPanelEqTab.Name = "downerPanelEqTab";
            this.downerPanelEqTab.Size = new System.Drawing.Size(1096, 60);
            this.downerPanelEqTab.TabIndex = 1;
            // 
            // calculateEquation
            // 
            this.calculateEquation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calculateEquation.Location = new System.Drawing.Point(501, 16);
            this.calculateEquation.Name = "calculateEquation";
            this.calculateEquation.Size = new System.Drawing.Size(94, 29);
            this.calculateEquation.TabIndex = 0;
            this.calculateEquation.Text = "Calculate";
            this.calculateEquation.UseVisualStyleBackColor = true;
            this.calculateEquation.Click += new System.EventHandler(this.calculateEquation_Click);
            // 
            // upperPanelEqTab
            // 
            this.upperPanelEqTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.upperPanelEqTab.Controls.Add(this.eqPropsPanel);
            this.upperPanelEqTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanelEqTab.Location = new System.Drawing.Point(3, 3);
            this.upperPanelEqTab.Name = "upperPanelEqTab";
            this.upperPanelEqTab.Size = new System.Drawing.Size(1096, 125);
            this.upperPanelEqTab.TabIndex = 0;
            // 
            // eqPropsPanel
            // 
            this.eqPropsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eqPropsPanel.Controls.Add(this.createEquationBtn);
            this.eqPropsPanel.Controls.Add(this.numOfVarsCombo);
            this.eqPropsPanel.Controls.Add(this.numOfEqCombo);
            this.eqPropsPanel.Controls.Add(this.numOfVarsLbl);
            this.eqPropsPanel.Controls.Add(this.numOfEqLbl);
            this.eqPropsPanel.Location = new System.Drawing.Point(354, 11);
            this.eqPropsPanel.Name = "eqPropsPanel";
            this.eqPropsPanel.Size = new System.Drawing.Size(389, 103);
            this.eqPropsPanel.TabIndex = 0;
            // 
            // createEquationBtn
            // 
            this.createEquationBtn.Location = new System.Drawing.Point(282, 31);
            this.createEquationBtn.Name = "createEquationBtn";
            this.createEquationBtn.Size = new System.Drawing.Size(94, 29);
            this.createEquationBtn.TabIndex = 2;
            this.createEquationBtn.Text = "Create";
            this.createEquationBtn.UseVisualStyleBackColor = true;
            this.createEquationBtn.Click += new System.EventHandler(this.createEquationBtn_Click);
            // 
            // numOfVarsCombo
            // 
            this.numOfVarsCombo.FormattingEnabled = true;
            this.numOfVarsCombo.Location = new System.Drawing.Point(171, 49);
            this.numOfVarsCombo.Name = "numOfVarsCombo";
            this.numOfVarsCombo.Size = new System.Drawing.Size(75, 28);
            this.numOfVarsCombo.TabIndex = 1;
            // 
            // numOfEqCombo
            // 
            this.numOfEqCombo.Location = new System.Drawing.Point(171, 16);
            this.numOfEqCombo.Name = "numOfEqCombo";
            this.numOfEqCombo.Size = new System.Drawing.Size(75, 28);
            this.numOfEqCombo.TabIndex = 1;
            // 
            // numOfVarsLbl
            // 
            this.numOfVarsLbl.AutoSize = true;
            this.numOfVarsLbl.Location = new System.Drawing.Point(12, 52);
            this.numOfVarsLbl.Name = "numOfVarsLbl";
            this.numOfVarsLbl.Size = new System.Drawing.Size(147, 20);
            this.numOfVarsLbl.TabIndex = 0;
            this.numOfVarsLbl.Text = "Number of variables:";
            // 
            // numOfEqLbl
            // 
            this.numOfEqLbl.AutoSize = true;
            this.numOfEqLbl.Location = new System.Drawing.Point(12, 19);
            this.numOfEqLbl.Name = "numOfEqLbl";
            this.numOfEqLbl.Size = new System.Drawing.Size(153, 20);
            this.numOfEqLbl.TabIndex = 0;
            this.numOfEqLbl.Text = "Number of equations:";
            // 
            // matrixTab
            // 
            this.matrixTab.Controls.Add(this.matrixPanel);
            this.matrixTab.Controls.Add(this.panel1);
            this.matrixTab.Controls.Add(this.downerPanelMTab);
            this.matrixTab.Controls.Add(this.upperPannelMTab);
            this.matrixTab.Location = new System.Drawing.Point(4, 29);
            this.matrixTab.Name = "matrixTab";
            this.matrixTab.Padding = new System.Windows.Forms.Padding(3);
            this.matrixTab.Size = new System.Drawing.Size(1102, 508);
            this.matrixTab.TabIndex = 1;
            this.matrixTab.Text = "Matrix";
            this.matrixTab.UseVisualStyleBackColor = true;
            // 
            // matrixPanel
            // 
            this.matrixPanel.Controls.Add(this.calculateMatrixPropsBtn);
            this.matrixPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixPanel.Location = new System.Drawing.Point(53, 128);
            this.matrixPanel.Name = "matrixPanel";
            this.matrixPanel.Size = new System.Drawing.Size(1046, 223);
            this.matrixPanel.TabIndex = 4;
            // 
            // calculateMatrixPropsBtn
            // 
            this.calculateMatrixPropsBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.calculateMatrixPropsBtn.Location = new System.Drawing.Point(0, 194);
            this.calculateMatrixPropsBtn.Name = "calculateMatrixPropsBtn";
            this.calculateMatrixPropsBtn.Size = new System.Drawing.Size(1046, 29);
            this.calculateMatrixPropsBtn.TabIndex = 0;
            this.calculateMatrixPropsBtn.Text = "Calculate";
            this.calculateMatrixPropsBtn.UseVisualStyleBackColor = true;
            this.calculateMatrixPropsBtn.Click += new System.EventHandler(this.calculateMatrixPropsBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 223);
            this.panel1.TabIndex = 2;
            // 
            // downerPanelMTab
            // 
            this.downerPanelMTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.downerPanelMTab.ColumnCount = 3;
            this.downerPanelMTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.downerPanelMTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.downerPanelMTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.downerPanelMTab.Controls.Add(this.inverseBtn, 1, 1);
            this.downerPanelMTab.Controls.Add(this.triangularPropsPanel, 2, 1);
            this.downerPanelMTab.Controls.Add(this.EchFormBtn, 1, 0);
            this.downerPanelMTab.Controls.Add(this.determinantLbl, 0, 1);
            this.downerPanelMTab.Controls.Add(this.rankLbl, 0, 0);
            this.downerPanelMTab.Controls.Add(this.panel2, 2, 0);
            this.downerPanelMTab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downerPanelMTab.Location = new System.Drawing.Point(3, 351);
            this.downerPanelMTab.Name = "downerPanelMTab";
            this.downerPanelMTab.RowCount = 2;
            this.downerPanelMTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.downerPanelMTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.downerPanelMTab.Size = new System.Drawing.Size(1096, 154);
            this.downerPanelMTab.TabIndex = 3;
            // 
            // inverseBtn
            // 
            this.inverseBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inverseBtn.Location = new System.Drawing.Point(474, 101);
            this.inverseBtn.Name = "inverseBtn";
            this.inverseBtn.Size = new System.Drawing.Size(135, 29);
            this.inverseBtn.TabIndex = 3;
            this.inverseBtn.Text = "Inverse";
            this.inverseBtn.UseVisualStyleBackColor = true;
            this.inverseBtn.Click += new System.EventHandler(this.inverseBtn_Click);
            // 
            // triangularPropsPanel
            // 
            this.triangularPropsPanel.Controls.Add(this.downerTCheckBox);
            this.triangularPropsPanel.Controls.Add(this.upperTCheckBox);
            this.triangularPropsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triangularPropsPanel.Location = new System.Drawing.Point(725, 80);
            this.triangularPropsPanel.Name = "triangularPropsPanel";
            this.triangularPropsPanel.Size = new System.Drawing.Size(368, 71);
            this.triangularPropsPanel.TabIndex = 5;
            // 
            // downerTCheckBox
            // 
            this.downerTCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.downerTCheckBox.AutoSize = true;
            this.downerTCheckBox.Enabled = false;
            this.downerTCheckBox.Location = new System.Drawing.Point(108, 8);
            this.downerTCheckBox.Name = "downerTCheckBox";
            this.downerTCheckBox.Size = new System.Drawing.Size(153, 24);
            this.downerTCheckBox.TabIndex = 0;
            this.downerTCheckBox.Text = "Downer Triangular";
            // 
            // upperTCheckBox
            // 
            this.upperTCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.upperTCheckBox.AutoSize = true;
            this.upperTCheckBox.Enabled = false;
            this.upperTCheckBox.Location = new System.Drawing.Point(108, 38);
            this.upperTCheckBox.Name = "upperTCheckBox";
            this.upperTCheckBox.Size = new System.Drawing.Size(142, 24);
            this.upperTCheckBox.TabIndex = 0;
            this.upperTCheckBox.Text = "Upper Triangular";
            this.upperTCheckBox.UseVisualStyleBackColor = true;
            // 
            // EchFormBtn
            // 
            this.EchFormBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EchFormBtn.Location = new System.Drawing.Point(474, 24);
            this.EchFormBtn.Name = "EchFormBtn";
            this.EchFormBtn.Size = new System.Drawing.Size(135, 29);
            this.EchFormBtn.TabIndex = 2;
            this.EchFormBtn.Text = "Echelon Form";
            this.EchFormBtn.UseVisualStyleBackColor = true;
            this.EchFormBtn.Click += new System.EventHandler(this.EchFormBtn_Click);
            // 
            // determinantLbl
            // 
            this.determinantLbl.AutoSize = true;
            this.determinantLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.determinantLbl.Location = new System.Drawing.Point(3, 77);
            this.determinantLbl.Name = "determinantLbl";
            this.determinantLbl.Size = new System.Drawing.Size(355, 77);
            this.determinantLbl.TabIndex = 1;
            this.determinantLbl.Text = "Determinant = ";
            this.determinantLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rankLbl
            // 
            this.rankLbl.AutoSize = true;
            this.rankLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rankLbl.Location = new System.Drawing.Point(3, 0);
            this.rankLbl.Name = "rankLbl";
            this.rankLbl.Size = new System.Drawing.Size(355, 77);
            this.rankLbl.TabIndex = 0;
            this.rankLbl.Text = "Rank =   ";
            this.rankLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.minorPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(725, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 71);
            this.panel2.TabIndex = 4;
            // 
            // minorPanel
            // 
            this.minorPanel.Controls.Add(this.minorBtn);
            this.minorPanel.Controls.Add(this.minorColumnTb);
            this.minorPanel.Controls.Add(this.minorRowTb);
            this.minorPanel.Controls.Add(this.minorColumnLbl);
            this.minorPanel.Controls.Add(this.minorRowLbl);
            this.minorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minorPanel.Location = new System.Drawing.Point(0, 0);
            this.minorPanel.Name = "minorPanel";
            this.minorPanel.Size = new System.Drawing.Size(368, 71);
            this.minorPanel.TabIndex = 4;
            // 
            // minorBtn
            // 
            this.minorBtn.Location = new System.Drawing.Point(203, 19);
            this.minorBtn.Name = "minorBtn";
            this.minorBtn.Size = new System.Drawing.Size(94, 29);
            this.minorBtn.TabIndex = 3;
            this.minorBtn.Text = "Get Minor";
            this.minorBtn.UseVisualStyleBackColor = true;
            this.minorBtn.Click += new System.EventHandler(this.minorBtn_Click);
            // 
            // minorColumnTb
            // 
            this.minorColumnTb.Location = new System.Drawing.Point(113, 36);
            this.minorColumnTb.Name = "minorColumnTb";
            this.minorColumnTb.Size = new System.Drawing.Size(51, 27);
            this.minorColumnTb.TabIndex = 2;
            // 
            // minorRowTb
            // 
            this.minorRowTb.Location = new System.Drawing.Point(113, 7);
            this.minorRowTb.Name = "minorRowTb";
            this.minorRowTb.Size = new System.Drawing.Size(51, 27);
            this.minorRowTb.TabIndex = 2;
            // 
            // minorColumnLbl
            // 
            this.minorColumnLbl.AutoSize = true;
            this.minorColumnLbl.Location = new System.Drawing.Point(44, 39);
            this.minorColumnLbl.Name = "minorColumnLbl";
            this.minorColumnLbl.Size = new System.Drawing.Size(63, 20);
            this.minorColumnLbl.TabIndex = 1;
            this.minorColumnLbl.Text = "Column:";
            // 
            // minorRowLbl
            // 
            this.minorRowLbl.AutoSize = true;
            this.minorRowLbl.Location = new System.Drawing.Point(44, 10);
            this.minorRowLbl.Name = "minorRowLbl";
            this.minorRowLbl.Size = new System.Drawing.Size(41, 20);
            this.minorRowLbl.TabIndex = 0;
            this.minorRowLbl.Text = "Row:";
            // 
            // upperPannelMTab
            // 
            this.upperPannelMTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.upperPannelMTab.Controls.Add(this.matrixPropsPanel);
            this.upperPannelMTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPannelMTab.Location = new System.Drawing.Point(3, 3);
            this.upperPannelMTab.Name = "upperPannelMTab";
            this.upperPannelMTab.Size = new System.Drawing.Size(1096, 125);
            this.upperPannelMTab.TabIndex = 0;
            // 
            // matrixPropsPanel
            // 
            this.matrixPropsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.matrixPropsPanel.Controls.Add(this.createMatrixBtn);
            this.matrixPropsPanel.Controls.Add(this.xLbl2);
            this.matrixPropsPanel.Controls.Add(this.matrixColumnsCb);
            this.matrixPropsPanel.Controls.Add(this.matrixRowsCb);
            this.matrixPropsPanel.Location = new System.Drawing.Point(372, 31);
            this.matrixPropsPanel.Name = "matrixPropsPanel";
            this.matrixPropsPanel.Size = new System.Drawing.Size(352, 63);
            this.matrixPropsPanel.TabIndex = 0;
            // 
            // createMatrixBtn
            // 
            this.createMatrixBtn.Location = new System.Drawing.Point(241, 16);
            this.createMatrixBtn.Name = "createMatrixBtn";
            this.createMatrixBtn.Size = new System.Drawing.Size(94, 29);
            this.createMatrixBtn.TabIndex = 2;
            this.createMatrixBtn.Text = "Create";
            this.createMatrixBtn.UseVisualStyleBackColor = true;
            this.createMatrixBtn.Click += new System.EventHandler(this.createMatrixBtn_Click);
            // 
            // xLbl2
            // 
            this.xLbl2.AutoSize = true;
            this.xLbl2.Location = new System.Drawing.Point(107, 20);
            this.xLbl2.Name = "xLbl2";
            this.xLbl2.Size = new System.Drawing.Size(16, 20);
            this.xLbl2.TabIndex = 0;
            this.xLbl2.Text = "x";
            // 
            // matrixColumnsCb
            // 
            this.matrixColumnsCb.Location = new System.Drawing.Point(129, 17);
            this.matrixColumnsCb.Name = "matrixColumnsCb";
            this.matrixColumnsCb.Size = new System.Drawing.Size(75, 28);
            this.matrixColumnsCb.TabIndex = 1;
            // 
            // matrixRowsCb
            // 
            this.matrixRowsCb.Location = new System.Drawing.Point(26, 16);
            this.matrixRowsCb.Name = "matrixRowsCb";
            this.matrixRowsCb.Size = new System.Drawing.Size(75, 28);
            this.matrixRowsCb.TabIndex = 1;
            // 
            // operationsTab
            // 
            this.operationsTab.Controls.Add(this.panelForOperations);
            this.operationsTab.Controls.Add(this.leftPanelOpTab);
            this.operationsTab.Controls.Add(this.downerPanelOpTab);
            this.operationsTab.Controls.Add(this.upperPanelOpTab);
            this.operationsTab.Location = new System.Drawing.Point(4, 29);
            this.operationsTab.Name = "operationsTab";
            this.operationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.operationsTab.Size = new System.Drawing.Size(1102, 508);
            this.operationsTab.TabIndex = 2;
            this.operationsTab.Text = "Operations with Matrices";
            this.operationsTab.UseVisualStyleBackColor = true;
            // 
            // panelForOperations
            // 
            this.panelForOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForOperations.Location = new System.Drawing.Point(53, 128);
            this.panelForOperations.Name = "panelForOperations";
            this.panelForOperations.Size = new System.Drawing.Size(1046, 317);
            this.panelForOperations.TabIndex = 3;
            // 
            // leftPanelOpTab
            // 
            this.leftPanelOpTab.BackColor = System.Drawing.Color.Orange;
            this.leftPanelOpTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanelOpTab.Location = new System.Drawing.Point(3, 128);
            this.leftPanelOpTab.Name = "leftPanelOpTab";
            this.leftPanelOpTab.Size = new System.Drawing.Size(50, 317);
            this.leftPanelOpTab.TabIndex = 2;
            // 
            // downerPanelOpTab
            // 
            this.downerPanelOpTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.downerPanelOpTab.Controls.Add(this.calculateMatrixOp);
            this.downerPanelOpTab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downerPanelOpTab.Location = new System.Drawing.Point(3, 445);
            this.downerPanelOpTab.Name = "downerPanelOpTab";
            this.downerPanelOpTab.Size = new System.Drawing.Size(1096, 60);
            this.downerPanelOpTab.TabIndex = 1;
            // 
            // calculateMatrixOp
            // 
            this.calculateMatrixOp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calculateMatrixOp.Location = new System.Drawing.Point(501, 16);
            this.calculateMatrixOp.Name = "calculateMatrixOp";
            this.calculateMatrixOp.Size = new System.Drawing.Size(94, 29);
            this.calculateMatrixOp.TabIndex = 0;
            this.calculateMatrixOp.Text = "Calculate";
            this.calculateMatrixOp.UseVisualStyleBackColor = true;
            this.calculateMatrixOp.Click += new System.EventHandler(this.calculateMatrixOp_Click);
            // 
            // upperPanelOpTab
            // 
            this.upperPanelOpTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.upperPanelOpTab.Controls.Add(this.opPropsPanel);
            this.upperPanelOpTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanelOpTab.Location = new System.Drawing.Point(3, 3);
            this.upperPanelOpTab.Name = "upperPanelOpTab";
            this.upperPanelOpTab.Size = new System.Drawing.Size(1096, 125);
            this.upperPanelOpTab.TabIndex = 0;
            // 
            // opPropsPanel
            // 
            this.opPropsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.opPropsPanel.Controls.Add(this.createMatricesBtn);
            this.opPropsPanel.Controls.Add(this.secondMatrixColumnsCb);
            this.opPropsPanel.Controls.Add(this.label4);
            this.opPropsPanel.Controls.Add(this.secondMatrixRowsCb);
            this.opPropsPanel.Controls.Add(this.firstMatrixColumnsCb);
            this.opPropsPanel.Controls.Add(this.label3);
            this.opPropsPanel.Controls.Add(this.firstMatrixRowsCb);
            this.opPropsPanel.Controls.Add(this.secondMatrixLbl);
            this.opPropsPanel.Controls.Add(this.firstMatrixLbl);
            this.opPropsPanel.Location = new System.Drawing.Point(305, 14);
            this.opPropsPanel.Name = "opPropsPanel";
            this.opPropsPanel.Size = new System.Drawing.Size(486, 96);
            this.opPropsPanel.TabIndex = 0;
            // 
            // createMatricesBtn
            // 
            this.createMatricesBtn.Location = new System.Drawing.Point(372, 32);
            this.createMatricesBtn.Name = "createMatricesBtn";
            this.createMatricesBtn.Size = new System.Drawing.Size(94, 29);
            this.createMatricesBtn.TabIndex = 2;
            this.createMatricesBtn.Text = "Create";
            this.createMatricesBtn.UseVisualStyleBackColor = true;
            this.createMatricesBtn.Click += new System.EventHandler(this.createMatricesBtn_Click);
            // 
            // secondMatrixColumnsCb
            // 
            this.secondMatrixColumnsCb.Location = new System.Drawing.Point(273, 56);
            this.secondMatrixColumnsCb.Name = "secondMatrixColumnsCb";
            this.secondMatrixColumnsCb.Size = new System.Drawing.Size(75, 28);
            this.secondMatrixColumnsCb.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "x";
            // 
            // secondMatrixRowsCb
            // 
            this.secondMatrixRowsCb.Location = new System.Drawing.Point(170, 56);
            this.secondMatrixRowsCb.Name = "secondMatrixRowsCb";
            this.secondMatrixRowsCb.Size = new System.Drawing.Size(75, 28);
            this.secondMatrixRowsCb.TabIndex = 1;
            // 
            // firstMatrixColumnsCb
            // 
            this.firstMatrixColumnsCb.Location = new System.Drawing.Point(273, 12);
            this.firstMatrixColumnsCb.Name = "firstMatrixColumnsCb";
            this.firstMatrixColumnsCb.Size = new System.Drawing.Size(75, 28);
            this.firstMatrixColumnsCb.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "x";
            // 
            // firstMatrixRowsCb
            // 
            this.firstMatrixRowsCb.Location = new System.Drawing.Point(170, 12);
            this.firstMatrixRowsCb.Name = "firstMatrixRowsCb";
            this.firstMatrixRowsCb.Size = new System.Drawing.Size(75, 28);
            this.firstMatrixRowsCb.TabIndex = 1;
            // 
            // secondMatrixLbl
            // 
            this.secondMatrixLbl.AutoSize = true;
            this.secondMatrixLbl.Location = new System.Drawing.Point(20, 59);
            this.secondMatrixLbl.Name = "secondMatrixLbl";
            this.secondMatrixLbl.Size = new System.Drawing.Size(133, 20);
            this.secondMatrixLbl.TabIndex = 1;
            this.secondMatrixLbl.Text = "The second matrix:";
            // 
            // firstMatrixLbl
            // 
            this.firstMatrixLbl.AutoSize = true;
            this.firstMatrixLbl.Location = new System.Drawing.Point(20, 15);
            this.firstMatrixLbl.Name = "firstMatrixLbl";
            this.firstMatrixLbl.Size = new System.Drawing.Size(111, 20);
            this.firstMatrixLbl.TabIndex = 0;
            this.firstMatrixLbl.Text = "The first matrix:";
            // 
            // helpTab
            // 
            this.helpTab.Controls.Add(this.developerInfo);
            this.helpTab.Controls.Add(this.helpTextLabel);
            this.helpTab.Controls.Add(this.bottomPanelHelp);
            this.helpTab.Controls.Add(this.sidePanelHelp);
            this.helpTab.Location = new System.Drawing.Point(4, 29);
            this.helpTab.Name = "helpTab";
            this.helpTab.Padding = new System.Windows.Forms.Padding(3);
            this.helpTab.Size = new System.Drawing.Size(1102, 508);
            this.helpTab.TabIndex = 3;
            this.helpTab.Text = "Help";
            this.helpTab.UseVisualStyleBackColor = true;
            // 
            // developerInfo
            // 
            this.developerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.developerInfo.AutoSize = true;
            this.developerInfo.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.developerInfo.Location = new System.Drawing.Point(59, 422);
            this.developerInfo.Name = "developerInfo";
            this.developerInfo.Size = new System.Drawing.Size(185, 20);
            this.developerInfo.TabIndex = 6;
            this.developerInfo.Text = "Developed by Petar Novak";
            // 
            // helpTextLabel
            // 
            this.helpTextLabel.AutoSize = true;
            this.helpTextLabel.Location = new System.Drawing.Point(60, 7);
            this.helpTextLabel.Name = "helpTextLabel";
            this.helpTextLabel.Size = new System.Drawing.Size(38, 20);
            this.helpTextLabel.TabIndex = 5;
            this.helpTextLabel.Text = "help";
            // 
            // bottomPanelHelp
            // 
            this.bottomPanelHelp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bottomPanelHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanelHelp.Location = new System.Drawing.Point(53, 445);
            this.bottomPanelHelp.Name = "bottomPanelHelp";
            this.bottomPanelHelp.Size = new System.Drawing.Size(1046, 60);
            this.bottomPanelHelp.TabIndex = 4;
            // 
            // sidePanelHelp
            // 
            this.sidePanelHelp.BackColor = System.Drawing.Color.Orange;
            this.sidePanelHelp.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanelHelp.Location = new System.Drawing.Point(3, 3);
            this.sidePanelHelp.Name = "sidePanelHelp";
            this.sidePanelHelp.Size = new System.Drawing.Size(50, 502);
            this.sidePanelHelp.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1110, 541);
            this.Controls.Add(this.mainTabControl);
            this.MinimumSize = new System.Drawing.Size(526, 380);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linear Algebra Calculator";
            this.mainTabControl.ResumeLayout(false);
            this.equationsTab.ResumeLayout(false);
            this.downerPanelEqTab.ResumeLayout(false);
            this.upperPanelEqTab.ResumeLayout(false);
            this.eqPropsPanel.ResumeLayout(false);
            this.eqPropsPanel.PerformLayout();
            this.matrixTab.ResumeLayout(false);
            this.matrixPanel.ResumeLayout(false);
            this.downerPanelMTab.ResumeLayout(false);
            this.downerPanelMTab.PerformLayout();
            this.triangularPropsPanel.ResumeLayout(false);
            this.triangularPropsPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.minorPanel.ResumeLayout(false);
            this.minorPanel.PerformLayout();
            this.upperPannelMTab.ResumeLayout(false);
            this.matrixPropsPanel.ResumeLayout(false);
            this.matrixPropsPanel.PerformLayout();
            this.operationsTab.ResumeLayout(false);
            this.downerPanelOpTab.ResumeLayout(false);
            this.upperPanelOpTab.ResumeLayout(false);
            this.opPropsPanel.ResumeLayout(false);
            this.opPropsPanel.PerformLayout();
            this.helpTab.ResumeLayout(false);
            this.helpTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage equationsTab;
        private System.Windows.Forms.TabPage matrixTab;
        private System.Windows.Forms.TabPage operationsTab;
        private System.Windows.Forms.Panel upperPanelEqTab;
        private System.Windows.Forms.Panel upperPannelMTab;
        private System.Windows.Forms.Panel upperPanelOpTab;
        private System.Windows.Forms.Panel downerPanelOpTab;
        private System.Windows.Forms.Panel leftPanelEqTab;
        private System.Windows.Forms.Panel downerPanelEqTab;
        private System.Windows.Forms.Panel leftPanelOpTab;
        private System.Windows.Forms.Button calculateEquation;
        private System.Windows.Forms.Panel eqPropsPanel;
        private System.Windows.Forms.ComboBox numOfVarsCombo;
        private System.Windows.Forms.ComboBox numOfEqCombo;
        private System.Windows.Forms.Label numOfVarsLbl;
        private System.Windows.Forms.Label numOfEqLbl;
        private System.Windows.Forms.Button createEquationBtn;
        private System.Windows.Forms.Panel matrixPropsPanel;
        private System.Windows.Forms.ComboBox matrixColumnsCb;
        private System.Windows.Forms.ComboBox matrixRowsCb;
        private System.Windows.Forms.Label xLbl2;
        private System.Windows.Forms.Button createMatrixBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel downerPanelMTab;
        private System.Windows.Forms.Label rankLbl;
        private System.Windows.Forms.Label determinantLbl;
        private System.Windows.Forms.Button EchFormBtn;
        private System.Windows.Forms.Button inverseBtn;
        private System.Windows.Forms.Panel minorPanel;
        private System.Windows.Forms.Button minorBtn;
        private System.Windows.Forms.TextBox minorColumnTb;
        private System.Windows.Forms.TextBox minorRowTb;
        private System.Windows.Forms.Label minorColumnLbl;
        private System.Windows.Forms.Label minorRowLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel triangularPropsPanel;
        private System.Windows.Forms.CheckBox upperTCheckBox;
        private System.Windows.Forms.CheckBox downerTCheckBox;
        private System.Windows.Forms.Panel opPropsPanel;
        private System.Windows.Forms.Label secondMatrixLbl;
        private System.Windows.Forms.Label firstMatrixLbl;
        private System.Windows.Forms.Button createMatricesBtn;
        private System.Windows.Forms.ComboBox secondMatrixColumnsCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox secondMatrixRowsCb;
        private System.Windows.Forms.ComboBox firstMatrixColumnsCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox firstMatrixRowsCb;
        private System.Windows.Forms.Button calculateMatrixOp;
        private System.Windows.Forms.Panel matrixPanel;
        private System.Windows.Forms.Button calculateMatrixPropsBtn;
        private System.Windows.Forms.Panel panelForOperations;
        private System.Windows.Forms.Panel panelForEquations;
        private System.Windows.Forms.TabPage helpTab;
        private System.Windows.Forms.Panel bottomPanelHelp;
        private System.Windows.Forms.Panel sidePanelHelp;
        private System.Windows.Forms.Label helpTextLabel;
        private System.Windows.Forms.Label developerInfo;
    }
}

