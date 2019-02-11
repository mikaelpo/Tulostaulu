namespace Tulostaulu
{
    partial class kokoonpanot
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
            this.buttonK1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonK1
            // 
            this.buttonK1.Location = new System.Drawing.Point(640, 394);
            this.buttonK1.Name = "buttonK1";
            this.buttonK1.Size = new System.Drawing.Size(75, 23);
            this.buttonK1.TabIndex = 0;
            this.buttonK1.Text = "button1";
            this.buttonK1.UseVisualStyleBackColor = true;
            this.buttonK1.Click += new System.EventHandler(this.buttonK1_Click);
            // 
            // kokoonpanot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonK1);
            this.Name = "kokoonpanot";
            this.Text = "kokoonpanot";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonK1;
    }
}