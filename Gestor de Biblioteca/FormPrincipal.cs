using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Biblioteca
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            MostrarDashboard();
        }

        private void MostrarDashboard()
        {
            panelContenido.Controls.Clear();

            // Crear panel de dashboard
            Panel panelDashboard = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(245, 247, 250)
            };

            // Crear tarjetas de estadísticas
            Panel card1 = CrearTarjeta("Total de Libros", "1,250", "📚", 30, 30);
            Panel card2 = CrearTarjeta("Usuarios Activos", "350", "👥", 310, 30);
            Panel card3 = CrearTarjeta("Préstamos Activos", "85", "🔄", 590, 30);
            Panel card4 = CrearTarjeta("Pendientes", "12", "⚠️", 870, 30);

            panelDashboard.Controls.Add(card1);
            panelDashboard.Controls.Add(card2);
            panelDashboard.Controls.Add(card3);
            panelDashboard.Controls.Add(card4);

            panelContenido.Controls.Add(panelDashboard);
        }

        private Panel CrearTarjeta(string titulo, string valor, string icono, int x, int y)
        {
            Panel card = new Panel
            {
                Size = new Size(250, 130),
                Location = new Point(x, y),
                BackColor = Color.White
            };

            Label lblIcono = new Label
            {
                Text = icono,
                Font = new Font("Segoe UI", 36F),
                Location = new Point(20, 20),
                Size = new Size(80, 80),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblValor = new Label
            {
                Text = valor,
                Font = new Font("Segoe UI", 24F, FontStyle.Bold),
                ForeColor = Color.FromArgb(51, 51, 51),
                Location = new Point(110, 30),
                Size = new Size(130, 40)
            };

            Label lblTitulo = new Label
            {
                Text = titulo,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.Gray,
                Location = new Point(110, 75),
                Size = new Size(130, 40)
            };

            card.Controls.Add(lblIcono);
            card.Controls.Add(lblValor);
            card.Controls.Add(lblTitulo);

            return card;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Dashboard Principal";
            MostrarDashboard();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestión de Libros";
            MessageBox.Show("Formulario de Libros - Próximamente");
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestión de Usuarios";
            MessageBox.Show("Formulario de Usuarios - Próximamente");
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gestión de Préstamos";
            MessageBox.Show("Formulario de Préstamos - Próximamente");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
