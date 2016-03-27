namespace BOARDBoss.Presentation
{
    partial class SaveBoardDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveBoardDialog));
            this.BoardName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoardName
            // 
            this.BoardName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoardName.Location = new System.Drawing.Point(17, 33);
            this.BoardName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BoardName.Name = "BoardName";
            this.BoardName.Size = new System.Drawing.Size(286, 27);
            this.BoardName.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Board Name";
            // 
            // SaveBoard
            // 
            this.SaveBoard.Location = new System.Drawing.Point(219, 73);
            this.SaveBoard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveBoard.Name = "SaveBoard";
            this.SaveBoard.Size = new System.Drawing.Size(84, 30);
            this.SaveBoard.TabIndex = 34;
            this.SaveBoard.Text = "&Save";
            this.SaveBoard.UseVisualStyleBackColor = true;
            this.SaveBoard.Click += new System.EventHandler(this.SaveBoard_Click);
            // 
            // SaveBoardDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 120);
            this.Controls.Add(this.BoardName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveBoard);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveBoardDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Save Board";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoardName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveBoard;
    }
}