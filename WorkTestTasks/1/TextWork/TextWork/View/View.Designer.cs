namespace TextWork.View
{
    partial class View
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonInputFileOpen = new System.Windows.Forms.Button();
            this.InputFileNameTextBox = new System.Windows.Forms.TextBox();
            this.OutputFileNameTextBox = new System.Windows.Forms.TextBox();
            this.ButtonOutputFileOpen = new System.Windows.Forms.Button();
            this.Convert = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.CheckBoxIsDeletePunctuation = new System.Windows.Forms.CheckBox();
            this.MinWordLengthLabel = new System.Windows.Forms.Label();
            this.WordMinLengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.OutputFileLabel = new System.Windows.Forms.Label();
            this.InputFileLabel = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WordMinLengthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(173, 131);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(452, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ButtonInputFileOpen
            // 
            this.ButtonInputFileOpen.Location = new System.Drawing.Point(378, 31);
            this.ButtonInputFileOpen.Name = "ButtonInputFileOpen";
            this.ButtonInputFileOpen.Size = new System.Drawing.Size(32, 23);
            this.ButtonInputFileOpen.TabIndex = 0;
            this.ButtonInputFileOpen.Text = "...";
            this.ButtonInputFileOpen.UseVisualStyleBackColor = true;
            this.ButtonInputFileOpen.Click += new System.EventHandler(this.ButtonFileOpen_Click);
            // 
            // InputFileNameTextBox
            // 
            this.InputFileNameTextBox.Location = new System.Drawing.Point(12, 33);
            this.InputFileNameTextBox.Name = "InputFileNameTextBox";
            this.InputFileNameTextBox.Size = new System.Drawing.Size(360, 20);
            this.InputFileNameTextBox.TabIndex = 0;
            // 
            // OutputFileNameTextBox
            // 
            this.OutputFileNameTextBox.Location = new System.Drawing.Point(12, 80);
            this.OutputFileNameTextBox.Name = "OutputFileNameTextBox";
            this.OutputFileNameTextBox.Size = new System.Drawing.Size(360, 20);
            this.OutputFileNameTextBox.TabIndex = 1;
            // 
            // ButtonOutputFileOpen
            // 
            this.ButtonOutputFileOpen.Location = new System.Drawing.Point(378, 77);
            this.ButtonOutputFileOpen.Name = "ButtonOutputFileOpen";
            this.ButtonOutputFileOpen.Size = new System.Drawing.Size(32, 23);
            this.ButtonOutputFileOpen.TabIndex = 2;
            this.ButtonOutputFileOpen.Text = "...";
            this.ButtonOutputFileOpen.UseVisualStyleBackColor = true;
            this.ButtonOutputFileOpen.Click += new System.EventHandler(this.ButtonOutputFileOpen_Click);
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(335, 167);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(75, 23);
            this.Convert.TabIndex = 3;
            this.Convert.Text = "Пуск";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.CheckBoxIsDeletePunctuation);
            this.Panel.Controls.Add(this.MinWordLengthLabel);
            this.Panel.Controls.Add(this.WordMinLengthNumericUpDown);
            this.Panel.Controls.Add(this.OutputFileLabel);
            this.Panel.Controls.Add(this.InputFileLabel);
            this.Panel.Controls.Add(this.Convert);
            this.Panel.Controls.Add(this.ButtonOutputFileOpen);
            this.Panel.Controls.Add(this.OutputFileNameTextBox);
            this.Panel.Controls.Add(this.ButtonInputFileOpen);
            this.Panel.Controls.Add(this.InputFileNameTextBox);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(422, 202);
            this.Panel.TabIndex = 1;
            // 
            // CheckBoxIsDeletePunctuation
            // 
            this.CheckBoxIsDeletePunctuation.AutoSize = true;
            this.CheckBoxIsDeletePunctuation.Location = new System.Drawing.Point(12, 150);
            this.CheckBoxIsDeletePunctuation.Name = "CheckBoxIsDeletePunctuation";
            this.CheckBoxIsDeletePunctuation.Size = new System.Drawing.Size(165, 17);
            this.CheckBoxIsDeletePunctuation.TabIndex = 8;
            this.CheckBoxIsDeletePunctuation.Text = "Удалять знаки препинания";
            this.CheckBoxIsDeletePunctuation.UseVisualStyleBackColor = true;
            // 
            // MinWordLengthLabel
            // 
            this.MinWordLengthLabel.AutoSize = true;
            this.MinWordLengthLabel.Location = new System.Drawing.Point(58, 126);
            this.MinWordLengthLabel.Name = "MinWordLengthLabel";
            this.MinWordLengthLabel.Size = new System.Drawing.Size(163, 13);
            this.MinWordLengthLabel.TabIndex = 7;
            this.MinWordLengthLabel.Text = "Минимальное чилсо символов";
            // 
            // WordMinLengthNumericUpDown
            // 
            this.WordMinLengthNumericUpDown.Location = new System.Drawing.Point(12, 124);
            this.WordMinLengthNumericUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.WordMinLengthNumericUpDown.Name = "WordMinLengthNumericUpDown";
            this.WordMinLengthNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.WordMinLengthNumericUpDown.TabIndex = 6;
            // 
            // OutputFileLabel
            // 
            this.OutputFileLabel.AutoSize = true;
            this.OutputFileLabel.Location = new System.Drawing.Point(12, 64);
            this.OutputFileLabel.Name = "OutputFileLabel";
            this.OutputFileLabel.Size = new System.Drawing.Size(72, 13);
            this.OutputFileLabel.TabIndex = 5;
            this.OutputFileLabel.Text = "Сохранить в:";
            // 
            // InputFileLabel
            // 
            this.InputFileLabel.AutoSize = true;
            this.InputFileLabel.Location = new System.Drawing.Point(12, 17);
            this.InputFileLabel.Name = "InputFileLabel";
            this.InputFileLabel.Size = new System.Drawing.Size(51, 13);
            this.InputFileLabel.TabIndex = 4;
            this.InputFileLabel.Text = "Открыть";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 202);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ковертер текста";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WordMinLengthNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ButtonInputFileOpen;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.TextBox InputFileNameTextBox;
        private System.Windows.Forms.TextBox OutputFileNameTextBox;
        private System.Windows.Forms.Button ButtonOutputFileOpen;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.CheckBox CheckBoxIsDeletePunctuation;
        private System.Windows.Forms.Label MinWordLengthLabel;
        private System.Windows.Forms.NumericUpDown WordMinLengthNumericUpDown;
        private System.Windows.Forms.Label OutputFileLabel;
        private System.Windows.Forms.Label InputFileLabel;
    }
}

