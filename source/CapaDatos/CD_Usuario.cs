using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public int? Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Nivel { get; set; }



        private static CD_Usuario[] MapDataTableToObject(DataTable dt)
        {
            List<CD_Usuario> records = new List<CD_Usuario>();
            foreach (DataRow item in dt.Rows)
            {
                CD_Usuario usr = new CD_Usuario();
                usr.Id = int.Parse(item["Id"].ToString());
                usr.NombreCompleto = item["NombreCompleto"].ToString();
                usr.Usuario = item["Usuario"].ToString();
                usr.Contrasena = item["Contrasena"].ToString();
                usr.Nivel = item["Nivel"].ToString();
                records.Add(usr);
            }
            dt.Dispose();
            return records.ToArray();
        }

        public static CD_Usuario[] Select()
        {
            return MapDataTableToObject(CD_Conexion.EjecutarConsulta("SELECT Id, NombreCompleto, Usuario, Nivel, Contrasena FROM Usuarios"));
        }
        public static CD_Usuario[] SelectBy(string usuario)
        {
            object[] arr = { usuario };
            string sql = "SELECT Id, NombreCompleto, Usuario, Nivel, Contrasena FROM Usuarios";
            if (usuario.Contains("%"))
            {
                sql += " WHERE Usuario LIKE ?"; // user search
            } else
            {
                sql += " WHERE Usuario = ?"; // code search
            }

            return MapDataTableToObject(CD_Conexion.EjecutarConsulta(sql, arr));
        }
        public static void Insert(CD_Usuario usuario)
        {
            object[] arr = { usuario.NombreCompleto, usuario.Usuario, usuario.Contrasena, usuario.Nivel };
            CD_Conexion.EjecutarConsulta("INSERT INTO [Usuarios](NombreCompleto, Usuario, Contrasena, Nivel) VALUES (?,?,?,?)", arr);
        }
        public static void Update(CD_Usuario usuario)
        {
            if (usuario.Contrasena != null)
            {
                object[] arr = { usuario.NombreCompleto, usuario.Usuario, usuario.Contrasena, usuario.Nivel, usuario.Id };
                CD_Conexion.EjecutarConsulta("UPDATE [Usuarios] SET NombreCompleto = ?, Usuario = ?, Contrasena = ?, Nivel = ? WHERE Id = ?", arr);
            } else
            {
                object[] arr = { usuario.NombreCompleto, usuario.Usuario, usuario.Nivel, usuario.Id };
                CD_Conexion.EjecutarConsulta("UPDATE [Usuarios] SET NombreCompleto = ?, Usuario = ?, Nivel = ? WHERE Id = ?", arr);
            }
        }
        public static void Upsert(CD_Usuario usuario)
        {
            if (usuario.Id == null)
            {
                CD_Usuario.Insert(usuario);
            }
            else
            {
                CD_Usuario.Update(usuario);
            }
        }
        public static void Delete(CD_Usuario usuario)
        {
            object[] arr = { usuario.Id };
            CD_Conexion.EjecutarConsulta("DELETE FROM [Usuarios] WHERE Id = ?", arr);
        }
    }
}
