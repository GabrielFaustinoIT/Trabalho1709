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
        
        


        public override bool Equals(object obj)
        {
            return this.email.Equals(((Particpante)obj).email);
        }

        public override string ToString()
        {
            return this.id.ToString() + " - " + 
                   this.nome + " - " + 
                   this.percComissao.ToString() + " - " +
                   this.valorVendas().ToString() + " - " +
                   this.valorComissao().ToString() + '\n';
        }
        

             public void addEvento(Evento e)
      {
              bool podeAdd = (this.qtdMaxPart < this.qtdeMaxPart);
            if (podeAdd)
            {
                this.oParticipante[this.qtdMaxPart] = participante;
                this.qtdMaxPart++;
            }
            return podeAdd;
      }
}

}
