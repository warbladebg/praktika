namespace SchoolBook.Forms
{
    partial class AdministrationForm
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
            groupBoxName = new GroupBox();
            tableLayoutAdministration = new TableLayoutPanel();
            labelName = new Label();
            textBoxName = new TextBox();
            labelSurname = new Label();
            textBoxSurname = new TextBox();
            textBoxLastName = new TextBox();
            textBoxEGN = new TextBox();
            textBoxPhoneNumber = new TextBox();
            labelLastName = new Label();
            labelGender = new Label();
            comboBoxGender = new ComboBox();
            labelEGN = new Label();
            labelPhoneNumber = new Label();
            labelDateOfBirth = new Label();
            dateTimePicker = new DateTimePicker();
            labelPlaceOfBirth = new Label();
            comboBoxPlaceOfBirth = new ComboBox();
            buttonEdit = new Button();
            buttonSave = new Button();
            groupBoxName.SuspendLayout();
            tableLayoutAdministration.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxName
            // 
            groupBoxName.Controls.Add(tableLayoutAdministration);
            groupBoxName.Dock = DockStyle.Fill;
            groupBoxName.Location = new Point(0, 0);
            groupBoxName.Name = "groupBoxName";
            groupBoxName.Size = new Size(800, 450);
            groupBoxName.TabIndex = 0;
            groupBoxName.TabStop = false;
            groupBoxName.Text = "Основни данни";
            // 
            // tableLayoutAdministration
            // 
            tableLayoutAdministration.ColumnCount = 2;
            tableLayoutAdministration.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutAdministration.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutAdministration.Controls.Add(labelName, 0, 0);
            tableLayoutAdministration.Controls.Add(textBoxName, 1, 0);
            tableLayoutAdministration.Controls.Add(labelSurname, 0, 1);
            tableLayoutAdministration.Controls.Add(textBoxSurname, 1, 1);
            tableLayoutAdministration.Controls.Add(textBoxLastName, 1, 2);
            tableLayoutAdministration.Controls.Add(textBoxEGN, 1, 4);
            tableLayoutAdministration.Controls.Add(textBoxPhoneNumber, 1, 5);
            tableLayoutAdministration.Controls.Add(labelLastName, 0, 2);
            tableLayoutAdministration.Controls.Add(labelGender, 0, 3);
            tableLayoutAdministration.Controls.Add(comboBoxGender, 1, 3);
            tableLayoutAdministration.Controls.Add(labelEGN, 0, 4);
            tableLayoutAdministration.Controls.Add(labelPhoneNumber, 0, 5);
            tableLayoutAdministration.Controls.Add(labelDateOfBirth, 0, 6);
            tableLayoutAdministration.Controls.Add(dateTimePicker, 1, 6);
            tableLayoutAdministration.Controls.Add(labelPlaceOfBirth, 0, 7);
            tableLayoutAdministration.Controls.Add(comboBoxPlaceOfBirth, 1, 7);
            tableLayoutAdministration.Controls.Add(buttonEdit, 0, 8);
            tableLayoutAdministration.Controls.Add(buttonSave, 1, 8);
            tableLayoutAdministration.Dock = DockStyle.Fill;
            tableLayoutAdministration.Location = new Point(3, 27);
            tableLayoutAdministration.Name = "tableLayoutAdministration";
            tableLayoutAdministration.RowCount = 9;
            tableLayoutAdministration.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tableLayoutAdministration.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tableLayoutAdministration.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tableLayoutAdministration.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tableLayoutAdministration.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tableLayoutAdministration.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tableLayoutAdministration.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tableLayoutAdministration.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tableLayoutAdministration.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutAdministration.Size = new Size(794, 420);
            tableLayoutAdministration.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Dock = DockStyle.Right;
            labelName.Location = new Point(347, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(47, 46);
            labelName.TabIndex = 0;
            labelName.Text = "Име";
            // 
            // textBoxName
            // 
            textBoxName.Dock = DockStyle.Left;
            textBoxName.Location = new Point(400, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(391, 31);
            textBoxName.TabIndex = 1;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Dock = DockStyle.Right;
            labelSurname.Location = new Point(309, 46);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(85, 46);
            labelSurname.TabIndex = 2;
            labelSurname.Text = "Презиме";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Dock = DockStyle.Left;
            textBoxSurname.Location = new Point(400, 49);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.ReadOnly = true;
            textBoxSurname.Size = new Size(391, 31);
            textBoxSurname.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Dock = DockStyle.Left;
            textBoxLastName.Location = new Point(400, 95);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.ReadOnly = true;
            textBoxLastName.Size = new Size(391, 31);
            textBoxLastName.TabIndex = 4;
            // 
            // textBoxEGN
            // 
            textBoxEGN.Dock = DockStyle.Left;
            textBoxEGN.Location = new Point(400, 187);
            textBoxEGN.Name = "textBoxEGN";
            textBoxEGN.ReadOnly = true;
            textBoxEGN.Size = new Size(391, 31);
            textBoxEGN.TabIndex = 6;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Dock = DockStyle.Left;
            textBoxPhoneNumber.Location = new Point(400, 233);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.ReadOnly = true;
            textBoxPhoneNumber.Size = new Size(391, 31);
            textBoxPhoneNumber.TabIndex = 7;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Dock = DockStyle.Right;
            labelLastName.Location = new Point(309, 92);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(85, 46);
            labelLastName.TabIndex = 10;
            labelLastName.Text = "Фамилия";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Dock = DockStyle.Right;
            labelGender.Location = new Point(349, 138);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(45, 46);
            labelGender.TabIndex = 11;
            labelGender.Text = "Пол";
            // 
            // comboBoxGender
            // 
            comboBoxGender.Dock = DockStyle.Left;
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Мъж", "Жена" });
            comboBoxGender.Location = new Point(400, 141);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(391, 33);
            comboBoxGender.TabIndex = 12;
            // 
            // labelEGN
            // 
            labelEGN.AutoSize = true;
            labelEGN.Dock = DockStyle.Right;
            labelEGN.Location = new Point(352, 184);
            labelEGN.Name = "labelEGN";
            labelEGN.Size = new Size(42, 46);
            labelEGN.TabIndex = 13;
            labelEGN.Text = "ЕГН";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Dock = DockStyle.Right;
            labelPhoneNumber.Location = new Point(313, 230);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(81, 46);
            labelPhoneNumber.TabIndex = 14;
            labelPhoneNumber.Text = "Телефон";
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Dock = DockStyle.Right;
            labelDateOfBirth.Location = new Point(245, 276);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(149, 46);
            labelDateOfBirth.TabIndex = 15;
            labelDateOfBirth.Text = "Дата на раждане";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Dock = DockStyle.Left;
            dateTimePicker.Location = new Point(400, 279);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(391, 31);
            dateTimePicker.TabIndex = 16;
            // 
            // labelPlaceOfBirth
            // 
            labelPlaceOfBirth.AutoSize = true;
            labelPlaceOfBirth.Dock = DockStyle.Right;
            labelPlaceOfBirth.Location = new Point(231, 322);
            labelPlaceOfBirth.Name = "labelPlaceOfBirth";
            labelPlaceOfBirth.Size = new Size(163, 46);
            labelPlaceOfBirth.TabIndex = 17;
            labelPlaceOfBirth.Text = "Място на раждане";
            // 
            // comboBoxPlaceOfBirth
            // 
            comboBoxPlaceOfBirth.Dock = DockStyle.Left;
            comboBoxPlaceOfBirth.FormattingEnabled = true;
            comboBoxPlaceOfBirth.Items.AddRange(new object[] { "Благо̀евград", "Бурга̀с", "Ва̀рна", "Велѝко Тъ̀рново", "Вѝдин", "Вра̀ца", "Га̀брово", "До̀брич", "Къ̀рджали", "Кюстендѝл", "Ло̀веч", "Монта̀на", "Па̀зарджик", "Пѐрник", "Плѐвен", "Пло̀вдив", "Ра̀зград", "Ру̀се", "Силѝстра", "Слѝвен", "Смо̀лян", "Сòфия", "Ста̀ра Заго̀ра", "Търго̀вище", "Ха̀сково", "Шу̀мен", "Я̀мбол" });
            comboBoxPlaceOfBirth.Location = new Point(400, 325);
            comboBoxPlaceOfBirth.Name = "comboBoxPlaceOfBirth";
            comboBoxPlaceOfBirth.Size = new Size(391, 33);
            comboBoxPlaceOfBirth.TabIndex = 18;
            // 
            // buttonEdit
            // 
            buttonEdit.Dock = DockStyle.Fill;
            buttonEdit.Location = new Point(3, 371);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(391, 46);
            buttonEdit.TabIndex = 19;
            buttonEdit.Text = "Редактирай...";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonSave
            // 
            buttonSave.Dock = DockStyle.Fill;
            buttonSave.Location = new Point(400, 371);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(391, 46);
            buttonSave.TabIndex = 20;
            buttonSave.Text = "Запази";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // AdministrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdministrationForm";
            Text = "AdministrationForm";
            groupBoxName.ResumeLayout(false);
            tableLayoutAdministration.ResumeLayout(false);
            tableLayoutAdministration.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxName;
        private TableLayoutPanel tableLayoutAdministration;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelSurname;
        private TextBox textBoxSurname;
        private TextBox textBoxLastName;
        private TextBox textBoxEGN;
        private TextBox textBoxPhoneNumber;
        private Label labelLastName;
        private Label labelGender;
        private ComboBox comboBoxGender;
        private Label labelEGN;
        private Label labelPhoneNumber;
        private Label labelDateOfBirth;
        private DateTimePicker dateTimePicker;
        private Label labelPlaceOfBirth;
        private ComboBox comboBoxPlaceOfBirth;
        private Button buttonEdit;
        private Button buttonSave;
    }
}