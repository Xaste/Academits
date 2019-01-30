namespace ATMWork
{
    partial class ATM_Interface
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_WithDraw = new System.Windows.Forms.Label();
            this.button_WithDraw = new System.Windows.Forms.Button();
            this.comboBox_WithDrawBankNotes = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel_BanknotesCapacity = new System.Windows.Forms.FlowLayoutPanel();
            this.Label_BankNote1_capacity = new System.Windows.Forms.Label();
            this.Label_BankNote2_capacity = new System.Windows.Forms.Label();
            this.Label_BankNote3_capacity = new System.Windows.Forms.Label();
            this.Label_BankNote4_capacity = new System.Windows.Forms.Label();
            this.Label_BankNote5_capacity = new System.Windows.Forms.Label();
            this.Label_BankNote6_capacity = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Banknotes = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Banknote1 = new System.Windows.Forms.Button();
            this.button_Banknote2 = new System.Windows.Forms.Button();
            this.button_Banknote3 = new System.Windows.Forms.Button();
            this.button_Banknote4 = new System.Windows.Forms.Button();
            this.button_Banknote5 = new System.Windows.Forms.Button();
            this.button_Banknote6 = new System.Windows.Forms.Button();
            this.label_Balance = new System.Windows.Forms.Label();
            this.textBox_Balance = new System.Windows.Forms.TextBox();
            this.numericUpDown_WithDrawSum = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel_BanknotesCapacity.SuspendLayout();
            this.flowLayoutPanel_Banknotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_WithDrawSum)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown_WithDrawSum);
            this.panel1.Controls.Add(this.label_WithDraw);
            this.panel1.Controls.Add(this.button_WithDraw);
            this.panel1.Controls.Add(this.comboBox_WithDrawBankNotes);
            this.panel1.Controls.Add(this.flowLayoutPanel_BanknotesCapacity);
            this.panel1.Controls.Add(this.flowLayoutPanel_Banknotes);
            this.panel1.Controls.Add(this.label_Balance);
            this.panel1.Controls.Add(this.textBox_Balance);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 396);
            this.panel1.TabIndex = 0;
            // 
            // label_WithDraw
            // 
            this.label_WithDraw.AutoSize = true;
            this.label_WithDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_WithDraw.Location = new System.Drawing.Point(54, 258);
            this.label_WithDraw.Name = "label_WithDraw";
            this.label_WithDraw.Size = new System.Drawing.Size(81, 25);
            this.label_WithDraw.TabIndex = 6;
            this.label_WithDraw.Text = "Выдача";
            // 
            // button_WithDraw
            // 
            this.button_WithDraw.Location = new System.Drawing.Point(34, 323);
            this.button_WithDraw.Name = "button_WithDraw";
            this.button_WithDraw.Size = new System.Drawing.Size(111, 51);
            this.button_WithDraw.TabIndex = 5;
            this.button_WithDraw.Text = "Выдать";
            this.button_WithDraw.UseVisualStyleBackColor = true;
            this.button_WithDraw.Click += new System.EventHandler(this.Button_WithDraw_Click);
            // 
            // comboBox_WithDrawBankNotes
            // 
            this.comboBox_WithDrawBankNotes.FormattingEnabled = true;
            this.comboBox_WithDrawBankNotes.Location = new System.Drawing.Point(115, 286);
            this.comboBox_WithDrawBankNotes.MaxDropDownItems = 6;
            this.comboBox_WithDrawBankNotes.Name = "comboBox_WithDrawBankNotes";
            this.comboBox_WithDrawBankNotes.Size = new System.Drawing.Size(71, 21);
            this.comboBox_WithDrawBankNotes.TabIndex = 4;
            this.comboBox_WithDrawBankNotes.Text = "Номинал выдачи";
            // 
            // flowLayoutPanel_BanknotesCapacity
            // 
            this.flowLayoutPanel_BanknotesCapacity.Controls.Add(this.Label_BankNote1_capacity);
            this.flowLayoutPanel_BanknotesCapacity.Controls.Add(this.Label_BankNote2_capacity);
            this.flowLayoutPanel_BanknotesCapacity.Controls.Add(this.Label_BankNote3_capacity);
            this.flowLayoutPanel_BanknotesCapacity.Controls.Add(this.Label_BankNote4_capacity);
            this.flowLayoutPanel_BanknotesCapacity.Controls.Add(this.Label_BankNote5_capacity);
            this.flowLayoutPanel_BanknotesCapacity.Controls.Add(this.Label_BankNote6_capacity);
            this.flowLayoutPanel_BanknotesCapacity.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_BanknotesCapacity.Location = new System.Drawing.Point(115, 73);
            this.flowLayoutPanel_BanknotesCapacity.Name = "flowLayoutPanel_BanknotesCapacity";
            this.flowLayoutPanel_BanknotesCapacity.Size = new System.Drawing.Size(71, 174);
            this.flowLayoutPanel_BanknotesCapacity.TabIndex = 3;
            // 
            // Label_BankNote1_capacity
            // 
            this.Label_BankNote1_capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_BankNote1_capacity.Location = new System.Drawing.Point(3, 3);
            this.Label_BankNote1_capacity.Margin = new System.Windows.Forms.Padding(3);
            this.Label_BankNote1_capacity.Name = "Label_BankNote1_capacity";
            this.Label_BankNote1_capacity.Size = new System.Drawing.Size(68, 23);
            this.Label_BankNote1_capacity.TabIndex = 0;
            this.Label_BankNote1_capacity.Text = "00/100";
            this.Label_BankNote1_capacity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_BankNote2_capacity
            // 
            this.Label_BankNote2_capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_BankNote2_capacity.Location = new System.Drawing.Point(3, 32);
            this.Label_BankNote2_capacity.Margin = new System.Windows.Forms.Padding(3);
            this.Label_BankNote2_capacity.Name = "Label_BankNote2_capacity";
            this.Label_BankNote2_capacity.Size = new System.Drawing.Size(68, 23);
            this.Label_BankNote2_capacity.TabIndex = 1;
            this.Label_BankNote2_capacity.Text = "00/100";
            this.Label_BankNote2_capacity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_BankNote3_capacity
            // 
            this.Label_BankNote3_capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_BankNote3_capacity.Location = new System.Drawing.Point(3, 61);
            this.Label_BankNote3_capacity.Margin = new System.Windows.Forms.Padding(3);
            this.Label_BankNote3_capacity.Name = "Label_BankNote3_capacity";
            this.Label_BankNote3_capacity.Size = new System.Drawing.Size(68, 23);
            this.Label_BankNote3_capacity.TabIndex = 2;
            this.Label_BankNote3_capacity.Text = "00/100";
            this.Label_BankNote3_capacity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_BankNote4_capacity
            // 
            this.Label_BankNote4_capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_BankNote4_capacity.Location = new System.Drawing.Point(3, 90);
            this.Label_BankNote4_capacity.Margin = new System.Windows.Forms.Padding(3);
            this.Label_BankNote4_capacity.Name = "Label_BankNote4_capacity";
            this.Label_BankNote4_capacity.Size = new System.Drawing.Size(68, 23);
            this.Label_BankNote4_capacity.TabIndex = 3;
            this.Label_BankNote4_capacity.Text = "00/100";
            this.Label_BankNote4_capacity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_BankNote5_capacity
            // 
            this.Label_BankNote5_capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_BankNote5_capacity.Location = new System.Drawing.Point(3, 119);
            this.Label_BankNote5_capacity.Margin = new System.Windows.Forms.Padding(3);
            this.Label_BankNote5_capacity.Name = "Label_BankNote5_capacity";
            this.Label_BankNote5_capacity.Size = new System.Drawing.Size(68, 23);
            this.Label_BankNote5_capacity.TabIndex = 4;
            this.Label_BankNote5_capacity.Text = "00/100";
            this.Label_BankNote5_capacity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_BankNote6_capacity
            // 
            this.Label_BankNote6_capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_BankNote6_capacity.Location = new System.Drawing.Point(3, 148);
            this.Label_BankNote6_capacity.Margin = new System.Windows.Forms.Padding(3);
            this.Label_BankNote6_capacity.Name = "Label_BankNote6_capacity";
            this.Label_BankNote6_capacity.Size = new System.Drawing.Size(68, 23);
            this.Label_BankNote6_capacity.TabIndex = 5;
            this.Label_BankNote6_capacity.Text = "00/100";
            this.Label_BankNote6_capacity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel_Banknotes
            // 
            this.flowLayoutPanel_Banknotes.AutoSize = true;
            this.flowLayoutPanel_Banknotes.Controls.Add(this.button_Banknote1);
            this.flowLayoutPanel_Banknotes.Controls.Add(this.button_Banknote2);
            this.flowLayoutPanel_Banknotes.Controls.Add(this.button_Banknote3);
            this.flowLayoutPanel_Banknotes.Controls.Add(this.button_Banknote4);
            this.flowLayoutPanel_Banknotes.Controls.Add(this.button_Banknote5);
            this.flowLayoutPanel_Banknotes.Controls.Add(this.button_Banknote6);
            this.flowLayoutPanel_Banknotes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Banknotes.Location = new System.Drawing.Point(27, 73);
            this.flowLayoutPanel_Banknotes.Name = "flowLayoutPanel_Banknotes";
            this.flowLayoutPanel_Banknotes.Size = new System.Drawing.Size(82, 174);
            this.flowLayoutPanel_Banknotes.TabIndex = 2;
            // 
            // button_Banknote1
            // 
            this.button_Banknote1.Location = new System.Drawing.Point(3, 3);
            this.button_Banknote1.Name = "button_Banknote1";
            this.button_Banknote1.Size = new System.Drawing.Size(75, 23);
            this.button_Banknote1.TabIndex = 0;
            this.button_Banknote1.Text = "button1";
            this.button_Banknote1.UseVisualStyleBackColor = true;
            this.button_Banknote1.Click += new System.EventHandler(this.Button_Banknote1_Click);
            // 
            // button_Banknote2
            // 
            this.button_Banknote2.Location = new System.Drawing.Point(3, 32);
            this.button_Banknote2.Name = "button_Banknote2";
            this.button_Banknote2.Size = new System.Drawing.Size(75, 23);
            this.button_Banknote2.TabIndex = 3;
            this.button_Banknote2.Text = "button2";
            this.button_Banknote2.UseVisualStyleBackColor = true;
            this.button_Banknote2.Click += new System.EventHandler(this.Button_Banknote2_Click);
            // 
            // button_Banknote3
            // 
            this.button_Banknote3.Location = new System.Drawing.Point(3, 61);
            this.button_Banknote3.Name = "button_Banknote3";
            this.button_Banknote3.Size = new System.Drawing.Size(75, 23);
            this.button_Banknote3.TabIndex = 4;
            this.button_Banknote3.Text = "button3";
            this.button_Banknote3.UseVisualStyleBackColor = true;
            this.button_Banknote3.Click += new System.EventHandler(this.Button_Banknote3_Click);
            // 
            // button_Banknote4
            // 
            this.button_Banknote4.Location = new System.Drawing.Point(3, 90);
            this.button_Banknote4.Name = "button_Banknote4";
            this.button_Banknote4.Size = new System.Drawing.Size(75, 23);
            this.button_Banknote4.TabIndex = 5;
            this.button_Banknote4.Text = "button4";
            this.button_Banknote4.UseVisualStyleBackColor = true;
            this.button_Banknote4.Click += new System.EventHandler(this.Button_Banknote4_Click);
            // 
            // button_Banknote5
            // 
            this.button_Banknote5.Location = new System.Drawing.Point(3, 119);
            this.button_Banknote5.Name = "button_Banknote5";
            this.button_Banknote5.Size = new System.Drawing.Size(75, 23);
            this.button_Banknote5.TabIndex = 6;
            this.button_Banknote5.Text = "button5";
            this.button_Banknote5.UseVisualStyleBackColor = true;
            this.button_Banknote5.Click += new System.EventHandler(this.Button_Banknote5_Click);
            // 
            // button_Banknote6
            // 
            this.button_Banknote6.Location = new System.Drawing.Point(3, 148);
            this.button_Banknote6.Name = "button_Banknote6";
            this.button_Banknote6.Size = new System.Drawing.Size(75, 23);
            this.button_Banknote6.TabIndex = 7;
            this.button_Banknote6.Text = "button6";
            this.button_Banknote6.UseVisualStyleBackColor = true;
            this.button_Banknote6.Click += new System.EventHandler(this.Button_Banknote6_Click);
            // 
            // label_Balance
            // 
            this.label_Balance.AutoSize = true;
            this.label_Balance.Location = new System.Drawing.Point(65, 21);
            this.label_Balance.Name = "label_Balance";
            this.label_Balance.Size = new System.Drawing.Size(44, 13);
            this.label_Balance.TabIndex = 1;
            this.label_Balance.Text = "Баланс";
            // 
            // textBox_Balance
            // 
            this.textBox_Balance.Enabled = false;
            this.textBox_Balance.Location = new System.Drawing.Point(34, 37);
            this.textBox_Balance.Name = "textBox_Balance";
            this.textBox_Balance.Size = new System.Drawing.Size(111, 20);
            this.textBox_Balance.TabIndex = 0;
            // 
            // numericUpDown_WithDrawSum
            // 
            this.numericUpDown_WithDrawSum.Location = new System.Drawing.Point(25, 287);
            this.numericUpDown_WithDrawSum.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_WithDrawSum.Name = "numericUpDown_WithDrawSum";
            this.numericUpDown_WithDrawSum.Size = new System.Drawing.Size(84, 20);
            this.numericUpDown_WithDrawSum.TabIndex = 7;
            // 
            // ATM_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 420);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ATM_Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Банкомат";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel_BanknotesCapacity.ResumeLayout(false);
            this.flowLayoutPanel_Banknotes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_WithDrawSum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Balance;
        private System.Windows.Forms.TextBox textBox_Balance;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Banknotes;
        private System.Windows.Forms.Button button_Banknote1;
        private System.Windows.Forms.Button button_Banknote2;
        private System.Windows.Forms.Button button_Banknote3;
        private System.Windows.Forms.Button button_Banknote4;
        private System.Windows.Forms.Button button_Banknote5;
        private System.Windows.Forms.Button button_Banknote6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_BanknotesCapacity;
        private System.Windows.Forms.Label Label_BankNote1_capacity;
        private System.Windows.Forms.Label Label_BankNote2_capacity;
        private System.Windows.Forms.Label Label_BankNote3_capacity;
        private System.Windows.Forms.Label Label_BankNote4_capacity;
        private System.Windows.Forms.Label Label_BankNote5_capacity;
        private System.Windows.Forms.Label Label_BankNote6_capacity;
        private System.Windows.Forms.Button button_WithDraw;
        private System.Windows.Forms.ComboBox comboBox_WithDrawBankNotes;
        private System.Windows.Forms.Label label_WithDraw;
        private System.Windows.Forms.NumericUpDown numericUpDown_WithDrawSum;
    }
}

