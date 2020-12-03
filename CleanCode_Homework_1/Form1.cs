using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanCode_Homework_1
{
    public partial class PasswordCheckForm : Form
    {
        public PasswordCheckForm()
        {
            InitializeComponent();
        }

        private void btnCheckPassword_Click(object sender, EventArgs e)
        {
            var passwordChecker = new PasswordChecker();
            var isPasswordSafe = passwordChecker.isPasswordSafeEnough(textbox_Password.Text);
            if (isPasswordSafe)
            {
                labelResult.Text = "Password is safe enough!";
            }
            else
            {
                labelResult.Text = "Password is NOT safe enough!";
            }
            labelResult.Update();
        }

        private void btn_CheckPassword_round2_Click(object sender, EventArgs e)
        {
            var passwordChecker = new PasswordChecker_Round2();
            var isPasswordSafe = passwordChecker.isPasswordSafeEnough(textbox_Password.Text, checkBox_IsAdminPassword.Checked);
            if (isPasswordSafe)
            {
                labelResult.Text = "Password is safe enough!";
            }
            else
            {
                labelResult.Text = "Password is NOT safe enough!";
            }

        }

        private void button_Check_Round3_Click(object sender, EventArgs e)
        {
            var passwordChecker = new PasswordChecker_Round3();
            var missingCoditions = passwordChecker.GetMissingSafetyConditions(textbox_Password.Text, checkBox_IsAdminPassword.Checked);
            if (missingCoditions.Count > 0)
            {
                labelResult.Text = String.Join(Environment.NewLine,missingCoditions);
                
            }
            else
            {
                labelResult.Text = "Password is safe enough!";
                
            }
        }
    }
}
