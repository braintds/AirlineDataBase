using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;


namespace AirlineDataBase
{
    public partial class LogInForm : Form
    {
        DataBase dataBase = new DataBase();
        public LogInForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataBase.openConnection();
            if (dataBase.getConnection().State == ConnectionState.Open)
            {
                MessageBox.Show("Подключено");
            }
            PasswordTextBox.PasswordChar = '*';
            LoginTextBox.MaxLength = 50;
            PasswordTextBox.MaxLength = 50;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var login = this.LoginTextBox.Text;
            var password = this.PasswordTextBox.Text;

            dataBase.openConnection();
            OleDbDataAdapter adapter = new OleDbDataAdapter();

            DataTable table = new DataTable();
            string queryString = $"select * from Users where [Логин] ='{login}'and [Пароль]='{password}'";
            OleDbCommand command = new OleDbCommand(queryString, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Подключено успешно", "успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                MainForm mainForm = new MainForm();

                this.Hide();
                mainForm.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Ошибка", "Подключение не удалось", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dataBase.closeConnection();
        }

        private void RegistrationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }
    }

}
