using System;
using System.Windows.Forms;
using System.Drawing;

namespace FarmaciaPedidosApp
{
    public partial class PedidoEnviado : Form
    {
        public PedidoEnviado()
        {
            InitializeComponent();

            // Configuración general
            this.Text = "Confirmación de Pedido";
            this.Size = new Size(400, 200);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Crear layout
            TableLayoutPanel layout = new TableLayoutPanel();
            layout.Dock = DockStyle.Fill;
            layout.ColumnCount = 1;
            layout.RowCount = 2;
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 70));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 30));
            this.Controls.Add(layout);

            // Mensaje principal
            Label lblMensaje = new Label();
            lblMensaje.Text = "✅ Pedido enviado con éxito";
            lblMensaje.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            lblMensaje.Dock = DockStyle.Fill;
            layout.Controls.Add(lblMensaje, 0, 0);

            // Botón cerrar
            Button btnCerrar = new Button();
            btnCerrar.Text = "Cerrar";
            btnCerrar.Width = 100;
            btnCerrar.Anchor = AnchorStyles.None;
            btnCerrar.Click += (s, e) => this.Close();
            layout.Controls.Add(btnCerrar, 0, 1);
        }
    }
}

