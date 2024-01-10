using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Volvo_DotNet_Course
{
    public class Pais : IPais
    {
        public string codigo {get;set;}
        public string nome {get;set;}
        public int populacao {get;set;}
        public double dimensao {get;set;}
        private List<Pais> paisesVizinhos;

        public void SetPaisVizinho(Pais pais)
        {
            paisesVizinhos.Add(pais);
        }

        public List<Pais> GetPaisesVizinhos()
        {
            return paisesVizinhos;
        }

        public Pais(string codigo, string nome, int populacao, double dimensao) 
        {
            this.codigo = codigo;
            this.nome = nome;
            this.populacao = populacao;
            this.dimensao = dimensao;
            this.paisesVizinhos = new List<Pais>();
   
        }

        public bool VerificarPaises(Pais outroPais)
        {
            if (outroPais == null)
            {
                return false;
            }

            return this.codigo == outroPais.codigo;
        }

        public bool VerificarPaisVizinho(Pais outroPais)
        {
            if (outroPais == null)
            {
                return false;
            }

            return paisesVizinhos.Contains(outroPais);
        }

        public double CalcularDensidadePopulacional()
        {

            double densidadePopulacional = this.populacao/this.dimensao;

            return densidadePopulacional;

        }

        public List<Pais> VizinhosComuns(Pais outroPais)
        {

            List<Pais> paisesVizinhosComum = new List<Pais>();

            foreach(Pais pais in this.paisesVizinhos){
                if (outroPais.paisesVizinhos.Contains(pais)){
                    paisesVizinhosComum.Add(pais);
                }
            }

            return paisesVizinhosComum;

        }
    }
}