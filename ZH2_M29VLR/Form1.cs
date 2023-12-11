namespace ZH2_M29VLR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztosan be akarja zárni az alkalmazást?", "Alkalmazás bezárása", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void brnUc1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 uc = new UserControl1(); 
            uc.Dock = DockStyle.Fill;   
            panel1.Controls.Add(uc);
        }

        private void btnUc2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl2 uc = new UserControl2();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }

        private void btnUc3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 uc = new UserControl3();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }
    }
}