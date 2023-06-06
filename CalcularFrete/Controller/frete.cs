using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFrete.Controller
{
    internal class frete
    {
        private decimal valor;
        private decimal Frete;
        private string UF;

        public frete () { }

        public decimal Calcular(string uf, decimal v)
        {
            this.UF = uf;
            this.valor = v;
            this.Frete= 0;

            switch (uf)
            {
                case "SP":
                    this.Frete = 0.06m;
                    break;
                case "RJ":
                    this.Frete = 0.07m;
                    break;
                case "BA":
                    this.Frete = 0.08m;
                    break;
                case "MG":
                    this.Frete = 0.06m;
                    break;
                case "PE":
                    this.Frete = 0.10m;
                    break;
                case "PA":
                    this.Frete = 0.08m;
                    break;
                case "RS":
                    this.Frete = 0.09m;
                    break;
            
            }
            valor = Frete * valor;
            return valor;
        }
        public string LimparTela()
        {
            return "ok";
        }
    
    
    
    }    
    
}
