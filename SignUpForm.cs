using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AirlineDataBase
{
    public partial class SignUpForm : Form
    {
        DataBase dataBase = new DataBase();
        public SignUpForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            PasswordTextBox.PasswordChar = '*';
            LoginTextBox.MaxLength = 50;
            PasswordTextBox.MaxLength = 50;
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            var login = this.LoginTextBox.Text;
            var password = this.PasswordTextBox.Text;

            string queryString = "insert into Users(Логин, Пароль) values( '" + login + "' , '" + password + "');";

            OleDbCommand command = new OleDbCommand(queryString, dataBase.getConnection());


            dataBase.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан", "Вы зарегистрированы!");
                LogInForm logInForm = new LogInForm();
                this.Close();
                logInForm.ShowDialog();
            }
            else
                MessageBox.Show("Ошибка", "Ошибка при регистрации!");
            dataBase.closeConnection();
        }
    }
}
