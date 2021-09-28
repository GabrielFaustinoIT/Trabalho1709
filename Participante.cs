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

        public Vendedor()
            : this(0, "", 0.00)
        {
        }

        public void registrarVenda(int dia, Venda venda)
        {
            this.asVendas[dia - 1] = venda;
        }

        public double valorVendas()
        {
            double totVendas = 0;
            foreach (Venda v in this.asVendas)
                totVendas += v.Valor;
            return totVendas;
        }

        public double valorComissao()
        {
            return this.valorVendas() * (this.percComissao / 100);
        }

        public override bool Equals(object obj)
        {
            return this.id.Equals(((Vendedor)obj).id);
        }

        public override string ToString()
        {
            return this.id.ToString() + " - " + 
                   this.nome + " - " + 
                   this.percComissao.ToString() + " - " +
                   this.valorVendas().ToString() + " - " +
                   this.valorComissao().ToString() + '\n';
        }


    }
}
