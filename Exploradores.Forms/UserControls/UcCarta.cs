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
    public partial class UcCarta : UcBase
    {
        private Carta carta;

        public Carta Carta
        {
            get { return carta; }
            set
            {
                carta = value;
                UpdateCard();
            }
        }

        public bool Arrastrable { get; set; }

        public UcCarta()
        {
            InitializeComponent();
        }

        private void UpdateCard()
        {
            if (carta is null)
            {
                BtnIzquierda.IconChar = BtnDerecha.IconChar = FontAwesome.Sharp.IconChar.None;
                BtnIzquierda.Text = BtnDerecha.Text = "";
                PbxImage.Image = null;
                BackColor = Color.Transparent;
                return;
            }

            BackColor = Color.Black;
            PbxImage.Image = (Image)Properties.Resources.ResourceManager.GetObject(carta.Ruta);
            BtnIzquierda.ForeColor = BtnIzquierda.IconColor = carta.GetColor;
            BtnDerecha.ForeColor = BtnDerecha.IconColor = carta.GetColor;
            if (carta.EsInversion)
            {
                BtnIzquierda.IconChar = BtnDerecha.IconChar = FontAwesome.Sharp.IconChar.Handshake;
                BtnIzquierda.Text = BtnDerecha.Text = "";
            }
            else
            {
                BtnIzquierda.IconChar = BtnDerecha.IconChar = FontAwesome.Sharp.IconChar.None;
                BtnIzquierda.Text = BtnDerecha.Text = carta.Numero.ToString();
            }
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (Arrastrable)
                DoDragDrop(this, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void OnDragEnter(object sender, DragEventArgs e)
        {
            var ucOrigen = e.Data.GetData(typeof(UcCarta)) as UcCarta;
            Carta origen = ucOrigen.carta;
            if (origen.Equals(carta) || ucOrigen.Parent.Equals(Parent))
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            e.Effect = DragDropEffects.Move;
        }
    }
}
