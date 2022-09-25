using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOOCoocker
{
    /// <summary>
    /// Форма авторизации
    /// </summary>
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pattern_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, 255, 255);
            tableLayoutPanelUp.BackColor = Color.FromArgb(255, 204, 151);
            panelDown.BackColor = Color.FromArgb(255, 204, 151);

            string connectionString = Helper.ConnectionStringBuild("DESKTOP-OLHVHM0\\SQLEXPRESS", "Trade_sidorov493", true, false, "", "");

            Helper.Connection = new SqlConnection(connectionString);
            SqlConnection connection = Helper.Connection;
            try
            {
                if (connection.State == ConnectionState.Closed)
                    Helper.Connection.Open();
                MessageBox.Show("Вы успешно подключились к базе данных", "Подключение к Базе данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось подключиться к базе данных", "Ошибка подключение к Базе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
        }

        /// <summary>
        /// Нажатие на кнопку закрытия окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Autorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (Helper.ConnectionState == ConnectionState.Open)
                    Helper.Connection.Close();
            }
            catch
            {

            }
        }

        /// <summary>
        /// Изменение состояния флажка "показывать пароль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !(sender as CheckBox).Checked;
        }

        /// <summary>
        /// Нажатие на кнопку входа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string buttonText = (sender as Button).Text;
            bool successfully = true;

            if (buttonText == buttonGouest.Text)
                Helper.RoleName = (Role)0;
            else
            {
                string login = textBoxLogin.Text;
                string password = textBoxPassword.Text;
                SqlCommand selectUser = new SqlCommand("Select * From [User] Where UserLogin = @login and UserPassword = @password", Helper.Connection);
                selectUser.Parameters.Clear();
                selectUser.Parameters.AddWithValue("@login", login);
                selectUser.Parameters.AddWithValue("@password", password);

                try
                {
                    SqlDataReader dataReader = selectUser.ExecuteReader();
                    if(dataReader.HasRows)
                    {
                        dataReader.Read();
                        Helper.IDUser = dataReader.GetInt32(dataReader.GetOrdinal("UserID"));
                        Helper.RoleName = (Role)dataReader.GetInt32(dataReader.GetOrdinal("UserRole"));
                        Helper.UserSurName = dataReader.GetString(dataReader.GetOrdinal("UserSurname"));
                        Helper.UserName = dataReader.GetString(dataReader.GetOrdinal("UserName"));
                        Helper.UserPatronymic = dataReader.GetString(dataReader.GetOrdinal("UserPatronymic"));
                        dataReader.Close();
                    }
                    else
                    {
                        dataReader.Close();
                        throw new Exception("Отсутствует запись с соотвествующими параметрами");
                    }

                }
                catch(Exception ex)
                {
                    successfully = false;
                }


            }
            

            if(successfully)
            {
                bool isGouest = Helper.RoleName == (Role)0;
                string messageTextStart = $"Вы успешно зашли", messageTextMiddle = "", messageTextEnd = (isGouest ? "под ролью" : "с ролью") + $" {Helper.RoleName}";

                if (!isGouest)
                    messageTextMiddle = Helper.FIO;

                string messageText = string.Join(" ", messageTextStart, messageTextMiddle, messageTextEnd);
                messageText = string.Join(" ", messageText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                MessageBox.Show(messageText, "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Неверный логин или пароль", "Ошибка авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
