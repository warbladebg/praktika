using SchoolBook.Forms;

namespace SchoolBook
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadForm(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
            {
                this.MainPanel.Controls.RemoveAt(0);
            }

            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(form);
            this.MainPanel.Tag = form;
            form.Show();
        }




        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm(new HomeForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadForm(new DiaryForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadForm(new HomeForm());
        }

        private void buttonAdministration_Click(object sender, EventArgs e)
        {
            LoadForm(new AdministrationForm());
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            LoadForm(new EventsForm());
        }

        private void buttonSchool_Click(object sender, EventArgs e)
        {
            LoadForm(new SchoolForm());
        }
    }
}
