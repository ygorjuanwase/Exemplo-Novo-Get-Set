using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Time
    {
        public string Nome { get; set; }
        public int QuantidadeGolsFeitos { get; set; }
        public int QuantidadeGOlsSofridos {get; set; }
        public int QuantidadeCartoesAmarelos { get; set; }
        public int QuantidadeCartoesVermelhos { get; set; }
        public int Substituicao { get; set; }
        public int EsteveEmFinais { get; set; }
        public int Semifinais { get; set; }
        public int Vitorias { get; set; }
        public int Derrotas { get; set; }
        public int GolsContras { get; set; }
        public string Pais { get; set; }
        public decimal Faturamento { get; set; }
        public string Serie { get; set; }


        public Time(string nome, string pais, string serie)
        {
            Nome = nome;
            Pais = pais;
            Serie = serie;
        }
        public Time(string nome, string pais)
        {
            Nome = nome;
            Pais = pais;
        }
        public Time(string nome, string serie, decimal faturamento)
        {

        }
    
    }
}
