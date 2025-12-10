namespace PasswordChecker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ProgressBar strengthBar;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ListBox lstTips;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label titleLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.strengthBar = new System.Windows.Forms.ProgressBar();
            this.lblResult = new System.Windows.Forms.Label();
            this.lstTips = new System.Windows.Forms.ListBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.panelTop.Controls.Add(this.titleLabel);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(400, 60);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(20, 15);
            this.titleLabel.Size = new System.Drawing.Size(360, 32);
            this.titleLabel.Text = "Проверка надёжности пароля";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(30, 80);
            this.label1.Text = "Введите пароль:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(30, 105);
            this.txtPassword.Size = new System.Drawing.Size(340, 25);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // strengthBar
            // 
            this.strengthBar.Location = new System.Drawing.Point(30, 145);
            this.strengthBar.Size = new System.Drawing.Size(340, 25);
            this.strengthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(30, 180);
            this.lblResult.Size = new System.Drawing.Size(340, 23);
            this.lblResult.Text = "Надёжность: -";
            // 
            // lstTips
            // 
            this.lstTips.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstTips.ItemHeight = 15;
            this.lstTips.Location = new System.Drawing.Point(30, 210);
            this.lstTips.Size = new System.Drawing.Size(340, 154);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(400, 390);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.strengthBar);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lstTips);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Password Checker";
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
