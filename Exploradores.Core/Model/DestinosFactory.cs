using System.Collections.Generic;
using System.Drawing;

namespace Exploradores.Core.Model
{
    public static class DestinosFactory
    {
        public static Destino Volcan => new Destino("Míticos volcanes", Color.IndianRed, "volcan");
        public static Destino Selva => new Destino("Selva de Brasil", Color.SpringGreen, "selva");
        public static Destino Monte => new Destino("Himalaya", Color.White, "monte");
        public static Destino Oceano => new Destino("Reinos de Neptuno", Color.CornflowerBlue, "mar");
        public static Destino Desierto => new Destino("Arenas del desierto", Color.Yellow, "arena");

        public static IEnumerable<Destino> GetDestinos
        {
            get
            {
                yield return Volcan;
                yield return Selva;
                yield return Monte;
                yield return Oceano;
                yield return Desierto;
            }
        }
    }
}
