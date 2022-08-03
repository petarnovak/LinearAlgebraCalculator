namespace WinFormsUI
{
    partial class EquationSolutionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.downerPanel = new System.Windows.Forms.Panel();
            this.okBtn = new System.Windows.Forms.Button();
            this.panelForSolutions = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.downerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // downerPanel
            // 
            this.downerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.downerPanel.Controls.Add(this.okBtn);
            this.downerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downerPanel.Location = new System.Drawing.Point(0, 385);
            this.downerPanel.Name = "downerPanel";
            this.downerPanel.Size = new System.Drawing.Size(406, 65);
            this.downerPanel.TabIndex = 0;
            // 
            // okBtn
            // 
            this.okBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okBtn.Location = new System.Drawing.Point(156, 18);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(94, 29);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // panelForSolutions
            // 
            this.panelForSolutions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForSolutions.Location = new System.Drawing.Point(56, 12);
            this.panelForSolutions.Name = "panelForSolutions";
            this.panelForSolutions.Size = new System.Drawing.Size(338, 367);
            this.panelForSolutions.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 385);
            this.panel1.TabIndex = 2;
            // 
            // EquationSolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelForSolutions);
            this.Controls.Add(this.downerPanel);
            this.Name = "EquationSolutionForm";
            this.Text = "System of Equations Solution";
            this.downerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Panel downerPanel;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Panel panelForSolutions;
        private System.Windows.Forms.Panel panel1;
        #endregion
    }
}