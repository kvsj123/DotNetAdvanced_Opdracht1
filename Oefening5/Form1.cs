namespace Oefening5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void conv1_Click(object sender, EventArgs e)
        {
            try
            {
                double converterCtoF = Convert.ToDouble(Ctb.Text) * 9 / 5 + 32;
                Ftb.Text = converterCtoF.ToString();
            }
            catch 
            {
                Ctb.Text = "Vul iets in!";
                //Ctb.ForeColor = Color.Red;
            }
        }

        private void conv2_Click(object sender, EventArgs e)
        {
            try
            {
                double converterFtoC = (Convert.ToDouble(Ftb.Text) - 32) * 5 / 9;
                Ctb.Text = converterFtoC.ToString();
            }
            catch
            {
                Ftb.Text = "Vul iets in!";
                //Ftb.ForeColor = Color.Red;
            }
        }
    }
}