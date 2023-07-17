using System;
using System.Text;
using System.Threading.Tasks;

namespace Exploradores.Core.Model
{
    public class Jugador : BaseJugador
    {
        public override string Nombre { get; protected set; }
        public override TipoJugador Tipo => TipoJugador.Jugador;

        public Jugador(string nombre)
        {
            Nombre = nombre;
        }
    }
}
