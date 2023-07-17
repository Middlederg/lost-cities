namespace Exploradores.Forms
{
    partial class UcCarta
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDerecha = new FontAwesome.Sharp.IconButton();
            this.BtnIzquierda = new FontAwesome.Sharp.IconButton();
            this.PbxImage = new System.Windows.Forms.PictureBox();
            this.TlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TlpPrincipal
            // 
            this.TlpPrincipal.ColumnCount = 2;
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpPrincipal.Controls.Add(this.BtnDerecha, 1, 0);
            this.TlpPrincipal.Controls.Add(this.BtnIzquierda, 0, 0);
            this.TlpPrincipal.Controls.Add(this.PbxImage, 0, 1);
            this.TlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpPrincipal.Location = new System.Drawing.Point(5, 5);
            this.TlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.TlpPrincipal.Name = "TlpPrincipal";
            this.TlpPrincipal.RowCount = 2;
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpPrincipal.Size = new System.Drawing.Size(110, 170);
            this.TlpPrincipal.TabIndex = 0;
            // 
            // BtnDerecha
            // 
            this.BtnDerecha.AllowDrop = true;
            this.BtnDerecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDerecha.FlatAppearance.BorderSize = 0;
            this.BtnDerecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnDerecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnDerecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDerecha.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnDerecha.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.BtnDerecha.ForeColor = System.Drawing.Color.White;
            this.BtnDerecha.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnDerecha.IconColor = System.Drawing.Color.White;
            this.BtnDerecha.IconSize = 32;
            this.BtnDerecha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDerecha.Location = new System.Drawing.Point(55, 0);
            this.BtnDerecha.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDerecha.Name = "BtnDerecha";
            this.BtnDerecha.Rotation = 0D;
            this.BtnDerecha.Size = new System.Drawing.Size(55, 30);
            this.BtnDerecha.TabIndex = 1;
            this.BtnDerecha.Text = "6";
            this.BtnDerecha.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnDerecha.UseVisualStyleBackColor = true;
            this.BtnDerecha.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            this.BtnDerecha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // BtnIzquierda
            // 
            this.BtnIzquierda.AllowDrop = true;
            this.BtnIzquierda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnIzquierda.FlatAppearance.BorderSize = 0;
            this.BtnIzquierda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnIzquierda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnIzquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIzquierda.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnIzquierda.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.BtnIzquierda.ForeColor = System.Drawing.Color.White;
            this.BtnIzquierda.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.BtnIzquierda.IconColor = System.Drawing.Color.White;
            this.BtnIzquierda.IconSize = 32;
            this.BtnIzquierda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIzquierda.Location = new System.Drawing.Point(0, 0);
            this.BtnIzquierda.Margin = new System.Windows.Forms.Padding(0);
            this.BtnIzquierda.Name = "BtnIzquierda";
            this.BtnIzquierda.Rotation = 0D;
            this.BtnIzquierda.Size = new System.Drawing.Size(55, 30);
            this.BtnIzquierda.TabIndex = 0;
            this.BtnIzquierda.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnIzquierda.UseVisualStyleBackColor = true;
            this.BtnIzquierda.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            this.BtnIzquierda.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // PbxImage
            // 
            this.TlpPrincipal.SetColumnSpan(this.PbxImage, 2);
            this.PbxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbxImage.Image = global::Exploradores.Forms.Properties.Resources.selva;
            this.PbxImage.Location = new System.Drawing.Point(0, 30);
            this.PbxImage.Margin = new System.Windows.Forms.Padding(0);
            this.PbxImage.Name = "PbxImage";
            this.PbxImage.Size = new System.Drawing.Size(110, 140);
            this.PbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxImage.TabIndex = 2;
            this.PbxImage.TabStop = false;
            this.PbxImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            this.PbxImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // UcCarta
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.TlpPrincipal);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcCarta";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(120, 180);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.TlpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpPrincipal;
        private FontAwesome.Sharp.IconButton BtnIzquierda;
        private FontAwesome.Sharp.IconButton BtnDerecha;
        private System.Windows.Forms.PictureBox PbxImage;
    }
}
