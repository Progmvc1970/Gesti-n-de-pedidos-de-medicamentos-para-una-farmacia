using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaPedidosApp
{
    public partial class FormularioPedidos: Form
    {
        public FormularioPedidos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centra la ventana al abrir
            CargarTiposMedicamento();
        }
        

        
        private void CargarTiposMedicamento()
        {
            cmbTipo.Items.Clear(); // Limpia por si acaso
            cmbTipo.Items.Insert(0, "Seleccione un tipo...");
            cmbTipo.SelectedIndex = 0;
            cmbTipo.Items.Add("Analgésico");
            cmbTipo.Items.Add("Analéptico");
            cmbTipo.Items.Add("Anestésico");
            cmbTipo.Items.Add("Antiácido");
            cmbTipo.Items.Add("Antidepresivo");
            cmbTipo.Items.Add("Antibióticos");
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarFormulario())
                    return;

                // Obtener valores ya validados
                string distribuidor = rbCofarma.Checked ? "Cofarma" :
                                      rbEmpsephar.Checked ? "Empsephar" : "Cemefar";

                int cantidad = int.Parse(txtCantidad.Text);

                string sucursales = "";
                if (chkPrincipal.Checked) sucursales += "Farmacia Principal (Calle de la Rosa n. 28)\n";
                if (chkSecundaria.Checked) sucursales += "Farmacia Secundaria (Calle Alcazabilla n. 3)\n";

                // Abrir ventana resumen
                ResumenDelPedido resumen = new ResumenDelPedido(
                    distribuidor,
                    cantidad,
                    cmbTipo.SelectedItem.ToString(),
                    txtMedicamento.Text,
                    sucursales
                );
                resumen.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error inesperado: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //fin

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            txtMedicamento.Clear();
            cmbTipo.SelectedIndex = -1;
            txtCantidad.Clear();
            rbCofarma.Checked = false;
            rbEmpsephar.Checked = false;
            rbCemefar.Checked = false;
            chkPrincipal.Checked = false;
            chkSecundaria.Checked = false;

        }
        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtMedicamento.Text) || !txtMedicamento.Text.All(char.IsLetterOrDigit))
            {
                MessageBox.Show(this, "Nombre inválido (solo alfanuméricos).",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validación del ComboBox
            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show(this, "Seleccione un tipo de medicamento.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validación de cantidad
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show(this, "Cantidad inválida.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validación de distribuidor
            if (!rbCofarma.Checked && !rbEmpsephar.Checked && !rbCemefar.Checked)
            {
                MessageBox.Show(this, "Seleccione un distribuidor.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validación de sucursales
            if (!chkPrincipal.Checked && !chkSecundaria.Checked)
            {
                MessageBox.Show(this, "Seleccione al menos una sucursal.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; // Todo válido
        }



    }
}