namespace libraryGUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.numericUpDownBookCount = new System.Windows.Forms.NumericUpDown();
            this.labelBookCount = new System.Windows.Forms.Label();
            this.numericUpDownPageCount = new System.Windows.Forms.NumericUpDown();
            this.buttonBookNewAuthor = new System.Windows.Forms.Button();
            this.comboBoxBookAuthors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.buttonUpdateBook = new System.Windows.Forms.Button();
            this.buttonSelectBook = new System.Windows.Forms.Button();
            this.buttonInsertBook = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.labelPageCount = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tabPageReader = new System.Windows.Forms.TabPage();
            this.buttonAddReader = new System.Windows.Forms.Button();
            this.comboBoxReaderName = new System.Windows.Forms.ComboBox();
            this.buttonDeleteReader = new System.Windows.Forms.Button();
            this.buttonUpdateReader = new System.Windows.Forms.Button();
            this.buttonSelectReader = new System.Windows.Forms.Button();
            this.buttonInsertReader = new System.Windows.Forms.Button();
            this.textBoxOrganization = new System.Windows.Forms.TextBox();
            this.labelOrganization = new System.Windows.Forms.Label();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.dataGridViewReader = new System.Windows.Forms.DataGridView();
            this.labelName = new System.Windows.Forms.Label();
            this.tabPageSubscription = new System.Windows.Forms.TabPage();
            this.checkBoxNotReturn = new System.Windows.Forms.CheckBox();
            this.checkBoxIsReturn = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelIsReturn = new System.Windows.Forms.Label();
            this.labelBringDate = new System.Windows.Forms.Label();
            this.labelTakingDate = new System.Windows.Forms.Label();
            this.dataGridViewSubscription = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPageBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPageCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            this.tabPageReader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReader)).BeginInit();
            this.tabPageSubscription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubscription)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBook);
            this.tabControl1.Controls.Add(this.tabPageReader);
            this.tabControl1.Controls.Add(this.tabPageSubscription);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageBook
            // 
            this.tabPageBook.Controls.Add(this.numericUpDownBookCount);
            this.tabPageBook.Controls.Add(this.labelBookCount);
            this.tabPageBook.Controls.Add(this.numericUpDownPageCount);
            this.tabPageBook.Controls.Add(this.buttonBookNewAuthor);
            this.tabPageBook.Controls.Add(this.comboBoxBookAuthors);
            this.tabPageBook.Controls.Add(this.label1);
            this.tabPageBook.Controls.Add(this.buttonDeleteBook);
            this.tabPageBook.Controls.Add(this.buttonUpdateBook);
            this.tabPageBook.Controls.Add(this.buttonSelectBook);
            this.tabPageBook.Controls.Add(this.buttonInsertBook);
            this.tabPageBook.Controls.Add(this.labelDate);
            this.tabPageBook.Controls.Add(this.dataGridViewBook);
            this.tabPageBook.Controls.Add(this.labelPageCount);
            this.tabPageBook.Controls.Add(this.dateTimePickerDate);
            this.tabPageBook.Controls.Add(this.textBoxTitle);
            this.tabPageBook.Controls.Add(this.labelTitle);
            this.tabPageBook.Location = new System.Drawing.Point(4, 22);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBook.Size = new System.Drawing.Size(792, 424);
            this.tabPageBook.TabIndex = 0;
            this.tabPageBook.Text = "Книги";
            this.tabPageBook.UseVisualStyleBackColor = true;
            // 
            // numericUpDownBookCount
            // 
            this.numericUpDownBookCount.Location = new System.Drawing.Point(40, 133);
            this.numericUpDownBookCount.Name = "numericUpDownBookCount";
            this.numericUpDownBookCount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBookCount.TabIndex = 19;
            // 
            // labelBookCount
            // 
            this.labelBookCount.AutoSize = true;
            this.labelBookCount.Location = new System.Drawing.Point(71, 117);
            this.labelBookCount.Name = "labelBookCount";
            this.labelBookCount.Size = new System.Drawing.Size(67, 13);
            this.labelBookCount.TabIndex = 18;
            this.labelBookCount.Text = "Кол-во книг";
            // 
            // numericUpDownPageCount
            // 
            this.numericUpDownPageCount.Location = new System.Drawing.Point(40, 181);
            this.numericUpDownPageCount.Name = "numericUpDownPageCount";
            this.numericUpDownPageCount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPageCount.TabIndex = 17;
            // 
            // buttonBookNewAuthor
            // 
            this.buttonBookNewAuthor.Location = new System.Drawing.Point(137, 74);
            this.buttonBookNewAuthor.Name = "buttonBookNewAuthor";
            this.buttonBookNewAuthor.Size = new System.Drawing.Size(75, 23);
            this.buttonBookNewAuthor.TabIndex = 16;
            this.buttonBookNewAuthor.Text = "+";
            this.buttonBookNewAuthor.UseVisualStyleBackColor = true;
            this.buttonBookNewAuthor.Click += new System.EventHandler(this.buttonBookNewAuthor_Click);
            // 
            // comboBoxBookAuthors
            // 
            this.comboBoxBookAuthors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBookAuthors.FormattingEnabled = true;
            this.comboBoxBookAuthors.Location = new System.Drawing.Point(9, 77);
            this.comboBoxBookAuthors.Name = "comboBoxBookAuthors";
            this.comboBoxBookAuthors.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBookAuthors.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Автор";
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Location = new System.Drawing.Point(63, 350);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteBook.TabIndex = 13;
            this.buttonDeleteBook.Text = "delete";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateBook
            // 
            this.buttonUpdateBook.Location = new System.Drawing.Point(63, 321);
            this.buttonUpdateBook.Name = "buttonUpdateBook";
            this.buttonUpdateBook.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateBook.TabIndex = 12;
            this.buttonUpdateBook.Text = "update";
            this.buttonUpdateBook.UseVisualStyleBackColor = true;
            // 
            // buttonSelectBook
            // 
            this.buttonSelectBook.Location = new System.Drawing.Point(63, 292);
            this.buttonSelectBook.Name = "buttonSelectBook";
            this.buttonSelectBook.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectBook.TabIndex = 11;
            this.buttonSelectBook.Text = "select";
            this.buttonSelectBook.UseVisualStyleBackColor = true;
            this.buttonSelectBook.Click += new System.EventHandler(this.buttonSelectBook_Click);
            // 
            // buttonInsertBook
            // 
            this.buttonInsertBook.Location = new System.Drawing.Point(63, 264);
            this.buttonInsertBook.Name = "buttonInsertBook";
            this.buttonInsertBook.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertBook.TabIndex = 10;
            this.buttonInsertBook.Text = "insert";
            this.buttonInsertBook.UseVisualStyleBackColor = true;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(86, 214);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 13);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Дата";
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewBook.Location = new System.Drawing.Point(219, 3);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.Size = new System.Drawing.Size(570, 418);
            this.dataGridViewBook.TabIndex = 0;
            // 
            // labelPageCount
            // 
            this.labelPageCount.AutoSize = true;
            this.labelPageCount.Location = new System.Drawing.Point(71, 165);
            this.labelPageCount.Name = "labelPageCount";
            this.labelPageCount.Size = new System.Drawing.Size(85, 13);
            this.labelPageCount.TabIndex = 6;
            this.labelPageCount.Text = "Кол-во страниц";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(19, 230);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(194, 20);
            this.dateTimePickerDate.TabIndex = 5;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(6, 30);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(194, 20);
            this.textBoxTitle.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(16, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(57, 13);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Название";
            // 
            // tabPageReader
            // 
            this.tabPageReader.Controls.Add(this.buttonAddReader);
            this.tabPageReader.Controls.Add(this.comboBoxReaderName);
            this.tabPageReader.Controls.Add(this.buttonDeleteReader);
            this.tabPageReader.Controls.Add(this.buttonUpdateReader);
            this.tabPageReader.Controls.Add(this.buttonSelectReader);
            this.tabPageReader.Controls.Add(this.buttonInsertReader);
            this.tabPageReader.Controls.Add(this.textBoxOrganization);
            this.tabPageReader.Controls.Add(this.labelOrganization);
            this.tabPageReader.Controls.Add(this.dateTimePickerBirthday);
            this.tabPageReader.Controls.Add(this.labelBirthday);
            this.tabPageReader.Controls.Add(this.dataGridViewReader);
            this.tabPageReader.Controls.Add(this.labelName);
            this.tabPageReader.Location = new System.Drawing.Point(4, 22);
            this.tabPageReader.Name = "tabPageReader";
            this.tabPageReader.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReader.Size = new System.Drawing.Size(792, 424);
            this.tabPageReader.TabIndex = 1;
            this.tabPageReader.Text = "Посетители";
            this.tabPageReader.UseVisualStyleBackColor = true;
            // 
            // buttonAddReader
            // 
            this.buttonAddReader.Location = new System.Drawing.Point(237, 23);
            this.buttonAddReader.Name = "buttonAddReader";
            this.buttonAddReader.Size = new System.Drawing.Size(75, 23);
            this.buttonAddReader.TabIndex = 18;
            this.buttonAddReader.Text = "+";
            this.buttonAddReader.UseVisualStyleBackColor = true;
            this.buttonAddReader.Click += new System.EventHandler(this.buttonAddReader_Click);
            // 
            // comboBoxReaderName
            // 
            this.comboBoxReaderName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReaderName.FormattingEnabled = true;
            this.comboBoxReaderName.Location = new System.Drawing.Point(111, 23);
            this.comboBoxReaderName.Name = "comboBoxReaderName";
            this.comboBoxReaderName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxReaderName.TabIndex = 17;
            // 
            // buttonDeleteReader
            // 
            this.buttonDeleteReader.Location = new System.Drawing.Point(111, 238);
            this.buttonDeleteReader.Name = "buttonDeleteReader";
            this.buttonDeleteReader.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteReader.TabIndex = 16;
            this.buttonDeleteReader.Text = "delete";
            this.buttonDeleteReader.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateReader
            // 
            this.buttonUpdateReader.Location = new System.Drawing.Point(111, 209);
            this.buttonUpdateReader.Name = "buttonUpdateReader";
            this.buttonUpdateReader.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateReader.TabIndex = 15;
            this.buttonUpdateReader.Text = "update";
            this.buttonUpdateReader.UseVisualStyleBackColor = true;
            // 
            // buttonSelectReader
            // 
            this.buttonSelectReader.Location = new System.Drawing.Point(111, 180);
            this.buttonSelectReader.Name = "buttonSelectReader";
            this.buttonSelectReader.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectReader.TabIndex = 14;
            this.buttonSelectReader.Text = "select";
            this.buttonSelectReader.UseVisualStyleBackColor = true;
            this.buttonSelectReader.Click += new System.EventHandler(this.buttonSelectReader_Click);
            // 
            // buttonInsertReader
            // 
            this.buttonInsertReader.Location = new System.Drawing.Point(111, 151);
            this.buttonInsertReader.Name = "buttonInsertReader";
            this.buttonInsertReader.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertReader.TabIndex = 11;
            this.buttonInsertReader.Text = "insert";
            this.buttonInsertReader.UseVisualStyleBackColor = true;
            // 
            // textBoxOrganization
            // 
            this.textBoxOrganization.Location = new System.Drawing.Point(111, 99);
            this.textBoxOrganization.Name = "textBoxOrganization";
            this.textBoxOrganization.Size = new System.Drawing.Size(201, 20);
            this.textBoxOrganization.TabIndex = 5;
            // 
            // labelOrganization
            // 
            this.labelOrganization.AutoSize = true;
            this.labelOrganization.Location = new System.Drawing.Point(8, 102);
            this.labelOrganization.Name = "labelOrganization";
            this.labelOrganization.Size = new System.Drawing.Size(74, 13);
            this.labelOrganization.TabIndex = 4;
            this.labelOrganization.Text = "Организация";
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(111, 62);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(201, 20);
            this.dateTimePickerBirthday.TabIndex = 3;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(6, 62);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(87, 13);
            this.labelBirthday.TabIndex = 2;
            this.labelBirthday.Text = "День рождения";
            // 
            // dataGridViewReader
            // 
            this.dataGridViewReader.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewReader.Location = new System.Drawing.Point(340, 3);
            this.dataGridViewReader.Name = "dataGridViewReader";
            this.dataGridViewReader.Size = new System.Drawing.Size(449, 418);
            this.dataGridViewReader.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(31, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Имя";
            // 
            // tabPageSubscription
            // 
            this.tabPageSubscription.Controls.Add(this.comboBox2);
            this.tabPageSubscription.Controls.Add(this.comboBox1);
            this.tabPageSubscription.Controls.Add(this.label3);
            this.tabPageSubscription.Controls.Add(this.label2);
            this.tabPageSubscription.Controls.Add(this.checkBoxNotReturn);
            this.tabPageSubscription.Controls.Add(this.checkBoxIsReturn);
            this.tabPageSubscription.Controls.Add(this.dateTimePicker2);
            this.tabPageSubscription.Controls.Add(this.dateTimePicker1);
            this.tabPageSubscription.Controls.Add(this.labelIsReturn);
            this.tabPageSubscription.Controls.Add(this.labelBringDate);
            this.tabPageSubscription.Controls.Add(this.labelTakingDate);
            this.tabPageSubscription.Controls.Add(this.dataGridViewSubscription);
            this.tabPageSubscription.Location = new System.Drawing.Point(4, 22);
            this.tabPageSubscription.Name = "tabPageSubscription";
            this.tabPageSubscription.Size = new System.Drawing.Size(792, 424);
            this.tabPageSubscription.TabIndex = 2;
            this.tabPageSubscription.Text = "Абонементы";
            this.tabPageSubscription.UseVisualStyleBackColor = true;
            // 
            // checkBoxNotReturn
            // 
            this.checkBoxNotReturn.AutoSize = true;
            this.checkBoxNotReturn.Location = new System.Drawing.Point(136, 389);
            this.checkBoxNotReturn.Name = "checkBoxNotReturn";
            this.checkBoxNotReturn.Size = new System.Drawing.Size(45, 17);
            this.checkBoxNotReturn.TabIndex = 7;
            this.checkBoxNotReturn.Text = "Нет";
            this.checkBoxNotReturn.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsReturn
            // 
            this.checkBoxIsReturn.AutoSize = true;
            this.checkBoxIsReturn.Location = new System.Drawing.Point(50, 389);
            this.checkBoxIsReturn.Name = "checkBoxIsReturn";
            this.checkBoxIsReturn.Size = new System.Drawing.Size(41, 17);
            this.checkBoxIsReturn.TabIndex = 6;
            this.checkBoxIsReturn.Text = "Да";
            this.checkBoxIsReturn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(8, 332);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 293);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // labelIsReturn
            // 
            this.labelIsReturn.AutoSize = true;
            this.labelIsReturn.Location = new System.Drawing.Point(45, 360);
            this.labelIsReturn.Name = "labelIsReturn";
            this.labelIsReturn.Size = new System.Drawing.Size(95, 13);
            this.labelIsReturn.TabIndex = 3;
            this.labelIsReturn.Text = "Вернута ли книга";
            // 
            // labelBringDate
            // 
            this.labelBringDate.AutoSize = true;
            this.labelBringDate.Location = new System.Drawing.Point(45, 316);
            this.labelBringDate.Name = "labelBringDate";
            this.labelBringDate.Size = new System.Drawing.Size(90, 13);
            this.labelBringDate.TabIndex = 2;
            this.labelBringDate.Text = "Время возврата";
            // 
            // labelTakingDate
            // 
            this.labelTakingDate.AutoSize = true;
            this.labelTakingDate.Location = new System.Drawing.Point(45, 268);
            this.labelTakingDate.Name = "labelTakingDate";
            this.labelTakingDate.Size = new System.Drawing.Size(78, 13);
            this.labelTakingDate.TabIndex = 1;
            this.labelTakingDate.Text = "Время взятия";
            // 
            // dataGridViewSubscription
            // 
            this.dataGridViewSubscription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubscription.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewSubscription.Location = new System.Drawing.Point(254, 0);
            this.dataGridViewSubscription.Name = "dataGridViewSubscription";
            this.dataGridViewSubscription.Size = new System.Drawing.Size(538, 424);
            this.dataGridViewSubscription.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Посетитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Книга";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(24, 137);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageBook.ResumeLayout(false);
            this.tabPageBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPageCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            this.tabPageReader.ResumeLayout(false);
            this.tabPageReader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReader)).EndInit();
            this.tabPageSubscription.ResumeLayout(false);
            this.tabPageSubscription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubscription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBook;
        private System.Windows.Forms.TabPage tabPageReader;
        private System.Windows.Forms.TabPage tabPageSubscription;
        private System.Windows.Forms.DataGridView dataGridViewBook;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPageCount;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonInsertBook;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.Button buttonUpdateBook;
        private System.Windows.Forms.Button buttonSelectBook;
        private System.Windows.Forms.Button buttonAddReader;
        private System.Windows.Forms.ComboBox comboBoxReaderName;
        private System.Windows.Forms.Button buttonDeleteReader;
        private System.Windows.Forms.Button buttonUpdateReader;
        private System.Windows.Forms.Button buttonSelectReader;
        private System.Windows.Forms.Button buttonInsertReader;
        private System.Windows.Forms.TextBox textBoxOrganization;
        private System.Windows.Forms.Label labelOrganization;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.DataGridView dataGridViewReader;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelIsReturn;
        private System.Windows.Forms.Label labelBringDate;
        private System.Windows.Forms.Label labelTakingDate;
        private System.Windows.Forms.DataGridView dataGridViewSubscription;
        private System.Windows.Forms.CheckBox checkBoxNotReturn;
        private System.Windows.Forms.CheckBox checkBoxIsReturn;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonBookNewAuthor;
        private System.Windows.Forms.ComboBox comboBoxBookAuthors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownBookCount;
        private System.Windows.Forms.Label labelBookCount;
        private System.Windows.Forms.NumericUpDown numericUpDownPageCount;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

