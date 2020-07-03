using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DLocker
{
    public partial class Form2 : Form
    {
        /* Конструктор формы. 
         * На вход принимает пароль и булевское значение,
         * отвечающее за то, делать ли прозрачным фон
         */
        public Form2 (string InpPasswd, bool Transparent)
        {
            InitializeComponent();

            trPasswd = InpPasswd;

            this.ShowInTaskbar = true;
            this.FormBorderStyle = FormBorderStyle.None;

            // Делаем прозрачным фон, если это нужно
            if (Transparent == true)
            {
                this.BackgroundImage = null;
                this.AllowTransparency = true;
                this.BackColor = Color.FromArgb(0xff, 0xff, 0xff);
                this.TransparencyKey = this.BackColor;
            }
        }

        // Обработка изменения флажка
        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked)
                Passwd.PasswordChar = '\0';
            else
                Passwd.PasswordChar = '*';
        }

        // Кнопка "Ввести"
        private void metroButton1_Click(object sender, EventArgs e)
        {
            // Пароль правильный - закрываем программу
            if (Passwd.Text == trPasswd)
            {
                Correct = true; // Не забыв отключить запрет на зыкрытие
                Application.Exit();
            }

            // Если пароль неверный
            else
            {
                timer2.Stop();
                MetroFramework.MetroMessageBox.Show(this, "Неверный пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer2.Start();
            }
        }

        // Запрет на закрытие
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Correct)
            {
                timer2.Stop();
                MetroFramework.MetroMessageBox.Show(this, "Обнаружена попытка несанкционированного закрытия!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                timer2.Start();
            }
        }

        // Если пользователь забыл пароль - перезагружаем пароль
        private void metroLink1_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Ваш компьютер будет перезагружен", "Внимание!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            timer2.Start();
            
            if (result == DialogResult.OK)
            {
                Process.Start("shutdown", "/r /t 0");
            }
        }

        // Не даём уснуть компьютеру
        private void timer1_Tick(object sender, EventArgs e)
        {
            KeepAlive();
        }

        // Сама функция, не дающая компьютеру уснуть
        private static void KeepAlive()
        {
            Win32.SetThreadExecutionState(
                Win32.EXECUTION_STATE.ES_DISPLAY_REQUIRED |
                Win32.EXECUTION_STATE.ES_SYSTEM_REQUIRED);
        }

        // Не даём свернуть программу
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Activate();
        }

        // Поле, хранящее правильный пароль
        private string trPasswd;

        // Поле, содержащее разрешение/запрет на закрытие программы
        private bool Correct = false;
    }

    // Класс WIN API, с помощью которого не даём перейти компьютеру перейти в спящий режим
    static class Win32
    {
        [FlagsAttribute]
        public enum EXECUTION_STATE : uint
        {
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED = 0x00000001
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);
    }
}
