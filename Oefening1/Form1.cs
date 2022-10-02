using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Oefening1
{
    public partial class Begroeting : Form
    {
        public Begroeting()
        {
            InitializeComponent();

            string username = Environment.UserName;
            string hour = DateTime.Now.ToShortTimeString();
            string date = DateTime.Now.ToShortDateString();


            string s = $"Hello {username}. Het is {hour} op {date} .";

            textBox1.Text = s;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Begroeting_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}