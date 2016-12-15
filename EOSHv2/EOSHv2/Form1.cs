//created by JMP. 
//distributed through github with the GNU GENERAL PUBLIC LICENSE v3.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOSHv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            //omber
            #region
            double ombBuy1 = Convert.ToDouble(OmberBuy1.Text);
            double ombBuy2 = Convert.ToDouble(OmberBuy2.Text);
            double ombBuy3 = Convert.ToDouble(OmberBuy3.Text);
            double compOmb1 = Convert.ToDouble(CompOmberBuy1.Text);
            double compOmb2 = Convert.ToDouble(CompOmberBuy2.Text);
            double compOmb3 = Convert.ToDouble(CompOmberBuy3.Text);
            #endregion
            //plag
            #region
            double plagBuy1 = Convert.ToDouble(PlagBuy1.Text);
            double plagBuy2 = Convert.ToDouble(PlagBuy2.Text);
            double plagBuy3 = Convert.ToDouble(PlagBuy3.Text);
            double compPlag1 = Convert.ToDouble(CompPlagBuy1.Text);
            double compPlag2 = Convert.ToDouble(CompPlagBuy2.Text);
            double compPlag3 = Convert.ToDouble(CompPlagBuy3.Text);
            #endregion
            //scor
            #region
            double scorBuy1 = Convert.ToDouble(ScorBuy1.Text);
            double scorBuy2 = Convert.ToDouble(ScorBuy2.Text);
            double scorBuy3 = Convert.ToDouble(ScorBuy3.Text);
            double compScor1 = Convert.ToDouble(CompScorBuy1.Text);
            double compScor2 = Convert.ToDouble(CompScorBuy2.Text);
            double compScor3 = Convert.ToDouble(CompScorBuy3.Text);
            #endregion
            //veld
            #region
            double veldBuy1 = Convert.ToDouble(VeldBuy1.Text);
            double veldBuy2 = Convert.ToDouble(VeldBuy2.Text);
            double veldBuy3 = Convert.ToDouble(VeldBuy3.Text);
            double compVeld1 = Convert.ToDouble(CompVeldBuy1.Text);
            double compVeld2 = Convert.ToDouble(CompVeldBuy2.Text);
            double compVeld3 = Convert.ToDouble(CompVeldBuy3.Text);
            #endregion
            //holders
            #region
            double hold1 = ombBuy1 * 100;
            double hold2 = ombBuy2 * 100;
            double hold3 = ombBuy3 * 100;
            double hold4 = plagBuy1 * 100;
            double hold5 = plagBuy2 * 100;
            double hold6 = plagBuy3 * 100;
            double hold7 = scorBuy1 * 100;
            double hold8 = scorBuy2 * 100;
            double hold9 = scorBuy3 * 100;
            double hold10 = veldBuy1 * 100;
            double hold11 = veldBuy2 * 100;
            double hold12 = veldBuy3 * 100;
            #endregion

            //logic
            //omber
            #region
            if (hold1 >= compOmb1)
            {
                OmberOut1.Text = "NO";
            }
            else
            {
                OmberOut1.Text = "YES";
            }
            if (hold2 >= compOmb2)
            {
                OmberOut2.Text = "NO";
            }
            else
            {
                OmberOut2.Text = "YES";
            }
            if (hold3 >= compOmb3)
            {
                OmberOut3.Text = "NO";
            }
            else
            {
                OmberOut3.Text = "YES";
            }
            #endregion
            //plag
            #region
            if (hold4 >= compPlag1)
            {
                PlagOut1.Text = "NO";
            }
            else
            {
                PlagOut1.Text = "YES";
            }
            if (hold5 >= compPlag2)
            {
                PlagOut2.Text = "NO";
            }
            else
            {
                PlagOut2.Text = "YES";
            }
            if (hold6 >= compPlag3)
            {
                PlagOut3.Text = "NO";
            }
            else
            {
                PlagOut3.Text = "YES";
            }
            #endregion
            //scor
            #region
            if (hold7 >= compScor1)
            {
                ScorOut1.Text = "NO";
            }
            else
            {
                ScorOut1.Text = "YES";
            }
            if (hold8 >= compScor2)
            {
                ScorOut2.Text = "NO";
            }
            else
            {
                ScorOut2.Text = "YES";
            }
            if (hold9 >= compScor3)
            {
                ScorOut3.Text = "NO";
            }
            else
            {
                ScorOut3.Text = "YES";
            }
            #endregion
            //veld
            #region
            if (hold10 >= compVeld1)
            {
                VeldOut1.Text = "NO";
            }
            else
            {
                VeldOut1.Text = "YES";
            }
            if (hold11 >= compVeld2)
            {
                VeldOut2.Text = "NO";
            }
            else
            {
                VeldOut2.Text = "YES";
            }
            if (hold12 >= compVeld3)
            {
                VeldOut3.Text = "NO";
            }
            else
            {
                VeldOut3.Text = "YES";
            }
            #endregion
        }
    }
}