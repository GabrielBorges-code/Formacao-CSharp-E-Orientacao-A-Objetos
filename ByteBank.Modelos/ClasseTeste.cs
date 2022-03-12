using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    class ClasseTeste
    {
        public ClasseTeste()
        {
            ModificadoresTeste teste = new ModificadoresTeste();
            teste.MetodoPublico();
            //teste.MetodoPrivado(); //inacessível devido ao seu nível de proteção
            //teste.MetodoProtegido(); //inacessível devido ao seu nível de proteção
            teste.MetodoInterno();

        }
        
    }

    class Derivada : ModificadoresTeste
    {
        public Derivada()
        {
          MetodoPublico();
          //MetodoPrivado(); //inacessível devido ao seu nível de proteção
          MetodoProtegido();
          MetodoInterno();

        }
    }

    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {
            //Visível fora da classe "ModificadoresTeste"
        }
        private void MetodoPrivado()
        {
            //Visível apenas na classe "ModificadoresTeste"
        }

        protected void MetodoProtegido()
        {
            //Visível apenas na classe "ModificadoresTeste" e derivados

        }
        
        internal void MetodoInterno()
        {
            //Visível apenas para o projeto ByteBank.Modelos!
        }
    }
}
