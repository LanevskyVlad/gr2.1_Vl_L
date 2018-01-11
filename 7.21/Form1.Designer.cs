namespace _7._18
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ArrInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeArrBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RemoveOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ArrInput
            // 
            this.ArrInput.Location = new System.Drawing.Point(15, 26);
            this.ArrInput.Name = "ArrInput";
            this.ArrInput.Size = new System.Drawing.Size(256, 20);
            this.ArrInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "введите массив";
            // 
            // ChangeArrBtn
            // 
            this.ChangeArrBtn.Location = new System.Drawing.Point(15, 52);
            this.ChangeArrBtn.Name = "ChangeArrBtn";
            this.ChangeArrBtn.Size = new System.Drawing.Size(117, 23);
            this.ChangeArrBtn.TabIndex = 5;
            this.ChangeArrBtn.Text = "изменить массив";
            this.ChangeArrBtn.UseVisualStyleBackColor = true;
            this.ChangeArrBtn.Click += new System.EventHandler(this.ChangeArrBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "удаление элементов";
            // 
            // RemoveOutput
            // 
            this.RemoveOutput.AutoSize = true;
            this.RemoveOutput.Location = new System.Drawing.Point(18, 99);
            this.RemoveOutput.Name = "RemoveOutput";
            this.RemoveOutput.Size = new System.Drawing.Size(10, 13);
            this.RemoveOutput.TabIndex = 7;
            this.RemoveOutput.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "добавление элементов";
            // 
            // AddOutput
            // 
            this.AddOutput.AutoSize = true;
            this.AddOutput.Location = new System.Drawing.Point(15, 133);
            this.AddOutput.Name = "AddOutput";
            this.AddOutput.Size = new System.Drawing.Size(10, 13);
            this.AddOutput.TabIndex = 9;
            this.AddOutput.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.AddOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RemoveOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChangeArrBtn);
            this.Controls.Add(this.ArrInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "7.18";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ArrInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangeArrBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RemoveOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AddOutput;
    }
}

