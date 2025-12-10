using System.Text.RegularExpressions;

namespace PasswordChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            strengthBar.Maximum = 100;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            CheckPassword(txtPassword.Text);
        }

        private void CheckPassword(string password)
        {
            lstTips.Items.Clear();
            int score = 0;
            if (password.Length >= 8) score += 25;
            else lstTips.Items.Add("Пароль должен быть длиной не менее 8 символов.");
            if (Regex.IsMatch(password, "[a-z]")) score += 10;
            else lstTips.Items.Add("Добавьте строчные буквы (a-z).");
            if (Regex.IsMatch(password, "[A-Z]")) score += 10;
            else lstTips.Items.Add("Добавьте заглавные буквы (A-Z).");
            if (Regex.IsMatch(password, "[0-9]")) score += 15;
            else lstTips.Items.Add("Добавьте цифры (0-9).");
            if (Regex.IsMatch(password, "[^a-zA-Z0-9]")) score += 20;
            else lstTips.Items.Add("Добавьте специальные символы (!@#$% и др.).");
            if (password.Distinct().Count() >= password.Length / 2) score += 20;
            else lstTips.Items.Add("Используйте больше разных символов.");

            strengthBar.Value = score;

            if (score < 30)
                lblResult.Text = "Надёжность: Очень слабый";
            else if (score < 60)
                lblResult.Text = "Надёжность: Слабый";
            else if (score < 80)
                lblResult.Text = "Надёжность: Хороший";
            else
                lblResult.Text = "Надёжность: Очень хороший";
        }
    }
}
