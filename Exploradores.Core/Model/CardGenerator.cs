using System.Collections.Generic;
using System.Linq;

namespace Exploradores.Core.Model
{
    public class CardGenerator
    {
        private const int numeroinversiones = 3;
        private readonly int[] numerosPorPalo;

        public CardGenerator()
        {
            numerosPorPalo = new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }

        public IEnumerable<Carta> CreateCartas()
        {
            foreach (Destino destino in DestinosFactory.GetDestinos)
            {
                foreach (var i in Enumerable.Range(0, numeroinversiones))
                    yield return Carta.CreateInversion(destino);

                foreach (var numero in numerosPorPalo)
                    yield return Carta.Create(numero, destino);
            }
        }
    }
}
