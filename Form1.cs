// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Главное окно прилжения.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Lab3Tabs
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Главное окно прилжения.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
            this.buttonExit.Location = this.buttonEnter.Location;
            this.buttonExit.Hide();
            this.erroMsg.Location = label4.Location;
        }

        private void TabControl1Click(object sender, EventArgs e)
        {
            this.Login.SelectedIndex = 0;
            MessageBox.Show(
                "Ошибка доступа.",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
        }

        private void LoginButtonClick(object sender, EventArgs e)
        {
            var idx = this.listBox1.FindString(this.loginBox.Text);
            if (idx < 0)
            {
                this.Logout();
                this.loginBox.Focus();
                this.erroMsg.Show();
                return;
            }

            var loginData = this.listBox1.Items[idx].ToString().Split("/".ToCharArray(), 3);
            var expirationDate = DateTime.Parse(loginData[2]);
            if (this.loginBox.Text == loginData[0] && // Имя пользователя.
                // Пароль.
                this.passwordBox.Text == loginData[1] &&
                // Дата истечения пароля.
                expirationDate > DateTime.Today) 
            {
                this.erroMsg.Hide();
                this.buttonEnter.Hide();
                this.buttonExit.Show();
                if (loginData[1] == "admin")
                {
                    this.buttonPasswords.Show();
                }
                else
                {
                    this.Login.SelectedIndex = 1;
                }
            }
            else
            {
                this.Logout();
                this.loginBox.Focus();
                this.erroMsg.Show();
            }

        }

        private void ShowPasswords(object sender, EventArgs e)
        {
            this.listBox1.Show();
            this.label4.Show();
        }

        private void Logout(object sender = null, EventArgs e = null)
        {
            this.listBox1.Hide();
            this.label4.Hide();
            this.buttonPasswords.Hide();
            this.buttonExit.Hide();
            this.buttonEnter.Show();
            this.loginBox.Text = string.Empty;
            this.passwordBox.Text = string.Empty;
        }
    }
}
