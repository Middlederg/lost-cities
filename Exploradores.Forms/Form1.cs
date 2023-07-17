using Exploradores.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exploradores.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ucCarta1.Carta = Carta.Create(3, DestinosFactory.Monte);
            ucCarta2.Carta = Carta.Create(6, DestinosFactory.Desierto);
            ucCarta3.Carta = Carta.Create(5, DestinosFactory.Oceano);
            ucCarta4.Carta = Carta.Create(10, DestinosFactory.Selva);
            ucCarta5.Carta = Carta.Create(2, DestinosFactory.Volcan);

            ucDestino1.Destino = DestinosFactory.Desierto;
            ucDestino2.Destino = DestinosFactory.Volcan;
            ucDestino3.Destino = DestinosFactory.Selva;
            ucDestino4.Destino = DestinosFactory.Oceano;
            ucDestino5.Destino = DestinosFactory.Monte;
        }
    }
}
