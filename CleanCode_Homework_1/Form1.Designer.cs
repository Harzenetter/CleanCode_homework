namespace CleanCode_Homework_1
{
    partial class PasswordCheckForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCheckPassword = new System.Windows.Forms.Button();
            this.textbox_Password = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.btn_CheckPassword_round2 = new System.Windows.Forms.Button();
            this.checkBox_IsAdminPassword = new System.Windows.Forms.CheckBox();
            this.button_Check_Round3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheckPassword
            // 
            this.btnCheckPassword.Location = new System.Drawing.Point(321, 27);
            this.btnCheckPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckPassword.Name = "btnCheckPassword";
            this.btnCheckPassword.Size = new System.Drawing.Size(133, 19);
            this.btnCheckPassword.TabIndex = 0;
            this.btnCheckPassword.Text = "Check Password";
            this.btnCheckPassword.UseVisualStyleBackColor = true;
            this.btnCheckPassword.Click += new System.EventHandler(this.btnCheckPassword_Click);
            // 
            // textbox_Password
            // 
            this.textbox_Password.HideSelection = false;
            this.textbox_Password.Location = new System.Drawing.Point(9, 27);
            this.textbox_Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textbox_Password.Name = "textbox_Password";
            this.textbox_Password.Size = new System.Drawing.Size(296, 20);
            this.textbox_Password.TabIndex = 1;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(9, 85);
            this.labelResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(16, 13);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "...";
            // 
            // btn_CheckPassword_round2
            // 
            this.btn_CheckPassword_round2.Location = new System.Drawing.Point(321, 63);
            this.btn_CheckPassword_round2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CheckPassword_round2.Name = "btn_CheckPassword_round2";
            this.btn_CheckPassword_round2.Size = new System.Drawing.Size(133, 19);
            this.btn_CheckPassword_round2.TabIndex = 3;
            this.btn_CheckPassword_round2.Text = "Check - Round 2";
            this.btn_CheckPassword_round2.UseVisualStyleBackColor = true;
            this.btn_CheckPassword_round2.Click += new System.EventHandler(this.btn_CheckPassword_round2_Click);
            // 
            // checkBox_IsAdminPassword
            // 
            this.checkBox_IsAdminPassword.AutoSize = true;
            this.checkBox_IsAdminPassword.Location = new System.Drawing.Point(9, 50);
            this.checkBox_IsAdminPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_IsAdminPassword.Name = "checkBox_IsAdminPassword";
            this.checkBox_IsAdminPassword.Size = new System.Drawing.Size(115, 17);
            this.checkBox_IsAdminPassword.TabIndex = 4;
            this.checkBox_IsAdminPassword.Text = "Is Admin Password";
            this.checkBox_IsAdminPassword.UseVisualStyleBackColor = true;
            // 
            // button_Check_Round3
            // 
            this.button_Check_Round3.Location = new System.Drawing.Point(321, 101);
            this.button_Check_Round3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Check_Round3.Name = "button_Check_Round3";
            this.button_Check_Round3.Size = new System.Drawing.Size(133, 19);
            this.button_Check_Round3.TabIndex = 5;
            this.button_Check_Round3.Text = "Check - Round 3";
            this.button_Check_Round3.UseVisualStyleBackColor = true;
            this.button_Check_Round3.Click += new System.EventHandler(this.button_Check_Round3_Click);
            // 
            // PasswordCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 189);
            this.Controls.Add(this.button_Check_Round3);
            this.Controls.Add(this.checkBox_IsAdminPassword);
            this.Controls.Add(this.btn_CheckPassword_round2);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textbox_Password);
            this.Controls.Add(this.btnCheckPassword);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PasswordCheckForm";
            this.Text = "PasswordStrengthChecker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckPassword;
        private System.Windows.Forms.TextBox textbox_Password;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button btn_CheckPassword_round2;
        private System.Windows.Forms.CheckBox checkBox_IsAdminPassword;
        private System.Windows.Forms.Button button_Check_Round3;
    }
}

