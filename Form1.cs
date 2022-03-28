using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal DollarsToYen(decimal dollars)
        {
            return dollars * (decimal)108.22;
        }

        private decimal YenToPound(decimal yen)
        {
            return yen * (decimal)0.0071;
        }

        private decimal PoundToEuro(decimal pound)
        {
            return pound * (decimal)1.16;
        }

        private decimal EuroToYuan(decimal euro)
        {
            return euro * (decimal)7.85;
        }

        private decimal YuanToDollars(decimal yuan)
        {
            return yuan * (decimal)0.14;
        }

        private void Convert_BTN_Click(object sender, EventArgs e)
        {
            // let's take the input from the textbox
            if (Input_TXTBX.Text != "")
            {
                decimal input = 0;
                try
                {
                    input = decimal.Parse(Input_TXTBX.Text);

                    //we will directly change the textboxes for the different currencies 
                    //first convert dollars to Yen
                    DollarsYen_TXTBX.Text = input.ToString();
                    YenDollars_TXTBX.Text = DollarsToYen(input).ToString();

                    //now convert Yen to Pound
                    YenPound_TXTBX.Text = YenDollars_TXTBX.Text;
                    PoundYen_TXTBX.Text = YenToPound(Math.Round(decimal.Parse(YenPound_TXTBX.Text), 1)).ToString();

                    //now convert Pound to Euro
                    PoundEuro_TXTBX.Text = PoundYen_TXTBX.Text;
                    EuroPound_TXTBX.Text = PoundToEuro(Math.Round(decimal.Parse(PoundEuro_TXTBX.Text), 1)).ToString();

                    //now convert Euro to Yuan
                    EuroYuan_TXTBX.Text = EuroPound_TXTBX.Text;
                    YuanEuro_TXTBX.Text = EuroToYuan(Math.Round(decimal.Parse(EuroYuan_TXTBX.Text), 1)).ToString();

                    //now convert Yuan to Dollars
                    YuanDollars_TXTBX.Text = YuanEuro_TXTBX.Text;
                    DollarsYuan_TXTBX.Text = YuanToDollars(Math.Round(decimal.Parse(YuanDollars_TXTBX.Text), 1)).ToString();
                }
                catch
                {
                    MessageBox.Show("Invalid Input!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Input!");
            }
        }
    }
}
