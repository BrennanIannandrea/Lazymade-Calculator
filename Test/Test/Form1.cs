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
            bool checkWholebox = true;
            string a = textBox1.Text;
            foreach (char element in a)
            {
                if (checkWholebox)
                {
                    if (IsNumeric(element) || element.ToString() == "/" || element.ToString() == "*" || element.ToString() == "." || element.ToString() == "+" || element.ToString() == "-")
                    {
                        checkWholebox = true;
                    }
                    else
                    {
                        checkWholebox = false;
                    }
                }
            }
            if (checkWholebox == true)
            {
                while (a.IndexOf("/") != -1 || a.IndexOf("*") != -1)
                {
                    if (a.IndexOf("/") != -1 && a.IndexOf("*") != -1)
                    {
                        if (a.IndexOf("/") < a.IndexOf("*"))
                        {
                            int mid = a.IndexOf("/");
                            bool checkfir = false;
                            int findfir = mid;
                            while (checkfir == false)
                            {
                                if (findfir != 0)
                                {
                                    findfir--;
                                    if (!IsNumeric(a[findfir]) && a[findfir].ToString() != ("."))
                                    {
                                        checkfir = true;
                                    }
                                }
                                else
                                {
                                    checkfir = true;
                                }
                            }
                            bool checklas = false;
                            int findlas = mid;
                            while (checklas == false)
                            {
                                if (findlas < a.Length - 1)
                                {
                                    findlas++;
                                    if (!IsNumeric(a[findlas]) && a[findlas].ToString() != ("."))
                                    {
                                        checklas = true;
                                    }
                                }
                                else
                                {
                                    checklas = true;
                                }
                            }
                            int disfir = mid - findfir;
                            int dislas = findlas - mid;
                            string before = a.Substring(findfir, disfir);
                            string after = a.Substring(mid + 1, dislas);
                            double.TryParse(before, out double bef);
                            double.TryParse(after, out double aft);
                            double con = bef / aft;
                            int dis = findlas - findfir;
                            a = a.Remove(findfir, dis + 1);
                            a = a.Insert(findfir, con.ToString());
                            textBox1.Text = a;
                        }
                        else
                        {
                            int mid = a.IndexOf("*");
                            bool checkfir = false;
                            int findfir = mid;
                            while (checkfir == false)
                            {
                                if (findfir != 0)
                                {
                                    findfir--;
                                    if (!IsNumeric(a[findfir]) && a[findfir].ToString() != ("."))
                                    {
                                        checkfir = true;
                                    }
                                }
                                else
                                {
                                    checkfir = true;
                                }
                            }
                            bool checklas = false;
                            int findlas = mid;
                            while (checklas == false)
                            {
                                if (findlas < a.Length - 1)
                                {
                                    findlas++;
                                    if (!IsNumeric(a[findlas]) && a[findlas].ToString() != ("."))
                                    {
                                        checklas = true;
                                    }
                                }
                                else
                                {
                                    checklas = true;
                                }
                            }
                            int disfir = mid - findfir;
                            int dislas = findlas - mid;
                            string before = a.Substring(findfir, disfir);
                            string after = a.Substring(mid + 1, dislas);
                            double.TryParse(before, out double bef);
                            double.TryParse(after, out double aft);
                            double con = bef / aft;
                            int dis = findlas - findfir;
                            a = a.Remove(findfir, dis + 1);
                            a = a.Insert(findfir, con.ToString());
                            textBox1.Text = a;
                        }
                    }
                    else if (a.IndexOf("/") != -1 && a.IndexOf("*") == -1)
                    {
                        int mid = a.IndexOf("/");
                        bool checkfir = false;
                        int findfir = mid;
                        while (checkfir == false)
                        {
                            if (findfir != 0)
                            {
                                findfir--;
                                if (!IsNumeric(a[findfir]) && a[findfir].ToString() != ("."))
                                {
                                    checkfir = true;
                                }
                            }
                            else
                            {
                                checkfir = true;
                            }
                        }
                        bool checklas = false;
                        int findlas = mid;
                        while (checklas == false)
                        {
                                if (findlas < a.Length - 1)
                                {
                                    findlas++;
                                    if (!IsNumeric(a[findlas]) && a[findlas].ToString() != ("."))
                                    {
                                        checklas = true;
                                    }
                                }
                            else
                            {
                                checklas = true;
                            }
                        }
                        int disfir = mid - findfir;
                        int dislas = findlas - mid;
                        string before = a.Substring(findfir, disfir);
                        string after = a.Substring(mid + 1, dislas);
                        double.TryParse(before, out double bef);
                        double.TryParse(after, out double aft);
                        double con = bef / aft;
                        int dis = findlas - findfir;
                        a = a.Remove(findfir, dis + 1);
                        a = a.Insert(findfir, con.ToString());
                        textBox1.Text = a;
                    }
                    else if (a.IndexOf("*") != -1 && a.IndexOf("/") == -1)
                    {
                        int mid = a.IndexOf("*");
                        bool checkfir = false;
                        int findfir = mid;
                        while (checkfir == false)
                        {
                            if (findfir != 0)
                            {
                                findfir--;
                                if (!IsNumeric(a[findfir]) && a[findfir].ToString() != ("."))
                                {
                                    checkfir = true;
                                }
                            }
                            else
                            {
                                checkfir = true;
                            }
                        }
                        bool checklas = false;
                        int findlas = mid;
                        while (checklas == false)
                        {
                            if (findlas < a.Length - 1)
                            {
                                findlas++;
                                if (!IsNumeric(a[findlas]) && a[findlas].ToString() != ("."))
                                {
                                    checklas = true;
                                }
                            }
                            else
                            {
                                checklas = true;
                            }
                        }
                        int disfir = mid - findfir;
                        int dislas = findlas - mid;
                        string before = a.Substring(findfir, disfir);
                        string after = a.Substring(mid + 1, dislas);
                        double.TryParse(before, out double bef);
                        double.TryParse(after, out double aft);
                        double con = bef / aft;
                        int dis = findlas - findfir;
                        a = a.Remove(findfir, dis + 1);
                        a = a.Insert(findfir, con.ToString());
                        textBox1.Text = a;
                    }
                }
                while (a.IndexOf("+") != -1 || a.IndexOf("-") != -1)
                {
                    if (a.IndexOf("+") != -1 && a.IndexOf("-") != -1)
                    {
                        if (a.IndexOf("+") < a.IndexOf("-"))
                        {
                            int mid = a.IndexOf("+");
                            bool checkfir = false;
                            int findfir = mid;
                            while (checkfir == false)
                            {
                                if (findfir != 0)
                                {
                                    findfir--;
                                    if (!IsNumeric(a[findfir]) && a[findfir].ToString() != ("."))
                                    {
                                        checkfir = true;
                                    }
                                }
                                else
                                {
                                    checkfir = true;
                                }
                            }
                            bool checklas = false;
                            int findlas = mid;
                            while (checklas == false)
                            {
                                if (findlas < a.Length - 1)
                                {
                                    findlas++;
                                    if (!IsNumeric(a[findlas]) && a[findlas].ToString() != ("."))
                                    {
                                        checklas = true;
                                    }
                                }
                                else
                                {
                                    checklas = true;
                                }
                            }
                            int disfir = mid - findfir;
                            int dislas = findlas - mid;
                            string before = a.Substring(findfir, disfir);
                            string after = a.Substring(mid + 1, dislas);
                            double.TryParse(before, out double bef);
                            double.TryParse(after, out double aft);
                            double con = bef + aft;
                            int dis = findlas - findfir;
                            a = a.Remove(findfir, dis + 1);
                            a = a.Insert(findfir, con.ToString());
                            textBox1.Text = a;
                        }
                        else
                        {
                            int mid = a.IndexOf("-");
                            bool checkfir = false;
                            int findfir = mid;
                            while (checkfir == false)
                            {
                                if (findfir != 0)
                                {
                                    findfir--;
                                    if (!IsNumeric(a[findfir]) && a[findfir].ToString() != ("."))
                                    {
                                        checkfir = true;
                                    }
                                }
                                else
                                {
                                    checkfir = true;
                                }
                            }
                            bool checklas = false;
                            int findlas = mid;
                            while (checklas == false)
                            {
                                if (findlas < a.Length - 1)
                                {
                                    findlas++;
                                    if (!IsNumeric(a[findlas]) && a[findlas].ToString() != ("."))
                                    {
                                        checklas = true;
                                    }
                                }
                                else
                                {
                                    checklas = true;
                                }
                            }
                            int disfir = mid - findfir;
                            int dislas = findlas - mid;
                            string before = a.Substring(findfir, disfir);
                            string after = a.Substring(mid + 1, dislas);
                            double.TryParse(before, out double bef);
                            double.TryParse(after, out double aft);
                            double con = bef - aft;
                            int dis = findlas - findfir;
                            a = a.Remove(findfir, dis + 1);
                            a = a.Insert(findfir, con.ToString());
                            textBox1.Text = a;
                        }
                    }
                    else if (a.IndexOf("+") != -1 && a.IndexOf("-") == -1)
                    {
                        int mid = a.IndexOf("+");
                        bool checkfir = false;
                        int findfir = mid;
                        while (checkfir == false)
                        {
                            if (findfir != 0)
                            {
                                findfir--;
                                if (!IsNumeric(a[findfir]) && a[findfir].ToString() != ("."))
                                {
                                    checkfir = true;
                                }
                            }
                            else
                            {
                                checkfir = true;
                            }
                        }
                        bool checklas = false;
                        int findlas = mid;
                        while (checklas == false)
                        {
                        if (findlas < a.Length - 1)
                            {
                                    findlas++;
                                    if (!IsNumeric(a[findlas]) && a[findlas].ToString() != ("."))
                                    {
                                        checklas = true;
                                    }
                                }
                            
                            else
                            {
                                checklas = true;
                            }
                        }
                        int disfir = mid - findfir;
                        int dislas = findlas - mid;
                        string before = a.Substring(findfir, disfir);
                        string after = a.Substring(mid + 1, dislas);
                        double.TryParse(before, out double bef);
                        double.TryParse(after, out double aft);
                        double con = bef + aft;
                        int dis = findlas - findfir;
                        a = a.Remove(findfir, dis + 1);
                        a = a.Insert(findfir, con.ToString());
                        textBox1.Text = a;
                    }
                    else if (a.IndexOf("-") != -1 && a.IndexOf("+") == -1)
                    {
                        int mid = a.IndexOf("-");
                        bool checkfir = false;
                        int findfir = mid;
                        while (checkfir == false)
                        {
                            if (findfir != 0)
                            {
                                findfir--;
                                if (!IsNumeric(a[findfir]) && a[findfir].ToString() != ("."))
                                {
                                    checkfir = true;
                                }
                            }
                            else
                            {
                                checkfir = true;
                            }
                        }
                        bool checklas = false;
                        int findlas = mid;
                        while (checklas == false)
                        {
                            if (findlas < a.Length - 1)
                            {
                                findlas++;
                                if (!IsNumeric(a[findlas]) && a[findlas].ToString() != ("."))
                                {
                                    checklas = true;
                                }
                            }
                            else
                            {
                                checklas = true;
                            }
                        }
                        int disfir = mid - findfir;
                        int dislas = findlas - mid;
                        string before = a.Substring(findfir, disfir);
                        string after = a.Substring(mid + 1, dislas);
                        double.TryParse(before, out double bef);
                        double.TryParse(after, out double aft);
                        double con = bef - aft;
                        int dis = findlas - findfir;
                        a = a.Remove(findfir, dis + 1);
                        a = a.Insert(findfir, con.ToString());
                        textBox1.Text = a;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /*private bool ValidCheck(string a)
        {

        }*/
    }
}
