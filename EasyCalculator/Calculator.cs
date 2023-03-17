using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCalculator
{
    public partial class Calculator : Form
    {
        bool status = false;
        double conclusion = 0;
        string processVariable = "";
        public Calculator()
        {
            InitializeComponent();
            //btn_kok.Text = "\u221b";
            //btn_kare.Text = "x\u02e3";
        }

        private void numberButtons(object sender, EventArgs e)
        {
            if (tb_process.Text == "0" || status)
            {
                tb_process.Clear();
            }
            status = false;
            Button btn = (Button)sender;
            tb_process.Text += btn.Text;
        }

        private void processButtons(object sender, EventArgs e)
        {
            status = true;
            Button btn = (Button)sender;
            string conclusionArea = btn.Text;
            tb_conclusion.Text = tb_process.Text + " " + tb_conclusion.Text + " " + conclusionArea;
            switch (processVariable)
            {
                case "+": tb_conclusion.Text = (conclusion + Double.Parse(tb_conclusion.Text)).ToString(); break;
                case "-": tb_conclusion.Text = (conclusion - Double.Parse(tb_conclusion.Text)).ToString(); break;
                case "*": tb_conclusion.Text = (conclusion * Double.Parse(tb_conclusion.Text)).ToString(); break;
                case "/": tb_conclusion.Text = (conclusion / Double.Parse(tb_conclusion.Text)).ToString(); break;
            }
            conclusion = Double.Parse(tb_conclusion.Text);
            tb_conclusion.Text = conclusion.ToString();
            processVariable = conclusionArea;
        }
    }
}
