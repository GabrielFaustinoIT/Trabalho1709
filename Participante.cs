using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projEventos
{
    class Participante
      {
        private string nome;
        private string email;



        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email
        {
            get { return email; }
            
        }
        

        public Participante( string nome, string email)
        {
            this.email = email;
            this.nome = nome;
        }

        public Participante()
            : this("", "",)
        {
        }

      




    }
}
