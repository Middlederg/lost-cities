using System;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Exploradores.Core.Model
{
    public class Carta
    {
        public const int CosteExpedicion = -20;
        public const int BonificacionPorExpedicionCompleta = 20;
        public const int NumeroCartasRequeridoParaBonificacion = 8;

        private Destino destino;
        public int Numero { get; private set; }
        public Color GetColor => destino.Color;
        public string Palo => destino.ToString();
        public bool MismoPalo(Carta c) => c.Palo.Equals(Palo);
        public bool MismoPalo(Destino d) => destino.Equals(d);
        public bool EsInversion => Numero == 0;
        public string Ruta => destino.Ruta;

        public static Carta Create(int numero, Destino destino)
        {
            
            if (numero < 2 || numero > 10)
                throw new ArgumentOutOfRangeException("numero debe estar entre 2 y 10");
            return new Carta(numero, destino);
        }
        public static Carta CreateInversion(Destino destino) => new Carta(0, destino);
        
        private Carta(int numero, Destino destino)
        {
            this.destino = destino;
            Numero = numero;
        }

        public override string ToString()
        {
            if (EsInversion) return $"Inversión en {Palo}";
            return $"{Numero} - {Palo}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            var other = (Carta)obj;
            return Numero == Numero && MismoPalo(other);
        }

        public override int GetHashCode() => base.GetHashCode();
    }
}
