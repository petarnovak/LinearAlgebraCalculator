namespace WinFormsUI
{
    partial class MatrixForm
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
            this.panelWButtons = new System.Windows.Forms.Panel();
            this.okBtn = new System.Windows.Forms.Button();
            this.panelForMatrix = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelWButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWButtons
            // 
            this.panelWButtons.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelWButtons.Controls.Add(this.okBtn);
            this.panelWButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelWButtons.Location = new System.Drawing.Point(0, 385);
            this.panelWButtons.Name = "panelWButtons";
            this.panelWButtons.Size = new System.Drawing.Size(800, 65);
            this.panelWButtons.TabIndex = 0;
            // 
            // okBtn
            // 
            this.okBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okBtn.Location = new System.Drawing.Point(353, 18);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(94, 29);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // panelForMatrix
            // 
            this.panelForMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForMatrix.Location = new System.Drawing.Point(56, 12);
            this.panelForMatrix.Name = "panelForMatrix";
            this.panelForMatrix.Size = new System.Drawing.Size(732, 367);
            this.panelForMatrix.TabIndex = 1;
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
            // MatrixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelForMatrix);
            this.Controls.Add(this.panelWButtons);
            this.Name = "MatrixForm";
            this.Text = "Matrix";
            this.panelWButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWButtons;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Panel panelForMatrix;
        private System.Windows.Forms.Panel panel1;
    }
}