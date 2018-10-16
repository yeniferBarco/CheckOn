using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CheckOn
{
    class ConeccionDB
    {
        public MySqlDataAdapter insercion = new MySqlDataAdapter();
        SqlConnection Cm;
        
        public void Coneccion()
        {
            try
            {
                Cm = new SqlConnection("server=localhost; database=check - on; Uid=root; Pwd =; SslMode=none;");
                Cm.Open();
                MessageBox.Show("conectado");
            }

            catch(Exception ex)
            {
                MessageBox.Show("algo fallo");
            }
            
        }

    }
}
