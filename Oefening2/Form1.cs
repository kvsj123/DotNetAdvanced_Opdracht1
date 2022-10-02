using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int res1 = 12345 * 54321;
            int res2 = 22222 * 33333;
            bool res3 = res1 > res2;

            string s1 = $"12345 * 54321 = {res1}";
            string s2 = $"22222 * 33333 = {res2}";
            string s3 = $"12345 * 54321 > 22222 * 33333 = {res3}";

            resultLb1.Text = s1;
            resultLb2.Text = s2;
            resultLb3.Text = s3;
        }

        private void resultLb1_Click(object sender, EventArgs e)
        {
            
        }

        private void resultLb2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}