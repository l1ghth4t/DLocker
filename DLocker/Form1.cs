using System;

namespace DLocker
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();

            Passwd.PasswordChar = '*'; // Изначально скрываем пароль
            Passwd_2.PasswordChar = '*';
        }

        // Обработка установки и снятия флажка, отвечающего за показ пароля
        private void checkShowPasswd_CheckedChanged(object sender, EventArgs e) 
        {
            if (checkShowPasswd.Checked == true)
            {
                Passwd.PasswordChar = '\0';
                Passwd_2.PasswordChar = '\0';
            }

            else
            {
                Passwd.PasswordChar = '*';
                Passwd_2.PasswordChar = '*';
            }
        }

        private void metroButton1_Click(object sender, EventArgs e) // Обрабатываем клик по кнопке
        {
            bool OK = false;

            // Проверка корректности пароля
            if ((Passwd.Text == Passwd_2.Text) && (Passwd.Text != "")) // Пароли совпали, и пароль не пустое значение
            {
                OK = true;
            }

            if (Passwd.Text.Length < 6) // Если пароль меньше 6 символов
            {
                MetroFramework.MetroMessageBox.Show(this, "Слабый пароль. Пароль должен быть не меньше 6 символов", "Ошибка!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                OK = false;
            }

            else if (Passwd.Text.Length > 64) // Если пароль больше 64 символов
            {
                MetroFramework.MetroMessageBox.Show(this, "Слишком длинный пароль. Пароль должен быть не больше 64 символов", "Ошибка!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                OK = false;
            }

            // Смотрим, прошёл ли проверку пароль
            switch (OK)
            {
                // Если всё OK
                case true:
                    Form2 new_form = new Form2(Passwd.Text, checkBackOp.Checked);
                    new_form.Show();
                    this.Hide();
                    break;

                // Тут у нас остаётся лишь тот случай, если пароли не совпали
                case false:
                    MetroFramework.MetroMessageBox.Show(this, "Пароли не совпали", "Ошибка!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
