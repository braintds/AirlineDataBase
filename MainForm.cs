using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace AirlineDataBase
{
    public partial class MainForm : Form
    {
        AirlineDataBaseDataSet dataSet = new AirlineDataBaseDataSet();
        DataBase dataBase = new DataBase();

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            BuildMenu();
            BuildComboBoxes();
        }
        private void BuildMenu()
        {
            List<string> Methods = new List<string>();
            List<ToolStripMenuItem> menuItems = new List<ToolStripMenuItem>();

            string commandText = "SELECT * FROM Menu WHERE [Код родительского пункта] = 0 ORDER BY Порядок";

            OleDbCommand command = new OleDbCommand(commandText, dataBase.getConnection());

            dataBase.openConnection();

            OleDbDataReader Reader = command.ExecuteReader();
            while (Reader.Read())
                menuItems.Add(new ToolStripMenuItem(Reader[2].ToString()));

            Reader.Close();

            for (int i = 0; i < menuItems.Count; i++)
            {

                commandText = "SELECT * FROM Menu WHERE [Код родительского пункта] =" + (i + 1) + " ORDER BY Порядок";
                command.CommandText = commandText;
                OleDbDataReader Reader1 = command.ExecuteReader();
                while (Reader1.Read())
                {
                    ToolStripMenuItem newItem = new ToolStripMenuItem(Reader1[2].ToString());
                    string method = Reader1[3].ToString();
                    MethodInfo m = this.GetType().GetMethod(method);
                    EventHandler eh = AircraftFleet;
                    newItem.Click += (EventHandler)Delegate.CreateDelegate(eh.GetType(), this, m);
                    menuItems[i].DropDownItems.Add(newItem);
                }
                Reader1.Close();
            }
            dataBase.closeConnection();
            menuStrip.Items.AddRange(menuItems.ToArray());
        }

        private void BuildComboBoxes()
        {
            string commandText = "SELECT Название_Должности FROM Должность";
            List<string> items = new List<string>();
            dataBase.openConnection();

            OleDbCommand command = new OleDbCommand(commandText, dataBase.getConnection());

            OleDbDataReader Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                items.Add(Reader[0].ToString());
            }
            this.AddPositionComboBox.DataSource = items;


            items = new List<string>();
            commandText = "SELECT Аэропорты " +
                "FROM Аэропорт";
            command = new OleDbCommand(commandText, dataBase.getConnection());
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                items.Add(Reader[0].ToString());
            }
            Reader.Close();
            dataBase.closeConnection();
        }
        #region
        public void HideAllPanel()
        {
            this.StaffPanel.Visible = false;
            this.AircraftFleetPanel.Visible = false;
            this.PassengerPanel.Visible = false;
        }

        public void Passenger(object sender, EventArgs e)
        {
            HideAllPanel();
            this.PassengerPanel.Visible = true;
        }
        public void AircraftFleet(object sender, EventArgs e)
        {
            HideAllPanel();
            this.AircraftFleetPanel.Visible = true;
        }
        public void Staff(object sender, EventArgs e)
        {
            HideAllPanel();
            this.StaffPanel.Visible = true;
        }
        public void Content(object sender, EventArgs e)
        {
            string text = "Cодержание\nВо вкладке таблицы можно найти раздел 'Парк авиалайнеров', в этом разделе можно увидеть информацию обо всех авиалайнерах состоящих на учете компании" +
                "\nВкладка 'Сотрудники' позволяет добавлять новых и удалять старых сотрудников\n" +
                "Вкладка 'Оформленные билеты' содержит информацию о всех билетах проданных в авиакомпании";
            TextForm about = new TextForm(text);
            about.Text = "Cодержание";
            about.Show();

        }
        public void About(object sender, EventArgs e)
        {
            string text = "O программе \nКлиентское приложение для работы с базой данных 'Авиакомпания' Версия 1.0 \n" +
               "Данный программный продукт создан исключительно в образовательных целях.\n\n" +
               "Автор Савин К.М. , НГТУ, АВТ-012, 2022.";
            TextForm about = new TextForm(text);
            about.Text = "О программе";
            about.Show();

        }
        #endregion

        private void AircraftFleetButton_Click(object sender, EventArgs e)
        {
            //Парк авиалайнеров
            this.dataSet.Clear();
            string commandText = "SELECT * FROM Airliner";
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandText, this.dataBase.getConnection());
            adapter.Fill(this.dataSet, "Airliner");
            this.AircraftFleetDataGridView.DataSource = this.dataSet.Airliner;
        }

        private void StaffViewButton_Click(object sender, EventArgs e)
        {
            this.dataSet.Clear();
            string commandText = "SELECT * FROM Staff";
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandText, this.dataBase.getConnection());
            adapter.Fill(dataSet, "Staff");
            this.StaffDataGridView.DataSource = this.dataSet.Staff;
        }

        private void AddStaffInDBButton_Click(object sender, EventArgs e)
        {
            string commandText = "SELECT MAX([id]) FROM Персонал";

            OleDbCommand command = new OleDbCommand(commandText, dataBase.getConnection());
            dataBase.openConnection();
            int count = (int)command.ExecuteScalar();

            commandText = $"INSERT INTO Персонал (id, Фамилия, Имя, Отчество, Должность)" +
                $"VALUES({count + 1},'{this.AddSurnameTextBox.Text}', '{this.AddNameTextBox.Text}', '{this.AddFatherNameTextBox.Text}', " +
               $"{AddPositionComboBox.SelectedIndex + 1})";
            command = new OleDbCommand(commandText, dataBase.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Сотрудник добавлен");

            this.StaffAddPanel.Visible = false;
            dataBase.closeConnection();
        }

        private void StaffAddButton_Click(object sender, EventArgs e)
        {
            this.StaffAddPanel.Visible = true;
        }

        private void StaffViewDeleteButton_Click(object sender, EventArgs e)
        {
            this.StaffDeletePanel.Visible = true;
        }

        private void StaffDeleteButton_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            string commandText = $"DELETE FROM Персонал" +
                $" WHERE Фамилия = '{this.StaffDeleteSurnameTextBox.Text}'";
            OleDbCommand command = new OleDbCommand(commandText, dataBase.getConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Сотрудник удален");
            dataBase.closeConnection();
        }

        private void ViewPassengerButton_Click(object sender, EventArgs e)
        {
            this.dataSet.Clear();
            string commandText = "SELECT * FROM ticket";
            OleDbDataAdapter adapter = new OleDbDataAdapter(commandText, this.dataBase.getConnection());
            adapter.Fill(dataSet, "ticket");
            this.PassengerDataGridView.DataSource = this.dataSet.ticket;
        }
    }
}
