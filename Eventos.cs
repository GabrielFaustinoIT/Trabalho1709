using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projVendasCA
{
    class Eventos
    {
    public Evento[] osEventos;



        public Eventos()
        {
     
            this.osEventos = new Evento[6];
            for(int i=0; i<6; ++i)
                this.osEventos[i] = new Evento();
        }



        public void adicionarEvento(int dia, Evento e)
        {
            this.osEventos[dia - 1] = e;
        }
        
        
        public Participante pesquisarParticipante(Participante p)
        {
            Participante participanteAchado = new Participante();
            int i = participanteAchado.qtdMaxPart;
            if (!this.oParticipante[i].Equals(p)){
          
        vendedorAchado = this.osVendedores[i];
            }
            return vendedorAchado;
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
