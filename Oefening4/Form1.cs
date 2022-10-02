namespace Oefening4
{
    public partial class SalesTaxCalculator : Form
    {
        public SalesTaxCalculator()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            double quantity1 = Convert.ToDouble(q1.Text);
            double quantity2 = Convert.ToDouble(q2.Text);
            double quantity3 = Convert.ToDouble(q3.Text);
            double quantity4 = Convert.ToDouble(q4.Text);

            double price1 =Convert.ToDouble(PE1.Text);
            double price2 = Convert.ToDouble(PE2.Text);
            double price3 = Convert.ToDouble(PE3.Text);
            double price4 = Convert.ToDouble(PE4.Text);

            double extPrice1 = quantity1 * price1;
            double extPrice2 = quantity2 * price2;
            double extPrice3 = quantity3 * price3;
            double extPrice4 = quantity4 * price4;


            EP1.Text = "€" + extPrice1.ToString();
            EP2.Text = "€" + extPrice2.ToString();
            EP3.Text = "€" + extPrice3.ToString();
            EP4.Text = "€" + extPrice4.ToString();


            double subtotaal = extPrice1 + extPrice2 + extPrice3 + extPrice4;
            Subt.Text = "€" + Math.Round(subtotaal, 2).ToString();

            double taxeRate = Convert.ToDouble(TaxR.Text);
            double salesTax = subtotaal * taxeRate;
            SalT.Text = "€" + Math.Round(salesTax, 2).ToString();

            double shipping = Convert.ToDouble(Ship.Text);
            double grandTotal = subtotaal + salesTax + shipping;
            GT.Text = "€" + Math.Round(grandTotal, 2).ToString();


        }
    }
}