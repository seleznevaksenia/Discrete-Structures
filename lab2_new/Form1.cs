using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataGridViewColumn dgc = new DataGridViewColumn();
            dgc = new DataGridViewTextBoxColumn();
            dgc.HeaderText = "";
            dgc.Name = "1";
            dataGridView1.Columns.Add(dgc);
            dgc = new DataGridViewTextBoxColumn();
            dgc.HeaderText = "Automate";
            dgc.Name = "2";
            dataGridView1.Columns.Add(dgc);
            dgc = new DataGridViewTextBoxColumn();
            dgc.HeaderText = "Go";
            dgc.Name = "3";
            dataGridView1.Columns.Add(dgc);
        }

        public int row = 0;
        public List<char> cpu = new List<char>();
        public List<int> go = new List<int>();
        public int counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i <= row; i++)
            {
                dataGridView1.Rows[i].Cells["2"].Style.BackColor = Color.White;
            }
            List<char> check = new List<char>();

            string inputUser = input.Text;
            int size = 0;
            foreach (char item in inputUser)
            {
                check.Add(item);
                size += 1;
            }
            check.Add('.');
            size += 1;
            int k = 0;
            if (row == 0)
            {
                int i = 0;
                foreach (char item in check)
                {
                    cpu.Add(item);
                    go.Add(0);
                    dataGridView1.Rows.Add("", cpu[i], "");
                    i++;
                }
                dataGridView1.Rows[0].Cells["1"].Value = 1;
                row = size;
                counter = 1;
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    if (cpu[i] == check[k])
                    {
                        dataGridView1.Rows[i].Cells["2"].Style.BackColor = Color.Red;
                        k++;
                        continue;
                    }
                    else
                    {
                        if (go[i] != 0)
                        {
                            i = go[i]-1;
                            size = size + i+1;
                            continue;
                        }
                        else
                        {
                            go[i] = row;

                            counter++;
                            dataGridView1.Rows[i].Cells["3"].Value = counter;
                            dataGridView1.Rows.Add(counter, check[k], "");
                            cpu.Add(check[k]);
                            go.Add(0);
                            k++;
                           
                            for (int j = 0; j < size - i-1; j++)
                            {
                                cpu.Add(check[k]);
                                go.Add(0);
                                dataGridView1.Rows.Add("", check[k], "");
                                k++;
                                row++;
                            }
                            break;

                        }
                    }
                }
            }
        }
    }
}
