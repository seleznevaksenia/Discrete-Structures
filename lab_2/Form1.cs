using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public string[,] cpu = new string[8, 5];
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] lexems;
            string[] states;

            int j;
            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Ksenija\Documents\Visual Studio 2015\Projects\DS\lab1\CPU\CPU.txt");
            int i = 0;
            foreach (string line in lines)
            {
                if (i == 0)
                {
                    lexems = line.Split('\t');
                    foreach (string word in lexems)
                    {
                        richTextBox2.AppendText("\t" + word);

                    }
                }
                else if (i == 1)
                {
                    states = line.Split('\t');

                }
                else
                {
                    j = 0;
                    string[] words = line.Split('\t');
                    foreach (string word in words)
                    {
                        cpu[i - 2, j] = word;
                        richTextBox2.AppendText("\t" + cpu[i - 2, j]);
                        j++;
                    }
                }
                i++;
                richTextBox2.AppendText("\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> translit = new List<string>();
            List<char> number = new List<char>();
            string inputUser = input.Text;
            Nullable<Int32> RN = null;
            Nullable<Int32> RO = null;
            Nullable<Int32> RC = null;
            Nullable<Int32> RS = null;
            foreach (char item in inputUser)
            {
                if (item >= '0' && item <= '9')
                {
                    translit.Add("d");
                    number.Add(item);
                }
                else
                {
                    switch (item)
                    {
                        case '.':
                            translit.Add(".");
                            number.Add(item);
                            break;
                        case '-':
                            translit.Add("sign");
                            number.Add(item);
                            break;
                        case '+':
                            translit.Add("sign");
                            number.Add(item);
                            break;
                        case 'E':
                            translit.Add("E");
                            number.Add(item);
                            break;
                        default:
                            result.AppendText("Input is not a number\n");
                            number.Add(item);
                            return;
                    }
                }

            }
            translit.Add("end");
            string temp = "";
            int i = 0;
            int j = 0;
            foreach (string item in translit)
            {
                switch (item)
                {
                    case "d":
                        temp = cpu[i, 0];
                        if (temp == "Error")
                        {
                            result.AppendText("\nError");
                            return;
                        }
                        else
                        {
                            i = Int32.Parse(temp[0].ToString()) - 1;

                            switch (temp)
                            {
                                case "2a":
                                    RN = Int32.Parse(number[j].ToString());
                                    break;
                                case "2b":
                                    RN = RN * 10 + Int32.Parse(number[j].ToString());
                                    break;
                                case "3a":
                                    RC += 1;
                                    RN = RN * 10 + Int32.Parse(number[j].ToString());
                                    break;
                                case "6a":
                                    RS = 1;
                                    RO = Int32.Parse(number[j].ToString());
                                    break;
                                case "6b":
                                    RO = Int32.Parse(number[j].ToString());
                                    break;
                                case "6c":
                                    RO = RO * 10 + Int32.Parse(number[j].ToString());
                                    break;
                                case "3b":
                                    RN = Int32.Parse(number[j].ToString());
                                    RC = 1;
                                    break;
                            }
                        }


                        result.AppendText("\nGo" + temp + "\tRN=" + RN.ToString() + "\tRO=" + RO.ToString() + "\tRC=" + RC.ToString() + "\tRS=" + RS.ToString());
                        break;
                    case "E":
                        temp = cpu[i, 1];
                        if (temp == "Error")
                        {
                            result.AppendText("\nError");
                            return;
                        }
                        else if (temp == "4a")
                        {
                            RC = 0;
                            i = Int32.Parse(temp[0].ToString()) - 1;
                        }
                        else if (temp == "4b")
                        {
                            i = Int32.Parse(temp[0].ToString()) - 1;
                        }
                        result.AppendText("\nGo" + temp + "\tRN=" + RN.ToString() + "\tRO=" + RO.ToString() + "\tRC=" + RC.ToString() + "\tRS=" + RS.ToString());
                        break;
                    case ".":
                        temp = cpu[i, 2];
                        if (temp == "Error")
                        {
                            result.AppendText("\nError");
                            return;
                        }
                        else if (temp == "7")
                        {

                            i = Int32.Parse(temp[0].ToString()) - 1;
                        }
                        else if (temp == "3c")
                        {
                            RC = 0;
                            i = Int32.Parse(temp[0].ToString()) - 1;
                        }
                        result.AppendText("\nGo" + temp + "\tRN=" + RN.ToString() + "\tRO=" + RO.ToString() + "\tRC=" + RC.ToString() + "\tRS=" + RS.ToString());
                        break;
                    case "sign":
                        temp = cpu[i, 3];
                        if (number[j] == '-')
                        {
                            RS = -1;
                        }
                        else
                        {
                            RS = 1;
                        }
                        if (temp == "Error")
                        {
                            result.AppendText("\nError");
                            return;
                        }
                        else
                        {
                            i = Int32.Parse(temp[0].ToString()) - 1;
                        }
                        result.AppendText("\nGo" + temp + "\tRN=" + RN.ToString() + "\tRO=" + RO.ToString() + "\tRC=" + RC.ToString() + "\tRS=" + RS.ToString());
                        break;
                    case "end":
                        temp = cpu[i, 4];
                        if (temp == "0")
                        {
                            result.AppendText("\nError");
                            return;
                        }
                        else
                        {
                            switch (temp)
                            {
                                case "admit1":
                                    {
                                        RO = 0;
                                        result.AppendText("\nInteger");
                                        result.AppendText("\nRN=" + RN.ToString() + "*10^" + RO.ToString());
                                        return;
                                    }
                                case "admit2":
                                    {
                                        result.AppendText("\nInteger with E");
                                        result.AppendText("\nRN=" + RN.ToString() + "*10^" + RO.ToString());
                                        return;
                                    }
                                case "admit3":
                                    {
                                        result.AppendText("\n double with E");

                                        RO = RO * RS - RC;
                                        result.AppendText("\nRN=" + RN.ToString() + "*10^" + RO.ToString());
                                        return;
                                    }
                                case "0":
                                    {
                                        result.AppendText("\n not allowed");
                                        return;
                                    }
                            }
                        }
                        break;
                }

                j++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result.Text = ("");
        }
    }
}
