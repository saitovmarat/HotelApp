
namespace Task_18._02._2023
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.paymentBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(266, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Карточка гостя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userNameLabel
            // 
            this.userNameLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel.Location = new System.Drawing.Point(220, 115);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(325, 58);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(220, 204);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(325, 58);
            this.dateOfBirthLabel.TabIndex = 2;
            this.dateOfBirthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paymentBox
            // 
            this.paymentBox.FormattingEnabled = true;
            this.paymentBox.Location = new System.Drawing.Point(220, 282);
            this.paymentBox.Name = "paymentBox";
            this.paymentBox.Size = new System.Drawing.Size(325, 24);
            this.paymentBox.TabIndex = 3;
            this.paymentBox.Text = "Оплата";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(220, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.minusClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(317, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.plusClick);
            // 
            // numberBox
            // 
            this.numberBox.Enabled = false;
            this.numberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberBox.Location = new System.Drawing.Point(261, 321);
            this.numberBox.Multiline = true;
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(50, 35);
            this.numberBox.TabIndex = 6;
            this.numberBox.Text = "0";
            this.numberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(377, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество дней";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(220, 375);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(325, 24);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Путешествую с животными";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.paymentBox);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.ComboBox paymentBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}