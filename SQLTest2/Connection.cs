using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SQLTest2
{
    class Connection
    {
        MainWindow mainWindow = new MainWindow();
        SqlConnection myConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Waffl\\Desktop\\C#\\SQL\\SQLTest2\\SQLTest2\\Database1.mdf;Integrated Security=True");
        SqlDataAdapter commands = new SqlDataAdapter();


        /*
        public void UpdateUser(string user)
        {
            user = mainWindow.userBox.Text;
        }
        public void UpdatePass(string pass)
        {
            pass = mainWindow.passwordBox.Text;
        }
            MainWindow mW = new MainWindow();
            var user = mW.userBox.Text.ToString();
            var pass = mW.passwordBox.Text.ToString();
            */
            
           

        public void InsertData()
        {
            MainWindow mainWindow = new MainWindow();
            commands.InsertCommand = new SqlCommand("INSERT INTO Accounts (Username, Password) VALUES(@userName, @password)", myConnection);
          //  commands.InsertCommand.Parameters.Add("@userName", SqlDbType.VarChar).Value = ;
          //  commands.InsertCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = UpdatePass(pass);

            myConnection.Open();
            try
            {
                commands.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted!");
            }
            catch
            {
                //MessageBox.Show("Error!");
            }
            myConnection.Close();

        }
    }


}
