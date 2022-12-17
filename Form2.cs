using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAKnap
{
    public partial class ChartForm : Form
    {
        string[] ItemName=new string[20];
        double[] ben=new double[20];
        double[] wei = new double[20];
        public ChartForm(string [] items ,double [] weight,double [] benifit)
        {
           
            InitializeComponent();
            try
            {
                Weight_Chart.Series["Benifit"].Points.Clear();
                Weight_Chart.Series["Weight"].Points.Clear();
                for (int i = 0; i < items.Length; i++)
                {
                    this.Weight_Chart.Series["Benifit"].Points.AddXY(items[i], weight[i]);

                    this.Benefit_Chart.Series["Weight"].Points.AddXY(items[i], benifit[i]);
                }
            }
            catch (Exception)
            {
               MessageBox.Show("Enter data to view Charts values");
                
            }
        }

        private void Exit_Lbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
