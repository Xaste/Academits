namespace ATMWork.View
{
    partial class WithDrawInfo
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
            this.buttonWithDraw = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // buttonWithDraw
            // 
            this.buttonWithDraw.Location = new System.Drawing.Point(56, 151);
            this.buttonWithDraw.Name = "buttonWithDraw";
            this.buttonWithDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonWithDraw.TabIndex = 0;
            this.buttonWithDraw.Text = "Выдать";
            this.buttonWithDraw.UseVisualStyleBackColor = true;
            this.buttonWithDraw.Click += new System.EventHandler(this.buttonWithDraw_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.CheckOnClick = true;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(39, 37);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox.TabIndex = 1;
            // 
            // WithDrawInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 186);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.buttonWithDraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(225, 225);
            this.Name = "WithDrawInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Купюры";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonWithDraw;
        private System.Windows.Forms.CheckedListBox checkedListBox;
    }
}