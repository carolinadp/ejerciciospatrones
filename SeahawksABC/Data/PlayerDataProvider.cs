using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Data
{
    public class PlayerDataProvider
    {
        public async Task<bool> SavePlayer(Player player, string pcId)
        {
            string server = "localhost";
            string database = "seahawks";
            string uid = "root";
            string password = "1234";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + 
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);
            bool couldSave = false;
            try
            {
                await connection.OpenAsync();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `seahawks`.`player` (`name`, `lastname`, `number`, `college`, `position`, `age`, `pcid`) VALUES ('" + player.Name + "', '"
                    +player.LastName + "', '" + player.Number + "', '" + player.College + "', '" +player.Position + "', '" + player.Age + "', '" + pcId + "');", connection);
                int result = await cmd.ExecuteNonQueryAsync();
                if (result > 0)
                {
                    couldSave = true;
                }
            }
            catch (DbException ex)
            {
                // loggear error de manera mas especifica
                couldSave = false;
            }
            catch (Exception ex)
            {
                // loggear error
                couldSave = false;
            }
            finally
            {
                connection.Close();
            }

            return couldSave;
            
        }
    }
}
