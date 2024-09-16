using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    internal static class CD_Conexion
    {
        static OleDbConnection CN = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|BaseDeDatos.accdb");

        public static DataTable EjecutarConsulta(string sql, object[] parametros = null)
        {
            DataTable dt = new DataTable();

            using (OleDbCommand command = new OleDbCommand(sql, CN))
            {
                if (parametros != null)
                {
                    for (int i = 0; i < parametros.Length; i++)
                    {
                        command.Parameters.AddWithValue("Parametro" + i, parametros[i]);
                    }
                }

                using (OleDbDataAdapter da = new OleDbDataAdapter(command)) da.Fill(dt);
            }
            return dt;
        }
    }
}
