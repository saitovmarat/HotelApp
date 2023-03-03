
namespace Task_18._02._2023
{
    partial class HotelWebsite
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
            this.reservedButton = new System.Windows.Forms.RadioButton();
            this.freeButton = new System.Windows.Forms.RadioButton();
            this.occupiedButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guestsBox = new System.Windows.Forms.ListBox();
            this.guestInfoBox = new System.Windows.Forms.Label();
            this.dischargedButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.popUpWindowButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkInDateLabel = new System.Windows.Forms.Label();
            this.checkOutDateLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // reservedButton
            // 
            this.reservedButton.AutoSize = true;
            this.reservedButton.Location = new System.Drawing.Point(12, 133);
            this.reservedButton.Name = "reservedButton";
            this.reservedButton.Size = new System.Drawing.Size(147, 21);
            this.reservedButton.TabIndex = 0;
            this.reservedButton.Text = "Зарезервировано";
            this.reservedButton.UseVisualStyleBackColor = true;
            this.reservedButton.Click += new System.EventHandler(this.ReservedClick);
            // 
            // freeButton
            // 
            this.freeButton.AutoSize = true;
            this.freeButton.Location = new System.Drawing.Point(12, 160);
            this.freeButton.Name = "freeButton";
            this.freeButton.Size = new System.Drawing.Size(103, 21);
            this.freeButton.TabIndex = 1;
            this.freeButton.Text = "Свободные";
            this.freeButton.UseVisualStyleBackColor = true;
            this.freeButton.Click += new System.EventHandler(this.FreeClick);
            // 
            // occupiedButton
            // 
            this.occupiedButton.AutoSize = true;
            this.occupiedButton.Location = new System.Drawing.Point(12, 187);
            this.occupiedButton.Name = "occupiedButton";
            this.occupiedButton.Size = new System.Drawing.Size(79, 21);
            this.occupiedButton.TabIndex = 2;
            this.occupiedButton.Text = "Заняты";
            this.occupiedButton.UseVisualStyleBackColor = true;
            this.occupiedButton.Click += new System.EventHandler(this.OccupiedClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Статусы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Список Гостей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(787, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер №";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Location = new System.Drawing.Point(196, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 444);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(642, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 444);
            this.panel2.TabIndex = 9;
            // 
            // guestsBox
            // 
            this.guestsBox.FormattingEnabled = true;
            this.guestsBox.ItemHeight = 16;
            this.guestsBox.Location = new System.Drawing.Point(271, 117);
            this.guestsBox.Name = "guestsBox";
            this.guestsBox.Size = new System.Drawing.Size(294, 324);
            this.guestsBox.TabIndex = 10;
            this.guestsBox.DoubleClick += new System.EventHandler(this.GuestBoxDoubleClick);
            // 
            // guestInfoBox
            // 
            this.guestInfoBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.guestInfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestInfoBox.Location = new System.Drawing.Point(682, 246);
            this.guestInfoBox.Name = "guestInfoBox";
            this.guestInfoBox.Size = new System.Drawing.Size(274, 42);
            this.guestInfoBox.TabIndex = 11;
            this.guestInfoBox.Text = "ФИО";
            this.guestInfoBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dischargedButton
            // 
            this.dischargedButton.AutoSize = true;
            this.dischargedButton.Location = new System.Drawing.Point(12, 215);
            this.dischargedButton.Name = "dischargedButton";
            this.dischargedButton.Size = new System.Drawing.Size(128, 21);
            this.dischargedButton.TabIndex = 12;
            this.dischargedButton.TabStop = true;
            this.dischargedButton.Text = "Выписываются";
            this.dischargedButton.UseVisualStyleBackColor = true;
            this.dischargedButton.CheckedChanged += new System.EventHandler(this.DischargeClick);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(57, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 41);
            this.label5.TabIndex = 13;
            this.label5.Text = "           ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBox.Location = new System.Drawing.Point(225, 27);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(517, 40);
            this.searchBox.TabIndex = 14;
            this.searchBox.Text = "Поиск...";
            this.searchBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(679, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Статус";
            // 
            // popUpWindowButton
            // 
            this.popUpWindowButton.Enabled = false;
            this.popUpWindowButton.Location = new System.Drawing.Point(790, 459);
            this.popUpWindowButton.Name = "popUpWindowButton";
            this.popUpWindowButton.Size = new System.Drawing.Size(166, 23);
            this.popUpWindowButton.TabIndex = 18;
            this.popUpWindowButton.Text = "Просмотр карточки";
            this.popUpWindowButton.UseVisualStyleBackColor = true;
            this.popUpWindowButton.Click += new System.EventHandler(this.PopUpWindowButtonCLick);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(945, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 40);
            this.label6.TabIndex = 19;
            this.label6.Text = "X";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.ExitClick);
            this.label6.MouseEnter += new System.EventHandler(this.ExitMouseEnter);
            this.label6.MouseLeave += new System.EventHandler(this.ExitMouseLeave);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(808, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(131, 76);
            this.panel4.TabIndex = 20;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            // 
            // checkInDateLabel
            // 
            this.checkInDateLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.checkInDateLabel.Location = new System.Drawing.Point(682, 334);
            this.checkInDateLabel.Name = "checkInDateLabel";
            this.checkInDateLabel.Size = new System.Drawing.Size(274, 47);
            this.checkInDateLabel.TabIndex = 22;
            this.checkInDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkOutDateLabel
            // 
            this.checkOutDateLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.checkOutDateLabel.Location = new System.Drawing.Point(682, 409);
            this.checkOutDateLabel.Name = "checkOutDateLabel";
            this.checkOutDateLabel.Size = new System.Drawing.Size(272, 47);
            this.checkOutDateLabel.TabIndex = 23;
            this.checkOutDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(683, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Дата заезда";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(683, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Дата выезда";
            // 
            // StatusBox
            // 
            this.StatusBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.StatusBox.Location = new System.Drawing.Point(768, 216);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(186, 24);
            this.StatusBox.TabIndex = 26;
            this.StatusBox.Text = "Статус";
            // 
            // HotelWebsite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(988, 506);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkOutDateLabel);
            this.Controls.Add(this.checkInDateLabel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.popUpWindowButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dischargedButton);
            this.Controls.Add(this.guestInfoBox);
            this.Controls.Add(this.guestsBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.occupiedButton);
            this.Controls.Add(this.freeButton);
            this.Controls.Add(this.reservedButton);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HotelWebsite";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton reservedButton;
        private System.Windows.Forms.RadioButton freeButton;
        private System.Windows.Forms.RadioButton occupiedButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox guestsBox;
        private System.Windows.Forms.Label guestInfoBox;
        private System.Windows.Forms.RadioButton dischargedButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button popUpWindowButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label checkInDateLabel;
        private System.Windows.Forms.Label checkOutDateLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox StatusBox;
    }
}

