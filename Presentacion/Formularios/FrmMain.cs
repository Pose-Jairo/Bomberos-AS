using Datos.Conexion;
using Logica.Negocio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            string consulta = "SELECT cod_bombero, fecha, entrada, salida FROM asistencia WHERE CONVERT(date, fecha) = CONVERT(date, GETDATE())";

            CargaDeGrilla(consulta);
        }

        string AsistenciasDelDia = "SELECT cod_bombero, fecha, entrada, salida FROM asistencia WHERE CONVERT(date, fecha) = CONVERT(date, GETDATE())";


        Validaciones validaciones = new Validaciones();

        Metodos metodos = new Metodos();

        DataTable Tabla1 = new DataTable();

        ConexionConBD coneccion = new ConexionConBD();

        //validar textbox solo numeros
        private void btnEntrada_Click(object sender, EventArgs e)
        {
            string Codigo = txtCodigo.Text;

            // Verificar que el código de bombero existe en la base de datos
            string consul = $"SELECT COUNT(*) FROM bombero WHERE cod_bombero = {Codigo};";
            bool VerificacionBombero = coneccion.EjecutarConsulta(consul);

            if (!VerificacionBombero)
            {
                MessageBox.Show("El código de bombero no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si ya existe un registro de entrada sin salida para el mismo día
            string verificarEntrada = $"SELECT COUNT(*) FROM asistencia WHERE cod_bombero = {Codigo} AND fecha = CONVERT(date, GETDATE()) AND salida IS NULL;";
            int tieneEntradaSinSalida = coneccion.ObtenerConteo(verificarEntrada);

            if (tieneEntradaSinSalida != 0)
            {
                MessageBox.Show("Ya existe un registro de entrada sin salida para hoy.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insertar nueva entrada para el bombero si pasó las verificaciones
            try
            {
                string consulta = $"INSERT INTO asistencia (cod_bombero, fecha, entrada, salida) VALUES ({Codigo}, CONVERT(date, GETDATE()), GETDATE(), NULL)";
                CargaDeGrilla(consulta);
                //MessageBox.Show("Entrada registrada exitosamente.", "Registro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cargar las asistencias en la grilla
                CargaDeGrilla(AsistenciasDelDia);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar la entrada: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            string Codigo = txtCodigo.Text;

            // Actualizar la salida si ya se registró una entrada y no hay salida
            string consulta = $"UPDATE asistencia SET salida = GETDATE() WHERE cod_bombero = {Codigo} AND fecha = CONVERT(date, GETDATE()) AND salida IS NULL";
            int filasAfectadas = coneccion.entrada(consulta);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Salida registrada exitosamente.", "Registro de Salida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay ingreso registrado para el día de hoy o la salida ya ha sido registrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Cargar nuevamente las asistencias del día en la grilla
            CargaDeGrilla(AsistenciasDelDia);
        }

        public void CargaDeGrilla(string consulta)
        {
            try
            {
                dgvHistorial.DataSource = metodos.Actualizar(Tabla1, consulta);
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void btnEmergencia_Click(object sender, EventArgs e)
        {
            VentanaEmergencia nueva = new VentanaEmergencia();
            nueva.ShowDialog();
        }
    }
}
