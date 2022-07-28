namespace SDK_Auswahl
{
    partial class Aboutbox
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Version = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Devloper = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(434, 276);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Schließen";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SDK_Auswahl.Properties.Resources.My_Image;
            this.pictureBox1.Location = new System.Drawing.Point(12, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 108);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(259, 48);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(175, 15);
            this.Version.TabIndex = 2;
            this.Version.Text = "Version:                          0.1-alpha";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(259, 81);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(192, 15);
            this.Name.TabIndex = 3;
            this.Name.Text = "Name:                           SDK Auswahl";
            // 
            // Devloper
            // 
            this.Devloper.AutoSize = true;
            this.Devloper.Location = new System.Drawing.Point(259, 114);
            this.Devloper.Name = "Devloper";
            this.Devloper.Size = new System.Drawing.Size(179, 15);
            this.Devloper.TabIndex = 4;
            this.Devloper.Text = "Entwickler:                   TheBlokker";
            // 
            // Aboutbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 311);
            this.Controls.Add(this.Devloper);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CloseButton);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            //const string V = "AboutBox";
            //this.Name = V;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Über SDK Auswahl";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CloseButton;
        private PictureBox pictureBox1;
        private Label Version;
        private Label Name;
        private Label Devloper;
    }
}