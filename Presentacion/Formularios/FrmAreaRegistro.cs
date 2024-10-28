using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.Negocio;

namespace Presentacion.Formularios
{
    public partial class FrmAreaRegistro : Form
    {
        public FrmAreaRegistro()
        {
            InitializeComponent();
        }

        Metodos metodos = new Metodos();
        Validaciones validaciones = new Validaciones();
        DataTable Tabla = new DataTable();

        string consulta = "SELECT bombero.cod_bombero AS Codigo, area.nombre AS Nombre, tarea.fecha AS Fecha, tarea.hora AS Hora, tarea.detalle AS Detalle, tarea.estado AS Estado, tarea.punto AS Punto FROM tarea INNER JOIN bombero ON tarea.cod_bombero = bombero.cod_bombero INNER JOIN area ON bombero.cod_area = area.cod_area";

        private void FrmAreaRegistro_Load(object sender, EventArgs e)
        {
            dgvHistorialTareas.DataSource = metodos.Actualizar(Tabla, consulta);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int Codigo = Convert.ToInt32(txtCodigo.Text.Trim());

            string DescripcionTarea = txtDescripcion.Text;

            string AltaTarea = "INSERT INTO tarea (cod_area,fecha,hora,detalle) VALUES (" + txtCodigo.Text + ",'"
            + DateTime.Today.ToString("yyyy/MM/dd") + "','" + DateTime.Now.ToShortTimeString() + "','" + txtDescripcion.Text + "');";

            validaciones.PruebaAbm(AltaTarea);

            dgvHistorialTareas.DataSource = metodos.Actualizar(Tabla, consulta);

        }

        private void ValidacionDeFormato(object sender, KeyPressEventArgs e)
        {
            // Ignora cualquier tecla que no sea un número o retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            // Obtiene el texto actual y la posición del cursor
            string currentText = mtxtHora.Text.Replace(":", ""); // Eliminamos el carácter ":"
            int position = mtxtHora.SelectionStart;

            // Validación para cada posición
            switch (position)
            {
                case 0:
                    // Primera posición: permite solo 0, 1 o 2
                    if (e.KeyChar < 0 || e.KeyChar > 2)
                        e.Handled = true;
                    break;

                case 1:
                    // Segunda posición: depende del primer dígito
                    if (currentText[0] == '2' && (e.KeyChar < '0' || e.KeyChar > '3'))
                        e.Handled = true;
                    else if (currentText[0] != '2' && (e.KeyChar < '0' || e.KeyChar > '9'))
                        e.Handled = true;
                    break;

                case 2:
                    // Tercera posición: salta automáticamente el símbolo ":" entre horas y minutos
                    mtxtHora.SelectionStart = 3;
                    break;

                case 3:
                    // Cuarta posición: permite solo 0 a 5
                    if (e.KeyChar < '0' || e.KeyChar > '5')
                        e.Handled = true;
                    break;

                case 4:
                    // Quinta posición: permite solo 0 a 9
                    if (e.KeyChar < '0' || e.KeyChar > '9')
                        e.Handled = true;
                    break;

                default:
                    e.Handled = true;
                    break;
            }
        }

        private void mtxtHora_MouseLeave(object sender, EventArgs e)
        {
            if (mtxtHora.Text == "")
            {
                mtxtHora.Text = "0000";
            }
        }

        private void mtxtHora_MouseClick(object sender, MouseEventArgs e)
        {
            mtxtHora.Text = "";
        }
    }
}
