using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public static class CL_Login
    {
        public static CD_Usuario CurrentUser = null;


        private static void _ValidateEmail(string email)
        {
            if (email.Length == 0) throw new Exception("No se ingresó ningun email.");

            if (!email.Contains("@")) throw new Exception("No se ingresó el arroba (@).");

            string[] emailParts = email.Split("@"[0]);

            if (emailParts[0].Length <= 0) throw new Exception("No se ingresó un usuario de email válido.");

            string emailDomain = emailParts[1];
            if (emailDomain.Length <= 1) throw new Exception("No se ingresó un dominio válido.");
            if (!emailDomain.Contains(".")) throw new Exception("No se ingresó un dominio válido.");

        }
        private static void _ValidateUserFormat(string user)
        {
            user.Trim();
            if (user.Length == 0)
            {
                throw new Exception("Debe ingresar un usuario.");
            }

            try
            {
                _ValidateEmail(user);

                if (user.Contains("%"))
                {
                    throw new Exception("No puede contener %.");
                }

                if (user.Length < 4)
                {
                    throw new Exception("No debe ser menor a 4 caracteres.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("El usuario debe ser un email válido.\n" + ex.Message);
            }
        }
        private static void _ValidatePasswordFormat(string password)
        {
            if (password.Length == 0)
            {
                throw new Exception("Debe ingresar una contraseña.");
            }
            if (password.Length < 4)
            {
                throw new Exception("Debe ingresar una contraseña válida.");
            }
        }
        private static void _ValidateUsernameFormat(string username)
        {
            if (username.Length == 0)
            {
                throw new Exception("Debe ingresar un nombre.");
            }
            if (username.Length < 4)
            {
                throw new Exception("Debe ingresar un nombre válido.");
            }
        }
        private static void _ValidatePasswordChange(string password1, string password2)
        {
            _ValidatePasswordFormat(password1);
            if (password2.Length == 0)
            {
                throw new Exception("Debe confirmar su contraseña.");
            }
            if (password1 != password2)
            {
                throw new Exception("Las contraseñas no son iguales.");
            }
        }
        private static void _ValidateNivel(string nivel)
        {
            if (nivel == null)
            {
                throw new Exception("Debe ingresar un Nivel.");
            }
        }
        private static CD_Usuario _GetUserIfExist(string user, string errorIfFound = "", string errorIfNotFound = "")
        {
            CD_Usuario[] users = CD_Usuario.SelectBy(user);
            if (users.Length > 0)
            {
                if (errorIfFound.Length > 0)
                {
                    throw new Exception(errorIfFound);
                }
                return users[0];
            }
            if (errorIfNotFound.Length > 0)
            {
                throw new Exception(errorIfNotFound);
            }
            return null;
        }


        public static void Login(string usuario, string contrasena)
        {
            _ValidateUserFormat(usuario);

            CD_Usuario usr = _GetUserIfExist(usuario, errorIfNotFound:"El usuario no existe. Debe registrarse primero.");

            if (!PasswordHash.ValidatePassword(contrasena, usr.Contrasena)) 
            {
                throw new Exception("Usuario y/o contraseña incorrectos.");
            }

            CurrentUser = usr;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }

        public static void SignUp(string nombre, string usuario, string contrasena, string contrasena2)
        {
            const string NIVEL_DEFAULT = "Usuario";

            _ValidateUserFormat(usuario);

            CD_Usuario usr = _GetUserIfExist(usuario, errorIfFound:"El usuario ya existe. Debe registrarse con otro usuario.");

            _ValidateUsernameFormat(nombre);
            _ValidatePasswordChange(contrasena, contrasena2);
            _ValidateNivel(NIVEL_DEFAULT);

            CD_Usuario newUser = new CD_Usuario();
            newUser.NombreCompleto = nombre;
            newUser.Usuario = usuario;
            newUser.Contrasena = PasswordHash.CreateHash(contrasena);
            newUser.Nivel = NIVEL_DEFAULT;
            CD_Usuario.Insert(newUser);
        }

        public static void UpsertUser(int? Id, string nombre, string usuario, string nivel, string contrasena, string contrasena2)
        {

            _ValidateUserFormat(usuario);

            CD_Usuario usr = _GetUserIfExist(usuario);
            if (usr != null && usr.Id != Id)
            {
                throw new Exception("El usuario ya está en uso. Debe usar otro usuario.");
            }

            _ValidateUsernameFormat(nombre);
            _ValidateNivel(nivel);

            if (Id == null)
            {
                _ValidatePasswordFormat(contrasena);
            }
            if (contrasena.Length > 0)
            {
                _ValidatePasswordChange(contrasena, contrasena2);
            }

            // Upsert
            CD_Usuario usr2 = new CD_Usuario();
            usr2.Id = Id;
            usr2.NombreCompleto = nombre;
            usr2.Usuario = usuario;
            usr2.Nivel = nivel;
            if (contrasena.Length > 0)  usr2.Contrasena = PasswordHash.CreateHash(contrasena);
            CD_Usuario.Upsert(usr2);
        }

        public static void SetNewPassword(string usuario, string contrasena, string contrasena2)
        {
            _ValidateUserFormat(usuario);

            CD_Usuario usr = _GetUserIfExist(usuario, errorIfNotFound:"El usuario no existe.");

            _ValidatePasswordChange(contrasena, contrasena2);

            usr.Contrasena = PasswordHash.CreateHash(contrasena);
            CD_Usuario.Update(usr);
        }

        public static bool CurrentuserCanEditOtherUsers()
        {
            if (CurrentUser == null)
            {
                return false;
            }
            if (CurrentUser.Nivel == "Usuario")
            {
                // Sólo administradores/desarrolladores pueden modificar usuarios
                return false;
            }

            return true;
        }
    }
}
