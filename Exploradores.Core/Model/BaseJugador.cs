using System.Collections.Generic;
using System.Linq;

namespace Exploradores.Core.Model
{
    public abstract class BaseJugador
    {
        public const int NumeroCartasEnMano = 8;

        public abstract string Nombre { get; protected set; }
        public abstract TipoJugador Tipo { get; }
        public List<Carta> Mano { get; private set; }
	    public List<Carta> Jugadas { get; private set; }

	    public BaseJugador()
	    {
            Reset();
	    }

        public void RobarCarta(Carta carta) => Mano.Add(carta);
        public void JugarCarta(Carta carta)
        {
            if (!Mano.Contains(carta))
                throw new System.ArgumentException($"{Nombre} no puede jugar la carta {carta.ToString()} porque no está en su mano");

            Mano.Remove(carta);
            Jugadas.Add(carta);
        }

        public void DescartarCarta(Carta carta)
        {
            if (!Mano.Contains(carta))
                throw new System.ArgumentException($"{Nombre} no puede descartar la carta {carta.ToString()} porque no está en su mano");

            Mano.Remove(carta);
        }

        public void Reset()
	    {
		    Mano = new List<Carta>();
		    Jugadas = new List<Carta>();
	    }

	    public bool PuedeJugar(Carta c)
	    {
            var cartas = Jugadas.Where(x => x.MismoPalo(c));

            if (cartas.Count() == 0)
                return true;

            if (c.EsInversion)
                return !cartas.Any(x => !x.EsInversion);

            return (cartas.Max(x => x.Numero) < c.Numero);
	    }

	    public int Puntuacion(Destino destino)
	    {
            var cartas = Jugadas.Where(x => x.MismoPalo(destino));

            if (cartas.Count() == 0)
                return 0;

            int inversiones = cartas.Count(x => x.EsInversion) + 1;
            int sumaPuntos = cartas.Sum(x => x.Numero);

            int bonificacion = 0;
            if (cartas.Count() >= Carta.NumeroCartasRequeridoParaBonificacion)
                bonificacion = Carta.BonificacionPorExpedicionCompleta;

            return (Carta.CosteExpedicion + sumaPuntos) * inversiones + bonificacion;
	    }

	    public int PuntuacionTotal() => DestinosFactory.GetDestinos.Select(x => Puntuacion(x)).Sum();
    }
}
