using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_BS_LocadoraVeiculos
{
    public class Usuarios 
    {
        #region SETTERS/GETTERS
        private string login;
        private string senha;
        private string perfil;


        public void setLogin(string Login){
            login = Login;
        }

        public string getLogin()
        {
            return login;
        }

        public void setSenha(string Senha)
        {
            senha = Senha;
        }

        public string getSenha()
        {
            return senha;
        }

        public void setPerfil(string Perfil)
        {
            perfil = Perfil;
        }
        public string getPerfil()
        {
            return perfil;
        }

        #endregion

    }
}
