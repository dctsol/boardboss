namespace BOARDBoss
{
    partial class SaveImageName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveImageName));
            this.label1 = new System.Windows.Forms.Label();
            this.ImageName = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelTransfer = new System.Windows.Forms.Button();
            this.ScreenNumber = new System.Windows.Forms.ComboBox();
            this.ScreenLayout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of the image.";
            // 
            // ImageName
            // 
            this.ImageName.Location = new System.Drawing.Point(16, 30);
            this.ImageName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImageName.Name = "ImageName";
            this.ImageName.Size = new System.Drawing.Size(184, 25);
            this.ImageName.TabIndex = 1;
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(174, 232);
            this.OKButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(87, 30);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Screen #";
            // 
            // CancelTransfer
            // 
            this.CancelTransfer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelTransfer.Location = new System.Drawing.Point(81, 232);
            this.CancelTransfer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelTransfer.Name = "CancelTransfer";
            this.CancelTransfer.Size = new System.Drawing.Size(87, 30);
            this.CancelTransfer.TabIndex = 5;
            this.CancelTransfer.Text = "C&ancel";
            this.CancelTransfer.UseVisualStyleBackColor = true;
            this.CancelTransfer.Click += new System.EventHandler(this.CancelTransfer_Click);
            // 
            // ScreenNumber
            // 
            this.ScreenNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScreenNumber.FormattingEnabled = true;
            this.ScreenNumber.Location = new System.Drawing.Point(204, 30);
            this.ScreenNumber.Name = "ScreenNumber";
            this.ScreenNumber.Size = new System.Drawing.Size(56, 25);
            this.ScreenNumber.TabIndex = 6;
            // 
            // ScreenLayout
            // 
            this.ScreenLayout.Location = new System.Drawing.Point(16, 62);
            this.ScreenLayout.Name = "ScreenLayout";
            this.ScreenLayout.Size = new System.Drawing.Size(245, 163);
            this.ScreenLayout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ScreenLayout.TabIndex = 7;
            this.ScreenLayout.TabStop = false;
            // 
            // SaveImageName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 275);
            this.Controls.Add(this.ScreenLayout);
            this.Controls.Add(this.ScreenNumber);
            this.Controls.Add(this.CancelTransfer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ImageName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveImageName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AVSTV Transfer";
            ((System.ComponentModel.ISupportInitialize)(this.ScreenLayout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OKButton;
        public System.Windows.Forms.TextBox ImageName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelTransfer;
        public System.Windows.Forms.ComboBox ScreenNumber;
        public System.Windows.Forms.PictureBox ScreenLayout;
    }
}