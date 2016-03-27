namespace BOARDBoss.Presentation
{
    partial class BoardSelect
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
            this.ListBoards = new System.Windows.Forms.ListBox();
            this.CancelOpen = new System.Windows.Forms.Button();
            this.OpenBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoards
            // 
            this.ListBoards.FormattingEnabled = true;
            this.ListBoards.Location = new System.Drawing.Point(12, 12);
            this.ListBoards.Name = "ListBoards";
            this.ListBoards.Size = new System.Drawing.Size(254, 186);
            this.ListBoards.TabIndex = 0;
            // 
            // CancelOpen
            // 
            this.CancelOpen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelOpen.Location = new System.Drawing.Point(110, 204);
            this.CancelOpen.Name = "CancelOpen";
            this.CancelOpen.Size = new System.Drawing.Size(75, 23);
            this.CancelOpen.TabIndex = 1;
            this.CancelOpen.Text = "C&ancel";
            this.CancelOpen.UseVisualStyleBackColor = true;
            this.CancelOpen.Click += new System.EventHandler(this.CancelOpen_Click);
            // 
            // OpenBoard
            // 
            this.OpenBoard.Location = new System.Drawing.Point(191, 204);
            this.OpenBoard.Name = "OpenBoard";
            this.OpenBoard.Size = new System.Drawing.Size(75, 23);
            this.OpenBoard.TabIndex = 2;
            this.OpenBoard.Text = "Open";
            this.OpenBoard.UseVisualStyleBackColor = true;
            this.OpenBoard.Click += new System.EventHandler(this.OpenBoard_Click);
            // 
            // BoardSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 240);
            this.Controls.Add(this.OpenBoard);
            this.Controls.Add(this.CancelOpen);
            this.Controls.Add(this.ListBoards);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BoardSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Saved Board Selector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoards;
        private System.Windows.Forms.Button CancelOpen;
        private System.Windows.Forms.Button OpenBoard;
    }
}