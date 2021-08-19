using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inl1_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Runs when the button is clicked
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Converting text input to integers
                int cost = Convert.ToInt32(costInput.Text);
                int payment = Convert.ToInt32(paymentInput.Text);

                //Calculating the difference
                int exchange = payment - cost;
                if (exchange < 0) throw new Exception();


                ExchangeCalculator ec = new ExchangeCalculator(exchange);
                outputTextbox.Text = ec.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Check that all input is correct", "Wrong Input!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

       
    }

    class ExchangeCalculator
    {

        /* Fields */
        int[] valors = new int[] { 500, 200, 100, 50, 20, 5, 2, 1 };
        Dictionary<int, int> exchange;
        int sum;

        /* Constructor */
        public ExchangeCalculator(int sum)
        {
            this.exchange = new Dictionary<int, int>();
            this.sum = sum;
            Calculate(sum);
        }

        /* Iterate each valid valor and calculate amount of valor in descending order */
        public void Calculate(int sum)
        {
            int units = 0; // temporary variable
            foreach (int v in this.valors)
            {
                if (v == 0 || sum < v) continue;
                units = sum / v; // round off downwards
                this.exchange.Add(v, units);
                sum = sum % (units * v);
            }
        }

        /* Custom designed toString to match the output of uppgiftslydelsen */
        public override string ToString()
        {
            String s = "";
            if (this.sum == 0) return "Even steven! No exchange back, I'm afraid.";
            foreach (KeyValuePair<int, int> e in this.exchange)
            {
                //s += "Valor: " + e.Key + ", amount of units: " + e.Value + "\n";
                if (e.Value != 0)
                {
                    String temp = e.Key <= 10 ? "coin(s)" : "bill(s)";
                    s += e.Value + " * " + e.Key + "-" + temp + "\n";
                }
            }

            // should obviously not be put here, but here it is.
            s += "... with a total of " + this.sum + ". Have a nice weekend!";
            return s;
        }


    } // end of ExchangeCalculator
}
