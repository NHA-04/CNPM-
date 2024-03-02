namespace HOMEPAGE
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private Form currentFormChile;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChile != null)
            {
                currentFormChile.Close();
            }
            currentFormChile = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm f2 = new ();
            f2.Show();
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new History());
            label1.Text = btnLichSu.Text;
        }

        private void btnBoPhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CacBoPhan());
            label1.Text = btnBoPhan.Text;
        }

        private void btnLienLac_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LienLac());
            label1.Text = btnLienLac.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChile != null)
            {
                currentFormChile.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel_Body_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
