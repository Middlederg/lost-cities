using System.Drawing;

namespace Exploradores.Core.Model
{
    public struct Destino
    {
        private string nombre;
        public Color Color { get; private set; }
        public string Ruta { get; private set; }

        public Destino(string nombre, Color color, string ruta)
        {
            Color = color;
            Ruta = ruta;
            this.nombre = nombre;
        }

        public override string ToString() => nombre;
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return nombre.Equals(((Destino)obj).ToString());
        }
        public override int GetHashCode() => base.GetHashCode();
    }
}
