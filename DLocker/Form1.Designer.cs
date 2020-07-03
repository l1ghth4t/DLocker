namespace DLocker
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Passwd = new MetroFramework.Controls.MetroTextBox();
            this.checkShowPasswd = new MetroFramework.Controls.MetroCheckBox();
            this.checkBackOp = new MetroFramework.Controls.MetroCheckBox();
            this.Passwd_2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(311, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Введите ключевую фразу для разблокировки:";
            // 
            // Passwd
            // 
            // 
            // 
            // 
            this.Passwd.CustomButton.Image = null;
            this.Passwd.CustomButton.Location = new System.Drawing.Point(500, 1);
            this.Passwd.CustomButton.Name = "";
            this.Passwd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Passwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Passwd.CustomButton.TabIndex = 1;
            this.Passwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Passwd.CustomButton.UseSelectable = true;
            this.Passwd.CustomButton.Visible = false;
            this.Passwd.Lines = new string[0];
            this.Passwd.Location = new System.Drawing.Point(23, 107);
            this.Passwd.MaxLength = 32767;
            this.Passwd.Name = "Passwd";
            this.Passwd.PasswordChar = '\0';
            this.Passwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Passwd.SelectedText = "";
            this.Passwd.SelectionLength = 0;
            this.Passwd.SelectionStart = 0;
            this.Passwd.ShortcutsEnabled = true;
            this.Passwd.Size = new System.Drawing.Size(369, 23);
            this.Passwd.TabIndex = 1;
            this.Passwd.UseSelectable = true;
            this.Passwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Passwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // checkShowPasswd
            // 
            this.checkShowPasswd.AutoSize = true;
            this.checkShowPasswd.Location = new System.Drawing.Point(23, 222);
            this.checkShowPasswd.Name = "checkShowPasswd";
            this.checkShowPasswd.Size = new System.Drawing.Size(127, 17);
            this.checkShowPasswd.TabIndex = 2;
            this.checkShowPasswd.Text = "Показать пароль";
            this.checkShowPasswd.UseSelectable = true;
            this.checkShowPasswd.CheckedChanged += new System.EventHandler(this.checkShowPasswd_CheckedChanged);
            // 
            // checkBackOp
            // 
            this.checkBackOp.AutoSize = true;
            this.checkBackOp.Location = new System.Drawing.Point(226, 222);
            this.checkBackOp.Name = "checkBackOp";
            this.checkBackOp.Size = new System.Drawing.Size(128, 17);
            this.checkBackOp.TabIndex = 3;
            this.checkBackOp.Text = "Прозрачный фон";
            this.checkBackOp.UseSelectable = true;
            // 
            // Passwd_2
            // 
            // 
            // 
            // 
            this.Passwd_2.CustomButton.Image = null;
            this.Passwd_2.CustomButton.Location = new System.Drawing.Point(500, 1);
            this.Passwd_2.CustomButton.Name = "";
            this.Passwd_2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Passwd_2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Passwd_2.CustomButton.TabIndex = 1;
            this.Passwd_2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Passwd_2.CustomButton.UseSelectable = true;
            this.Passwd_2.CustomButton.Visible = false;
            this.Passwd_2.Lines = new string[0];
            this.Passwd_2.Location = new System.Drawing.Point(23, 179);
            this.Passwd_2.MaxLength = 32767;
            this.Passwd_2.Name = "Passwd_2";
            this.Passwd_2.PasswordChar = '\0';
            this.Passwd_2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Passwd_2.SelectedText = "";
            this.Passwd_2.SelectionLength = 0;
            this.Passwd_2.SelectionStart = 0;
            this.Passwd_2.ShortcutsEnabled = true;
            this.Passwd_2.Size = new System.Drawing.Size(369, 23);
            this.Passwd_2.TabIndex = 5;
            this.Passwd_2.UseSelectable = true;
            this.Passwd_2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Passwd_2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 146);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(97, 20);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Подтвердите:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 275);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(369, 35);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Заблокировать рабочий стол";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 333);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.Passwd_2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.checkBackOp);
            this.Controls.Add(this.checkShowPasswd);
            this.Controls.Add(this.Passwd);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "DLocker : config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox Passwd;
        private MetroFramework.Controls.MetroCheckBox checkShowPasswd;
        private MetroFramework.Controls.MetroCheckBox checkBackOp;
        private MetroFramework.Controls.MetroTextBox Passwd_2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

