using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace DSAKnap
{
    public partial class MainForm : Form
    {
        double[] weight;
        double[] benefit;
        double[] ratio;
        string[] ItemName;
        double KnapWeight = 25;  //Maximum weight of Knapsack
        double[] selectedBen, selectedWei;  //Selected weight and benefit
        int len;
        double[] weightPercnt;  // Selected weight percentage
        double[] benifitPercnt;  // Selected benefit percentage
        public MainForm()
        {
            InitializeComponent();
            KnapsackWeght_Lbl.Text = KnapWeight.ToString() + " KG";
        }
        private void Calculate_Btn_Click(object sender, EventArgs e)
        {
            Result_GV.Rows.Clear();
            ShowCart_Btn.Visible = true;
            Result_GV.Refresh();
            Listbox1.Items.Clear();
            Result_GV.ColumnCount = 8;
            Result_GV.Columns[0].Name = "Items Name";
            Result_GV.Columns[1].Name = "Items Weights";
            Result_GV.Columns[2].Name = "Items Benifits";
            Result_GV.Columns[3].Name = "Items Ratio";
            Result_GV.Columns[4].Name = "Selected Weight";
            Result_GV.Columns[5].Name = "Selected Benifit";
            Result_GV.Columns[6].Name = "Select Weight %";
            Result_GV.Columns[7].Name = "Select Benifit %";
            getcall();
            Result_GV.ClearSelection();
        }
        public void getcall() 
        {
            try
            {
                string items = ItemName_TB.Text;
                ItemName = items.Split(',').ToArray();
                string itemWeight = ItemWeight_TB.Text;
                weight = itemWeight.Split(',').Select(Double.Parse).ToArray();
                string itemValue = (ItemValue_TB.Text);
                benefit = itemValue.Split(',').Select(Double.Parse).ToArray();
                len = weight.Length;
                ratio = new double[weight.Length]; //ratio determines the order in which items are entered
                //Calculating Ratio
                for (int i = 0; i < len; ++i)
                {
                    ratio[i] = benefit[i] / weight[i];
                }
                int k = 0;
                while (k < len)
                {
                    Result_GV.Rows.Add();
                    k++;
                }
                int j = 0;
                int v = len;
                while (j < v)
                {
                    Result_GV.Rows[j].Cells[0].Value = ItemName[j];
                    Result_GV.Rows[j].Cells[1].Value = weight[j].ToString();
                    Result_GV.Rows[j].Cells[2].Value = benefit[j].ToString();
                    Result_GV.Rows[j].Cells[3].Value = ratio[j].ToString();

                    j++;
                }
                fill();
            }
            catch (Exception)
            {
                MessageBox.Show("Please make sure input is correct");
            }
        }
        public int getNext()
        {
            double highest = 0;
            int index = -1;
            for (int i = 0; i < benefit.Length; ++i) //Get the highest ratio item 
            {
                if (ratio[i] > highest) //Highest ratio/valued item will go in first
                {
                    highest = ratio[i];
                    index = i;
                }
            }
            return index;  //Return the index of the most valued item
        }
        void fill() //fill remaining colums
        {
            double tempWeight, tempBenefit;
            //tempWeight saves temperory weight of item which will add in array*(double[] wei)  & sum in last 
            //tempBenefit saves temperory benifit of item which will add in array*(double[] ben)  & sum in last
            selectedWei = new double[weight.Length];
            //wei save value of weights
            selectedBen = new double[weight.Length];
            //ben save value of benifits
            double cW = 0; //current weight
            double cB = 0; //current benefit 
            int index = 0;
            int[] itemarray = new int[len];   // this save which item is selected

            //  Console.WriteLine("\nItems considered: ");
            while (cW < KnapWeight)
            {
                int item = getNext();        //next highest ratio
                if (item == -1)
                {
                    //No items left
                    break;
                }
                itemarray[index] = (item + 1);
                index++;
                if (cW + weight[item] <= KnapWeight)
                {
                    //Add items to knapsack with their respective weights
                    tempWeight = weight[item];
                    selectedWei[item] = tempWeight;
                    tempBenefit = benefit[item];
                    selectedBen[item] = tempBenefit;
                    cW += tempWeight;
                    cB += tempBenefit;
                    //mark as used for the getNext() (ratio) function
                    ratio[item] = 0; //So that item wieght is not added repeatedly
                }
                else
                {
                    //Select part of an item and give user the indication that knapsack is full
                    tempBenefit = (ratio[item] * (KnapWeight - cW));
                    selectedBen[item] = tempBenefit;
                    tempWeight = (KnapWeight - cW);
                    selectedWei[item] = tempWeight;
                    cB += tempBenefit;
                    cW += tempWeight;
                    MessageBox.Show("Knapsack is full");
                    break;  //the knapsack is full
                }
            }
            weightPercnt = new double[weight.Length];
            benifitPercnt = new double[weight.Length];
            for (int i = 0; i < len; i++)
            {
                weightPercnt[i] = (selectedWei[i] / cW) * 100;
                benifitPercnt[i] = (selectedBen[i] / cB) * 100;
            }
            for (int i = 0; i < index; i++)
            {
                if (itemarray[i] != 0)
                {
                    string[] aaa = Array.ConvertAll(itemarray, element => element.ToString()).ToArray();
                    Listbox1.Items.Add(aaa[i]).ToString();
                }
            }
            label6.Text = cB.ToString();
            label7.Text = cW.ToString();
            for (int i = 0; i < len; i++) //Fill Remaining Colums
            {
                Result_GV.Rows[i].Cells[4].Value = selectedWei[i].ToString();
                Result_GV.Rows[i].Cells[5].Value = selectedBen[i].ToString();
                Result_GV.Rows[i].Cells[7].Value = benifitPercnt[i].ToString();
                Result_GV.Rows[i].Cells[6].Value = weightPercnt[i].ToString();
            }
        }
        private void HowToUse_Lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutForm ob = new AboutForm();
            ob.ShowDialog();
        }

        private void ShowCart_Btn_Click(object sender, EventArgs e)
        {
            ChartForm obj = new ChartForm(ItemName, weightPercnt, benifitPercnt);
            obj.ShowDialog();
        }
    }
}
