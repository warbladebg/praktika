namespace SchoolBook
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            buttonEvents = new Button();
            buttonSchool = new Button();
            buttonAdministration = new Button();
            panel1 = new Panel();
            MainPanel = new Panel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(560, 270);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Controls.Add(button2, 0, 1);
            tableLayoutPanel2.Controls.Add(buttonEvents, 0, 2);
            tableLayoutPanel2.Controls.Add(buttonSchool, 0, 3);
            tableLayoutPanel2.Controls.Add(buttonAdministration, 0, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 2);
            tableLayoutPanel2.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(108, 266);
            tableLayoutPanel2.TabIndex = 0;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.BottomLeft;
            button1.Location = new Point(2, 2);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(104, 49);
            button1.TabIndex = 0;
            button1.Text = "Начало";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(2, 55);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(104, 49);
            button2.TabIndex = 1;
            button2.Text = "Дневник";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonEvents
            // 
            buttonEvents.Dock = DockStyle.Fill;
            buttonEvents.Image = (Image)resources.GetObject("buttonEvents.Image");
            buttonEvents.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEvents.Location = new Point(2, 108);
            buttonEvents.Margin = new Padding(2, 2, 2, 2);
            buttonEvents.Name = "buttonEvents";
            buttonEvents.Size = new Size(104, 49);
            buttonEvents.TabIndex = 2;
            buttonEvents.Text = "Събития";
            buttonEvents.TextAlign = ContentAlignment.MiddleRight;
            buttonEvents.UseVisualStyleBackColor = true;
            buttonEvents.Click += buttonEvents_Click;
            // 
            // buttonSchool
            // 
            buttonSchool.Dock = DockStyle.Fill;
            buttonSchool.Image = (Image)resources.GetObject("buttonSchool.Image");
            buttonSchool.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSchool.Location = new Point(2, 161);
            buttonSchool.Margin = new Padding(2, 2, 2, 2);
            buttonSchool.Name = "buttonSchool";
            buttonSchool.Size = new Size(104, 49);
            buttonSchool.TabIndex = 3;
            buttonSchool.Text = "Училище";
            buttonSchool.TextAlign = ContentAlignment.MiddleRight;
            buttonSchool.UseVisualStyleBackColor = true;
            buttonSchool.Click += buttonSchool_Click;
            // 
            // buttonAdministration
            // 
            buttonAdministration.Dock = DockStyle.Fill;
            buttonAdministration.Image = (Image)resources.GetObject("buttonAdministration.Image");
            buttonAdministration.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdministration.Location = new Point(2, 214);
            buttonAdministration.Margin = new Padding(2, 2, 2, 2);
            buttonAdministration.Name = "buttonAdministration";
            buttonAdministration.RightToLeft = RightToLeft.No;
            buttonAdministration.Size = new Size(104, 50);
            buttonAdministration.TabIndex = 4;
            buttonAdministration.Text = "Администрация";
            buttonAdministration.TextAlign = ContentAlignment.MiddleRight;
            buttonAdministration.UseVisualStyleBackColor = true;
            buttonAdministration.Click += buttonAdministration_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(MainPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(114, 2);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 266);
            panel1.TabIndex = 1;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Margin = new Padding(2, 2, 2, 2);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(444, 266);
            MainPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2, 2, 2, 2);
            MinimumSize = new Size(509, 247);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SchoolBook";
            Load += MainForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button buttonEvents;
        private Button buttonSchool;
        private Button buttonAdministration;
        private Panel MainPanel;
    }
}
