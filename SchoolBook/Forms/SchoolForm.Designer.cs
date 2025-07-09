namespace SchoolBook.Forms
{
    partial class SchoolForm
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
            tableLayoutSchool = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tabControlSchool = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutSchoolData = new TableLayoutPanel();
            labelSchoolName = new Label();
            labelSchoolShortName = new Label();
            labelSchoolType = new Label();
            tabPage2 = new TabPage();
            tableLayoutSchool.SuspendLayout();
            tabControlSchool.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutSchoolData.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutSchool
            // 
            tableLayoutSchool.ColumnCount = 1;
            tableLayoutSchool.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutSchool.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutSchool.Controls.Add(tabControlSchool, 0, 0);
            tableLayoutSchool.Dock = DockStyle.Fill;
            tableLayoutSchool.Location = new Point(0, 0);
            tableLayoutSchool.Name = "tableLayoutSchool";
            tableLayoutSchool.RowCount = 2;
            tableLayoutSchool.RowStyles.Add(new RowStyle(SizeType.Percent, 88F));
            tableLayoutSchool.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutSchool.Size = new Size(800, 450);
            tableLayoutSchool.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 399);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(794, 48);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControlSchool
            // 
            tabControlSchool.Controls.Add(tabPage1);
            tabControlSchool.Controls.Add(tabPage2);
            tabControlSchool.Dock = DockStyle.Fill;
            tabControlSchool.Location = new Point(3, 3);
            tabControlSchool.Name = "tabControlSchool";
            tabControlSchool.SelectedIndex = 0;
            tabControlSchool.Size = new Size(794, 390);
            tabControlSchool.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutSchoolData);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(786, 352);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Основни данни";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutSchoolData
            // 
            tableLayoutSchoolData.ColumnCount = 2;
            tableLayoutSchoolData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutSchoolData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutSchoolData.Controls.Add(labelSchoolName, 0, 0);
            tableLayoutSchoolData.Controls.Add(labelSchoolShortName, 0, 1);
            tableLayoutSchoolData.Controls.Add(labelSchoolType, 0, 2);
            tableLayoutSchoolData.Dock = DockStyle.Fill;
            tableLayoutSchoolData.Location = new Point(3, 3);
            tableLayoutSchoolData.Name = "tableLayoutSchoolData";
            tableLayoutSchoolData.RowCount = 8;
            tableLayoutSchoolData.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutSchoolData.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableLayoutSchoolData.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutSchoolData.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableLayoutSchoolData.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutSchoolData.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableLayoutSchoolData.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutSchoolData.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableLayoutSchoolData.Size = new Size(780, 346);
            tableLayoutSchoolData.TabIndex = 0;
            // 
            // labelSchoolName
            // 
            labelSchoolName.AutoSize = true;
            labelSchoolName.Dock = DockStyle.Fill;
            labelSchoolName.Location = new Point(3, 0);
            labelSchoolName.Name = "labelSchoolName";
            labelSchoolName.Size = new Size(384, 41);
            labelSchoolName.TabIndex = 0;
            labelSchoolName.Text = "Пълно (официално) име:";
            labelSchoolName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelSchoolShortName
            // 
            labelSchoolShortName.AutoSize = true;
            labelSchoolShortName.Dock = DockStyle.Fill;
            labelSchoolShortName.Location = new Point(3, 41);
            labelSchoolShortName.Name = "labelSchoolShortName";
            labelSchoolShortName.Size = new Size(384, 44);
            labelSchoolShortName.TabIndex = 1;
            labelSchoolShortName.Text = "Кратко име:";
            labelSchoolShortName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelSchoolType
            // 
            labelSchoolType.AutoSize = true;
            labelSchoolType.Dock = DockStyle.Fill;
            labelSchoolType.Location = new Point(3, 85);
            labelSchoolType.Name = "labelSchoolType";
            labelSchoolType.Size = new Size(384, 41);
            labelSchoolType.TabIndex = 2;
            labelSchoolType.Text = "Вид:";
            labelSchoolType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(786, 352);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ръководство";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // SchoolForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutSchool);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SchoolForm";
            Text = "SchoolForm";
            tableLayoutSchool.ResumeLayout(false);
            tabControlSchool.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutSchoolData.ResumeLayout(false);
            tableLayoutSchoolData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutSchool;
        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tabControlSchool;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutSchoolData;
        private Label labelSchoolName;
        private Label labelSchoolShortName;
        private Label labelSchoolType;
    }
}