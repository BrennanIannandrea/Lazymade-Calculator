//@author Brennan Iannandrea
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            bool checkWholebox;
            string a = textBox1.Text;
            foreach(char element in a)
            {
                if (!IsNumeric(element)|| element.ToString() !="/" || element.ToString() != "*" || element.ToString() != "." || element.ToString() != "+" || element.ToString() != "-")
                {
                    checkWholebox = false;
                }
            }
            if (checkWholebox = false){
                while (a.IndexOf("/") != -1 || a.IndexOf("*") != -1)
                {
                if (a.IndexOf("/") != 1 && a.IndexOf("*") == -1)
                    {
                        if (a.IndexOf("/") < a.IndexOf("*"))
                        {
                            int mid = a.IndexOf("/");
                            bool checkfir = false;
                            int findfir = mid;
                            while (checkfir == false)
                            {
                                findfir--;
                                if (!IsNumeric(a[findfir]) && a[findfir].ToString() != ("."))
                                {
                                    checkfir = true;
                                }
                            }
                            bool checklas = false;
                            int findlas = mid;
                            while (checkfir == false)
                            {
                                findlas++;
                                if (!IsNumeric(a[findlas]) && a[findlas].ToString() != ("."))
                                {
                                    checklas = true;
                                }
                            }

                        }
                        else
                        {
                            int mid = a.IndexOf("*");

                        }
                    }
                }
            }
        }
        private bool IsNumeric(string a)
        {
            return int.TryParse(a, out int bla);
        }
        private bool IsNumeric(char a)
        {
            string b = a.ToString();
            return int.TryParse(b, out int bla);
        }
        private bool ValidCheck(string a)
        {

        }
    }
}
