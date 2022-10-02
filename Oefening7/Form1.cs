namespace Oefening7
{
    public partial class Sum : Form
    {
        public Sum()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int som=0;
            int result = Convert.ToInt32(tbNumber.Text);
            int counter = 1;

            do
            {
                som += counter;
                counter++;
            }
            while(counter <= result);

            tbRes.Text = som.ToString();
        }
    }
}