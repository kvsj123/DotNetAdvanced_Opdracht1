namespace Oefening6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            const double taxConst = 0.07;
            double ShipCost = 0;

            double quantity1 = Convert.ToDouble(q1.Text);
            double quantity2 = Convert.ToDouble(q2.Text);
            double quantity3 = Convert.ToDouble(q3.Text);
            double quantity4 = Convert.ToDouble(q4.Text);

            double price1 = Convert.ToDouble(PE1.Text);
            double price2 = Convert.ToDouble(PE2.Text);
            double price3 = Convert.ToDouble(PE3.Text);
            double price4 = Convert.ToDouble(PE4.Text);

            double extPrice1 = quantity1 * price1;
            double extPrice2 = quantity2 * price2;
            double extPrice3 = quantity3 * price3;
            double extPrice4 = quantity4 * price4;


            //
            EP1.Text = "€" + extPrice1.ToString();
            EP2.Text = "€" + extPrice2.ToString();
            EP3.Text = "€" + extPrice3.ToString();
            EP4.Text = "€" + extPrice4.ToString();


            //
            double subtotaal = extPrice1 + extPrice2 + extPrice3 + extPrice4;
            Subt.Text = "€" + subtotaal.ToString();

            double salesTax = subtotaal * taxConst;
            SalT.Text = "€" + salesTax.ToString();

            if(subtotaal < 20)
            {
                ShipCost = 5;

            } else if(subtotaal < 50)
            {
                ShipCost = 7.5;

            } else if(subtotaal < 75)
            {
                ShipCost = 10;
                
            } else if(subtotaal >= 75)
            {
                ShipCost = 0;
                
            }

            Ship.Text = "€" + ShipCost.ToString();

            
            double grandTotal = subtotaal + salesTax + ShipCost;
            GT.Text = "€" + grandTotal.ToString();

        }
    }
}