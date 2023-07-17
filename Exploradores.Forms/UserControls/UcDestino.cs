using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Exploradores.Core.Model;

namespace Exploradores.Forms
{
    public partial class UcDestino : UcBase
    {
        private Destino destino;

        public Destino Destino
        {
            get { return destino; }
            set
            {
                destino = value;
                UpdateCard();
            }
        }

        public UcDestino()
        {
            InitializeComponent();
        }

        private void UpdateCard()
        {
            BackColor = destino.Color;
        }

        private void OnDragEnter(object sender, DragEventArgs e)
        {
            var ucOrigen = e.Data.GetData(typeof(UcCarta)) as UcCarta;
            Carta origen = ucOrigen.Carta;
            if (origen.MismoPalo(destino))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
