using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CamadaDados;

namespace CamadaNegocio
{
    public class NLogin
    {
        public bool check;
        public string mensagem = "";
        public string nome = "";

        public bool Acessar(string login, string senha)
        {
            DLogin Logar = new DLogin();
            check = Logar.verificarLogin(login.ToUpper(), senha);
            if (this.check == false)
            {
                this.mensagem = Logar.mensagem;
            }

            return this.check;
        }

    }
}
