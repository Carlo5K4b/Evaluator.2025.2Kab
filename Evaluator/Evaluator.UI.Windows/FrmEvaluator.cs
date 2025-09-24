using Evaluator.Core;
using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Evaluator.UI.Windows
{
    public partial class FrmEvaluator : Form
    {
        public FrmEvaluator()
        {
            InitializeComponent();
        }

        private void FrmEvaluator_Load(object sender, EventArgs e)
        {
        }

        private void btn_Number7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btn_Result_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += $"={ExpressionEvaluator.Evaluate(txtDisplay.Text)}";

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }

        private void btn_Number8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btn_Number9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void btn_Number4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void btn_Number5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btn_Number6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btn_Number1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void btn_Number2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void btn_Number3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btn_Number0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void btn_spot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "*";
        }

        private void btn_Split_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "/";
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Length > 0 ? txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1) : "";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "+";
        }

        private void btn_Subtraction_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "-";
        }

        private void btn_LeftPthesis_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "(";   
        }

        private void tbtn_RighPthesis_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ")";
        }

        private void btn_Pow_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "^";
        }
    }

}
    

