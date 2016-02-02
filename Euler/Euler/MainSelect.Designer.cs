namespace Euler
{
    partial class frMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbEulerProblem = new System.Windows.Forms.ComboBox();
            this.btnEuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(150, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Select Problem Type";
            // 
            // cmbEulerProblem
            // 
            this.cmbEulerProblem.FormattingEnabled = true;
            this.cmbEulerProblem.Location = new System.Drawing.Point(155, 50);
            this.cmbEulerProblem.Name = "cmbEulerProblem";
            this.cmbEulerProblem.Size = new System.Drawing.Size(206, 21);
            this.cmbEulerProblem.TabIndex = 1;
            // 
            // btnEuler
            // 
            this.btnEuler.Location = new System.Drawing.Point(367, 48);
            this.btnEuler.Name = "btnEuler";
            this.btnEuler.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEuler.Size = new System.Drawing.Size(143, 23);
            this.btnEuler.TabIndex = 2;
            this.btnEuler.Text = "See Implementation";
            this.btnEuler.UseVisualStyleBackColor = true;
            this.btnEuler.Click += new System.EventHandler(this.btnEuler_Click);
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 261);
            this.Controls.Add(this.btnEuler);
            this.Controls.Add(this.cmbEulerProblem);
            this.Controls.Add(this.lblTitle);
            this.Name = "frMain";
            this.Text = "Euler and Other Problems";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbEulerProblem;
        private System.Windows.Forms.Button btnEuler;
    }
}

