using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW
{
    public partial class Form1 : Form
    {
        public string[,] cpu = new string[10, 3];
        public Stack<char> inputUser = new Stack<char>();
        public string[] inpuAlfabet;
        public List<string> stack = new List<string>();
        public Form1()
        {
            InitializeComponent();
            task.AppendText("{1^(n+2)0^(n)1^(m)0^(m+1),m,n >= 2}");
        }

        private void automate_Click(object sender, EventArgs e)
        {

            int j;
            int i = 0;
            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Ksenija\Documents\Visual Studio 2015\Projects\DS\CW\CPU\CPU.txt");
            table.AppendText("Stack");
            foreach (string line in lines)
            {
                if (i == 0)
                {
                    inpuAlfabet = line.Split('\t');
                    foreach (string word in inpuAlfabet)
                    {
                        table.AppendText("\t" + word);
                    }
                }
                else
                {
                    table.AppendText(line);
                    j = 0;
                    string[] words = line.Split('\t');
                    foreach (string word in words)
                    {
                        if(j == 0)
                        {
                            stack.Add(word);
                        }
                        else
                        {
                            cpu[i - 1, j - 1] = word;
                        }
                        
                        j++;
                    }
                }
                i++;
                table.AppendText("\n");
            }
        }

        private void translate_Click(object sender, EventArgs e)
        {
            Stack<string> state = new Stack<string>();
            state.Push("end");
            state.Push("S"); // в стеке 3
            Stack<string> inputUser = new Stack<string>();
            string output_ = "";
            string temp = input.Text;
            string command;

            string S = "1a1a1a1aA0c0c1d1dB0b0b0b";
            string A = "1aA0c";
            string B = "1cB0d";
            inputUser.Push("E");
            for (int n= temp.Length - 1; n >= 0; n--)
            {
                inputUser.Push(temp[n].ToString());
            }
            int i = 0;
            int j = 0;
            string item = "";
            do
            {
                item = inputUser.Peek();
                i = stack.IndexOf(state.Peek());
                j = Array.IndexOf(inpuAlfabet, item);
                if (j == -1 || i == -1)
                {
                    output.AppendText("Error");
                    return;
                }
                command = cpu[i, j];
                switch (command)
                {
                    case "#1":
                        inputUser.Pop();
                        state.Pop();
                        string t = new string(S.ToCharArray().Reverse().ToArray());
                        foreach (char c in t)
                        {
                            state.Push(c.ToString());
                        }
                        state.Pop();
                        output_ += state.Pop();
                        break;
                    case "Error":
                        output.AppendText("Error");
                        return;
                    case "#2":
                        inputUser.Pop();
                        state.Pop();
                        t = new string(A.ToCharArray().Reverse().ToArray());
                        foreach (char c in t)
                        {
                            state.Push(c.ToString());
                        }
                        state.Pop();
                        output_ += state.Pop();
                        break;
                    case "#3":
                        inputUser.Pop();
                        state.Pop();
                        t = new string(B.ToCharArray().Reverse().ToArray());
                        foreach (char c in t)
                        {
                            state.Push(c.ToString());
                        }
                        state.Pop();
                        output_ += state.Pop();
                        break;
                    case "#4":
                        state.Pop();
                        break;
                    case "#5":
                        state.Pop();
                        inputUser.Pop();
                        break;
                    case "give":
                        output_ += state.Pop();
                        break;
                    case "Admit":
                        output.AppendText(output_);
                        return;
                    default:
                        return;
                }
            } while (true);

        }
    }
}
