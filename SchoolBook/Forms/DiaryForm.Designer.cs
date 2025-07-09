namespace SchoolBook.Forms
{
    partial class DiaryForm
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
            tabControl1 = new TabControl();
            Оценки = new TabPage();
            Отсъствия = new TabPage();
            Разписание = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Оценки);
            tabControl1.Controls.Add(Отсъствия);
            tabControl1.Controls.Add(Разписание);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // Оценки
            // 
            Оценки.Location = new Point(4, 34);
            Оценки.Name = "Оценки";
            Оценки.Padding = new Padding(3);
            Оценки.Size = new Size(792, 412);
            Оценки.TabIndex = 0;
            Оценки.Text = "Оценки";
            Оценки.UseVisualStyleBackColor = true;
            // 
            // Отсъствия
            // 
            Отсъствия.Location = new Point(4, 34);
            Отсъствия.Name = "Отсъствия";
            Отсъствия.Padding = new Padding(3);
            Отсъствия.Size = new Size(792, 412);
            Отсъствия.TabIndex = 1;
            Отсъствия.Text = "Отсъствия";
            Отсъствия.UseVisualStyleBackColor = true;
            // 
            // Разписание
            // 
            Разписание.Location = new Point(4, 34);
            Разписание.Name = "Разписание";
            Разписание.Size = new Size(792, 412);
            Разписание.TabIndex = 2;
            Разписание.Text = "Разписание";
            Разписание.UseVisualStyleBackColor = true;
            // 
            // DiaryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DiaryForm";
            Text = "DiaryForm";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Оценки;
        private TabPage Отсъствия;
        private TabPage Разписание;
    }
}