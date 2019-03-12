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
            this.textBoxK1 = new System.Windows.Forms.TextBox();
            this.buttonK2 = new System.Windows.Forms.Button();
            this.buttonK3 = new System.Windows.Forms.Button();
            this.textBoxK2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxK3 = new System.Windows.Forms.TextBox();
            this.buttonK4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonK1
            // 
            this.buttonK1.Location = new System.Drawing.Point(640, 394);
            this.buttonK1.Name = "buttonK1";
            this.buttonK1.Size = new System.Drawing.Size(95, 23);
            this.buttonK1.TabIndex = 0;
            this.buttonK1.Text = "Seuraava";
            this.buttonK1.UseVisualStyleBackColor = true;
            this.buttonK1.Click += new System.EventHandler(this.buttonK1_Click);
            // 
            // textBoxK1
            // 
            this.textBoxK1.Location = new System.Drawing.Point(11, 51);
            this.textBoxK1.Name = "textBoxK1";
            this.textBoxK1.Size = new System.Drawing.Size(257, 22);
            this.textBoxK1.TabIndex = 1;
            // 
            // buttonK2
            // 
            this.buttonK2.Location = new System.Drawing.Point(11, 22);
            this.buttonK2.Name = "buttonK2";
            this.buttonK2.Size = new System.Drawing.Size(215, 23);
            this.buttonK2.TabIndex = 2;
            this.buttonK2.Text = "Hae pelaajat";
            this.buttonK2.UseVisualStyleBackColor = true;
            this.buttonK2.Click += new System.EventHandler(this.buttonK2_Click);
            // 
            // buttonK3
            // 
            this.buttonK3.Location = new System.Drawing.Point(11, 93);
            this.buttonK3.Name = "buttonK3";
            this.buttonK3.Size = new System.Drawing.Size(216, 23);
            this.buttonK3.TabIndex = 7;
            this.buttonK3.Text = "Kotijoukkueen kuva";
            this.buttonK3.UseVisualStyleBackColor = true;
            this.buttonK3.Click += new System.EventHandler(this.buttonK3_Click);
            // 
            // textBoxK2
            // 
            this.textBoxK2.Location = new System.Drawing.Point(12, 122);
            this.textBoxK2.Name = "textBoxK2";
            this.textBoxK2.Size = new System.Drawing.Size(256, 22);
            this.textBoxK2.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxK3
            // 
            this.textBoxK3.Location = new System.Drawing.Point(12, 190);
            this.textBoxK3.Name = "textBoxK3";
            this.textBoxK3.Size = new System.Drawing.Size(256, 22);
            this.textBoxK3.TabIndex = 9;
            // 
            // buttonK4
            // 
            this.buttonK4.Location = new System.Drawing.Point(12, 161);
            this.buttonK4.Name = "buttonK4";
            this.buttonK4.Size = new System.Drawing.Size(215, 23);
            this.buttonK4.TabIndex = 10;
            this.buttonK4.Text = "Vierasjoukkueen kuva";
            this.buttonK4.UseVisualStyleBackColor = true;
            this.buttonK4.Click += new System.EventHandler(this.buttonK4_Click);
            // 
            // kokoonpanot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonK4);
            this.Controls.Add(this.textBoxK3);
            this.Controls.Add(this.textBoxK2);
            this.Controls.Add(this.buttonK3);
            this.Controls.Add(this.buttonK2);
            this.Controls.Add(this.textBoxK1);
            this.Controls.Add(this.buttonK1);
            this.Name = "kokoonpanot";
            this.Text = "Kokoonpanot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonK1;
        private System.Windows.Forms.TextBox textBoxK1;
        private System.Windows.Forms.Button buttonK2;
        private System.Windows.Forms.Button buttonK3;
        private System.Windows.Forms.TextBox textBoxK2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxK3;
        private System.Windows.Forms.Button buttonK4;
    }
}