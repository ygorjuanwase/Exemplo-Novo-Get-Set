using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Carro
    {
        public string Nome
        {
            get
            {
                return Nome;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Nome deve sert preenchido");
                }
                if (value.Count() == 1)
                {
                    throw new Exception("Nome deve conter no mínimo 2 caracteres");
                }
                Nome = value;
            }
        }
        public string Marca
        {
            get
            {
                return Marca;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Marca deve ser preenchida");
                }
                if (value.Count() == 3)
                {
                    throw new Exception("Marca deve conter no mínimo 2 caracteres");
                }

                Marca = value;
            }
        }
        public double Valor
        {
            get
            {
                return Valor;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Valor deve ser maior que zero");
                }
                Valor = value;
            }
        }
        public int AnoFabricacao
        {
            get { return AnoFabricacao; }
            set
            {
                if (value < 1885)
                {
                    throw new Exception("Ano deve ser maior que 1885");
                }
                if (value > DateTime.Now.Year)
                {
                    throw new Exception("Ano deve ser menor ou igual a" + DateTime.Now.Year);
                }
                AnoFabricacao = value;
            }
        }
    }
}
