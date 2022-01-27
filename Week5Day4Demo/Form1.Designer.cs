namespace Week5Day4Demo
{
    partial class FormBouncyBallAnimation
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
            this.LabelBar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelBar
            // 
            this.LabelBar.BackColor = System.Drawing.Color.DodgerBlue;
            this.LabelBar.Location = new System.Drawing.Point(799, 1037);
            this.LabelBar.Name = "LabelBar";
            this.LabelBar.Size = new System.Drawing.Size(369, 30);
            this.LabelBar.TabIndex = 0;
            // 
            // FormBouncyBallAnimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1944, 1076);
            this.Controls.Add(this.LabelBar);
            this.Name = "FormBouncyBallAnimation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bouncing Ball Animation";
            this.Click += new System.EventHandler(this.FormBouncyBallAnimation_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelBar;
    }
}
