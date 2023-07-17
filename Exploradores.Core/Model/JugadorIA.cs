namespace Exploradores.Core.Model
{
    public class JugadorIA : BaseJugador
    {
        public override string Nombre { get; protected set; } = "Jugador IA";
        public override TipoJugador Tipo => TipoJugador.Ordenador;

        public JugadorIA() {}
    }
}
