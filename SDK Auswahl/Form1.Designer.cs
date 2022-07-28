namespace SDK_Auswahl
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Ü1 = new System.Windows.Forms.Label();
            this.goldsrcButton = new System.Windows.Forms.Button();
            this.sourceButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.FeedbackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ü1
            // 
            this.Ü1.AutoSize = true;
            this.Ü1.Font = new System.Drawing.Font("Salina", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ü1.Location = new System.Drawing.Point(211, 9);
            this.Ü1.Name = "Ü1";
            this.Ü1.Size = new System.Drawing.Size(529, 43);
            this.Ü1.TabIndex = 0;
            this.Ü1.Text = "Willkommen bei der SDK Auswahl";
            // 
            // goldsrcButton
            // 
            this.goldsrcButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.goldsrcButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goldsrcButton.Font = new System.Drawing.Font("Terminator Two", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goldsrcButton.Image = global::SDK_Auswahl.Properties.Resources.Goldsrc_image;
            this.goldsrcButton.Location = new System.Drawing.Point(12, 167);
            this.goldsrcButton.Name = "goldsrcButton";
            this.goldsrcButton.Size = new System.Drawing.Size(229, 259);
            this.goldsrcButton.TabIndex = 4;
            this.goldsrcButton.Text = "Goldsource\r\n";
            this.goldsrcButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.goldsrcButton.UseVisualStyleBackColor = true;
            // 
            // sourceButton
            // 
            this.sourceButton.Font = new System.Drawing.Font("Terminator Two", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sourceButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sourceButton.Image = global::SDK_Auswahl.Properties.Resources.SOURCE_IMAGE_small;
            this.sourceButton.Location = new System.Drawing.Point(360, 167);
            this.sourceButton.Name = "sourceButton";
            this.sourceButton.Size = new System.Drawing.Size(233, 259);
            this.sourceButton.TabIndex = 5;
            this.sourceButton.Text = "Source 1";
            this.sourceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sourceButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Terminator Two", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = global::SDK_Auswahl.Properties.Resources.hla_icon;
            this.button2.Location = new System.Drawing.Point(743, 167);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(224, 259);
            this.button2.TabIndex = 6;
            this.button2.Text = "Source 2\r\n";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(12, 594);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(106, 23);
            this.HelpButton.TabIndex = 7;
            this.HelpButton.Text = "Hilfe?";
            this.HelpButton.UseVisualStyleBackColor = true;
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(124, 594);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(117, 23);
            this.AboutButton.TabIndex = 8;
            this.AboutButton.Text = "Über SDK Auswahl";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close.Location = new System.Drawing.Point(880, 594);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(98, 23);
            this.Close.TabIndex = 9;
            this.Close.Text = "Schließen";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // FeedbackButton
            // 
            this.FeedbackButton.Location = new System.Drawing.Point(583, 594);
            this.FeedbackButton.Name = "FeedbackButton";
            this.FeedbackButton.Size = new System.Drawing.Size(291, 23);
            this.FeedbackButton.TabIndex = 10;
            this.FeedbackButton.Text = "Fehler? Hier können sie Fehler und Feedback geben!";
            this.FeedbackButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 629);
            this.Controls.Add(this.FeedbackButton);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sourceButton);
            this.Controls.Add(this.goldsrcButton);
            this.Controls.Add(this.Ü1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SDK Auswahl DEV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Ü1;
        private Button goldsrcButton;
        private Button sourceButton;
        private Button button2;
        private Button HelpButton;
        private Button AboutButton;
        private Button Close;
        private Button FeedbackButton;
    }
}