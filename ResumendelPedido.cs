using System;
using System.Drawing;
using System.Windows.Forms;


namespace FarmaciaPedidosApp
{
    public partial class ResumenDelPedido : Form
    {
        public ResumenDelPedido(string distribuidor, int cantidad, string tipoMedicamento, string nombreMedicamento, string sucursales)
        {
            InitializeComponent();

            // Configuración general de la ventana
            this.Text = $"Pedido al distribuidor {distribuidor}";
            this.Size = new Size(550, 320);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Crear tabla
            TableLayoutPanel tabla = new TableLayoutPanel();
            tabla.Dock = DockStyle.Fill;
            tabla.ColumnCount = 2;
            tabla.RowCount = 5;
            tabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35));
            tabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65));
            for (int i = 0; i < tabla.RowCount; i++)
                tabla.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.Controls.Add(tabla);

            // Fila 1: Distribuidor
            tabla.Controls.Add(new Label { Text = "Distribuidor:", Font = new Font("Segoe UI", 10, FontStyle.Bold), Dock = DockStyle.Fill }, 0, 0);
            tabla.Controls.Add(new Label { Text = distribuidor, Dock = DockStyle.Fill }, 1, 0);

            // Fila 2: Cantidad
            tabla.Controls.Add(new Label { Text = "Cantidad:", Font = new Font("Segoe UI", 10, FontStyle.Bold), Dock = DockStyle.Fill }, 0, 1);
            tabla.Controls.Add(new Label { Text = cantidad.ToString(), Dock = DockStyle.Fill }, 1, 1);

            // Fila 3: Tipo de medicamento
            tabla.Controls.Add(new Label { Text = "Tipo de medicamento:", Font = new Font("Segoe UI", 10, FontStyle.Bold), Dock = DockStyle.Fill }, 0, 2);
            tabla.Controls.Add(new Label { Text = tipoMedicamento, Dock = DockStyle.Fill }, 1, 2);

            // Fila 4: Nombre del medicamento
            tabla.Controls.Add(new Label { Text = "Nombre del medicamento:", Font = new Font("Segoe UI", 10, FontStyle.Bold), Dock = DockStyle.Fill }, 0, 3);
            tabla.Controls.Add(new Label { Text = nombreMedicamento, Dock = DockStyle.Fill }, 1, 3);

            // Fila 5: Sucursales
            tabla.Controls.Add(new Label { Text = "Sucursales:", Font = new Font("Segoe UI", 10, FontStyle.Bold), Dock = DockStyle.Fill }, 0, 4);
            tabla.Controls.Add(new Label { Text = sucursales, Dock = DockStyle.Fill }, 1, 4);

            // Panel de botones
            FlowLayoutPanel panelBotones = new FlowLayoutPanel { FlowDirection = FlowDirection.RightToLeft, Dock = DockStyle.Bottom, Height = 50 };
            Button btnEnviar = new Button { Text = "Enviar", Width = 100 };
            btnEnviar.Click += (s, e) =>
            {
                PedidoEnviado enviado = new PedidoEnviado();
                enviado.ShowDialog();
                this.Close();
            };

            Button btnCancelar = new Button { Text = "Cancelar", Width = 100 };
            btnCancelar.Click += (s, e) => this.Close();

            panelBotones.Controls.Add(btnEnviar);
            panelBotones.Controls.Add(btnCancelar);
            this.Controls.Add(panelBotones);
        }
    }
}

