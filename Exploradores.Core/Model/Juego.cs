using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exploradores.Core.Model
{
    public class Juego
    {
	    public int Id { get; set; }
	    public List<BaseJugador> Jugadores { get; }
	    public int Turno { get; set; }
	    public List<Carta> Mazo { get; set; }
	    public List<Carta> Descarte { get; set; }
	    public List<string> Log { get; set; }

	    public Juego(string nombreJugador)
	    {
		    Id = 0;
            Jugadores = new List<BaseJugador>() { new Jugador(nombreJugador), new JugadorIA() };
		    Log = new List<string>();
		    ResetGame();
	    } 

	    public void ResetGame()
	    {
		    Id++;
            Mazo = new CardGenerator().CreateCartas().ToList().Desordenar();
		    Descarte = new List<Carta>();
            Turno = R.Instance.NumAleatorio(0, 1);
            foreach (Jugador jugador in Jugadores)
		    {
			    jugador.Reset();
                foreach (var i in Enumerable.Range(0, Jugador.NumeroCartasEnMano))
                    Robar();
                AvanzaTurno();
		    }
	    }

        public void AvanzaTurno() => Turno = Turno == 1 ? 0 : 1;
        public BaseJugador JugadorActual => Jugadores[Turno];

        private void Robar()
        {
            var carta = Mazo.First();
            Mazo.Remove(carta);
            JugadorActual.RobarCarta(carta);
        }
	
	    public void DescartarCarta(Carta carta)
	    {
            JugadorActual.DescartarCarta(carta);
            Descarte.Add(carta);
	    }

	    public void RobarCartaDescarte(Destino destino)
	    {
            var carta = Descarte.Where(x => x.MismoPalo(destino)).LastOrDefault();
            if (carta is null)
                throw new ArgumentException($"No hay cartas en el descarte de tipo {destino.ToString()}");
            JugadorActual.RobarCarta(carta);
            Descarte.Remove(carta);
	    }
    }
}
