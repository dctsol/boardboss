namespace BOARDBoss.Presentation
{
    partial class Customizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customizer));
            this.label1 = new System.Windows.Forms.Label();
            this.ColorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ImageBGColor = new System.Windows.Forms.Button();
            this.CloseCustomizer = new System.Windows.Forms.Button();
            this.TextBGColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextFGColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextFont = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.UseFraming = new System.Windows.Forms.CheckBox();
            this.FramePicker = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image Background Color";
            // 
            // ImageBGColor
            // 
            this.ImageBGColor.Location = new System.Drawing.Point(181, 15);
            this.ImageBGColor.Name = "ImageBGColor";
            this.ImageBGColor.Size = new System.Drawing.Size(25, 26);
            this.ImageBGColor.TabIndex = 1;
            this.ImageBGColor.UseVisualStyleBackColor = true;
            this.ImageBGColor.Click += new System.EventHandler(this.ImageBGColor_Click);
            // 
            // CloseCustomizer
            // 
            this.CloseCustomizer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CloseCustomizer.Location = new System.Drawing.Point(123, 283);
            this.CloseCustomizer.Name = "CloseCustomizer";
            this.CloseCustomizer.Size = new System.Drawing.Size(83, 28);
            this.CloseCustomizer.TabIndex = 2;
            this.CloseCustomizer.Text = "&Close";
            this.CloseCustomizer.UseVisualStyleBackColor = true;
            // 
            // TextBGColor
            // 
            this.TextBGColor.Location = new System.Drawing.Point(181, 47);
            this.TextBGColor.Name = "TextBGColor";
            this.TextBGColor.Size = new System.Drawing.Size(25, 26);
            this.TextBGColor.TabIndex = 4;
            this.TextBGColor.UseVisualStyleBackColor = true;
            this.TextBGColor.Click += new System.EventHandler(this.TextBGColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text Background Color";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextFGColor
            // 
            this.TextFGColor.Location = new System.Drawing.Point(181, 83);
            this.TextFGColor.Name = "TextFGColor";
            this.TextFGColor.Size = new System.Drawing.Size(25, 26);
            this.TextFGColor.TabIndex = 6;
            this.TextFGColor.UseVisualStyleBackColor = true;
            this.TextFGColor.Click += new System.EventHandler(this.TextFGColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Text Foreground Color";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Text Font";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextFont
            // 
            this.TextFont.Location = new System.Drawing.Point(181, 117);
            this.TextFont.Name = "TextFont";
            this.TextFont.Size = new System.Drawing.Size(25, 26);
            this.TextFont.TabIndex = 8;
            this.TextFont.Text = "...";
            this.TextFont.UseVisualStyleBackColor = true;
            this.TextFont.Click += new System.EventHandler(this.TextFont_Click);
            // 
            // UseFraming
            // 
            this.UseFraming.AutoSize = true;
            this.UseFraming.Location = new System.Drawing.Point(13, 24);
            this.UseFraming.Name = "UseFraming";
            this.UseFraming.Size = new System.Drawing.Size(146, 21);
            this.UseFraming.TabIndex = 9;
            this.UseFraming.Text = "Enable Image Frame";
            this.UseFraming.UseVisualStyleBackColor = true;
            this.UseFraming.CheckedChanged += new System.EventHandler(this.UseFraming_CheckedChanged);
            // 
            // FramePicker
            // 
            this.FramePicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FramePicker.FormattingEnabled = true;
            this.FramePicker.Items.AddRange(new object[] {
            "Frame 1",
            "Frame 2",
            "Frame 3",
            "Frame 4",
            "Frame 5",
            "Frame 6",
            "Frame 7",
            "Frame 8",
            "Frame 9",
            "Frame 10",
            "Frame 11",
            "Frame 12",
            "Frame 13",
            "Frame 14"});
            this.FramePicker.Location = new System.Drawing.Point(13, 51);
            this.FramePicker.Name = "FramePicker";
            this.FramePicker.Size = new System.Drawing.Size(146, 25);
            this.FramePicker.TabIndex = 10;
            this.FramePicker.Visible = false;
            this.FramePicker.SelectedIndexChanged += new System.EventHandler(this.FramePicker_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UseFraming);
            this.groupBox1.Controls.Add(this.FramePicker);
            this.groupBox1.Location = new System.Drawing.Point(25, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 96);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option(s)";
            // 
            // Customizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 333);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TextFont);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextFGColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBGColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CloseCustomizer);
            this.Controls.Add(this.ImageBGColor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Customizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Board Customizer";
            this.Load += new System.EventHandler(this.Customizer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog ColorDialog1;
        private System.Windows.Forms.Button ImageBGColor;
        private System.Windows.Forms.Button CloseCustomizer;
        private System.Windows.Forms.Button TextBGColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TextFGColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TextFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.CheckBox UseFraming;
        private System.Windows.Forms.ComboBox FramePicker;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}