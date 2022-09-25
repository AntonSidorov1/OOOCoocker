using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;


namespace OOOCoocker
{
    public static class Helper
    {
        /// <summary>
        /// Сервер с базой данных
        /// </summary>
        static string dataSource = "";
        /// <summary>
        /// Сервер с базой данных
        /// </summary>
        public static string DataSource {get => dataSource; set => dataSource = value; }

        /// <summary>
        /// база данных
        /// </summary>
        static string initialCatalog = "";
        /// <summary>
        /// база данных
        /// </summary>
        public static string InitialCatalog { get => initialCatalog; set => initialCatalog = value; }

        /// <summary>
        /// Пользователь
        /// </summary>
        static string userID = "";
        /// <summary>
        /// Пользователь
        /// </summary>
        public static string UserID { get => userID; set => userID = value; }

        /// <summary>
        /// Пароль
        /// </summary>
        static string password = "";
        /// <summary>
        /// Пароль
        /// </summary>
        public static string Password { get => password; set => password = value; }

        /// <summary>
        /// Защищённость соединения
        /// </summary>
        static bool integratedSecurity = false;
        /// <summary>
        /// Защищённость соединения
        /// </summary>
        public static bool IntegratedSecurity { get => integratedSecurity; set => integratedSecurity = value; }

        /// <summary>
        /// Сохранять пароль в строке подключения
        /// </summary>
        static bool persistSecurityInfo = false;
        /// <summary>
        /// Сохранять пароль в строке подключения
        /// </summary>
        public static bool PersistSecurityInfo { get => persistSecurityInfo; set => persistSecurityInfo = value; }

        /// <summary>
        /// Строка подключения. Вариант 1
        /// </summary>
        public static string ConnectionString1
        {
            get
            {
                
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder["Data Source"] = DataSource;
                builder["Initial Catalog"] = InitialCatalog;
                builder["User ID"] = UserID;
                builder["Password"] = Password;
                builder["Integrated Security"] = IntegratedSecurity;
                builder["Persist Security Info"] = PersistSecurityInfo;
                return builder.ConnectionString;
            }
            set
            {
                string connectionString = value;
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
                DataSource = Convert.ToString(builder["Data Source"]);
                InitialCatalog = Convert.ToString(builder["Initial Catalog"]);
                UserID = Convert.ToString(builder["User ID"]);
                Password = Convert.ToString(builder["Password"]);
                IntegratedSecurity = Convert.ToBoolean(builder["Integrated Security"]);
                PersistSecurityInfo = Convert.ToBoolean(builder["Persist Security Info"]);
            }
        }

        /// <summary>
        /// Строка подключения. Вариант 2
        /// </summary>
        public static string ConnectionString
        {
            get
            {

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = DataSource;
                builder.InitialCatalog = InitialCatalog;
                builder.UserID = UserID;
                builder.Password = Password;
                builder.IntegratedSecurity = IntegratedSecurity;
                builder.PersistSecurityInfo = PersistSecurityInfo;
                return builder.ConnectionString;
            }
            set
            {
                string connectionString = value;
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
                DataSource = builder.DataSource;
                InitialCatalog = builder.InitialCatalog;
                UserID = builder.UserID;
                Password = builder.Password;
                IntegratedSecurity = builder.IntegratedSecurity;
                PersistSecurityInfo = builder.PersistSecurityInfo;


            }
        }

        /// <summary>
        /// Соединение с базой данных
        /// </summary>
        static SqlConnection connection;

        /// <summary>
        /// Соединение с базой данных
        /// </summary>
        public static SqlConnection Connection { get => connection; set => connection = value; }

        /// <summary>
        /// Состояние подключения к базе данных
        /// </summary>
        public static ConnectionState ConnectionState => Connection.State;

        /// <summary>
        /// Создаёт и возвращает строку подключения
        /// </summary>
        /// <param name="dataSource"></param>
        /// <param name="initialCatalog"></param>
        /// <param name="integratedSecurity"></param>
        /// <param name="persistSecurityInfo"></param>
        /// <param name="userID"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string ConnectionStringBuild(string dataSource, string initialCatalog, bool integratedSecurity, bool persistSecurityInfo, string userID, string password)
        {
            DataSource = dataSource;
            InitialCatalog = initialCatalog;
            IntegratedSecurity = integratedSecurity;
            PersistSecurityInfo = persistSecurityInfo;
            UserID = userID;
            Password = password;
            return ConnectionString;
        }

        /// <summary>
        /// Роль
        /// </summary>
        static Role roleName;
        
        /// <summary>
        /// Роль
        /// </summary>
        public static Role RoleName { get => roleName; set => roleName = value; }

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        static string userSurName = "";
        /// <summary>
        /// Имя пользователя
        /// </summary>
        static string userName = "";
        /// <summary>
        /// Отчество пользователя
        /// </summary>
        static string userPatronymic = "";

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public static string UserSurName { get => userSurName; set => userSurName = value; }
        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        public static string UserName { get => userName; set => userName = value; }
        /// <summary>
        /// Отчество пользователя
        /// </summary>
        public static string UserPatronymic { get => userPatronymic; set => userPatronymic = value; }

        public static string FIO { get => string.Join(" ", UserSurName, UserName, UserPatronymic).Trim(' '); 
            set
            {
                try
                {
                    string[] partsFIO = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    UserSurName = partsFIO[0];
                    UserName = partsFIO[1];
                    try
                    {
                        userPatronymic = partsFIO[2];
                    }
                    catch
                    {
                        UserPatronymic = "";
                    }
                }
                catch
                {
                    UserName = "";
                    UserSurName = "";
                    UserPatronymic = "";
                }

            }
        }

        /// <summary>
        /// ID пользователя системы
        /// </summary>
        static int iDUser;
        /// <summary>
        /// ID пользователя системы
        /// </summary>
        public static int IDUser { get => iDUser; set => iDUser = value; }
    }

    /// <summary>
    /// Роль
    /// </summary>
    public enum Role
    {
        Гость = 0,
        Клиент = 1,
        Менеджер = 2,
        Администратор = 3
    }
}
