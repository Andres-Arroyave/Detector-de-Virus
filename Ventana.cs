/*
Programa: Simulador de Detección de Virus
// Autores: Mateo Polanco Alvarez | Carlos Andres Arroyave
// Fecha: 27-08-2025
Descripción: Esta clase implementa la interfaz gráfica principal en Windows Forms.
Permite al usuario seleccionar un archivo, mostrar su contenido en bytes y analizarlo
en busca de virus conocidos.
*/

using AppPracticaTCOM.Controladores;
using System;
using System.Windows.Forms;

namespace AppPracticaTCOM
{
    public partial class Ventana : Form
    {
        private byte[] bytes = null;              // Contenido en bytes del archivo seleccionado
        private string nombreArchivoCompleto = ""; // Ruta completa del archivo seleccionado

        /// Constructor de la ventana principal.
        /// Inicializa la interfaz gráfica y desactiva el botón de análisis hasta que se cargue un archivo.
        public Ventana()
        {
            InitializeComponent();
            buttonAnalisis.Enabled = false;
        }

        /// Evento que se ejecuta al hacer clic en el botón "Buscar".
        /// Abre un explorador de archivos y carga el archivo seleccionado en memoria.
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog explorador = new OpenFileDialog();

            if (explorador.ShowDialog() == DialogResult.OK)
            {
                nombreArchivoCompleto = explorador.FileName;

                if (!string.IsNullOrEmpty(nombreArchivoCompleto))
                {
                    try
                    {
                        AdminArchivo admin = new AdminArchivo(nombreArchivoCompleto);
                        bytes = admin.LeerBytes();

                        textBoxRuta.Text = nombreArchivoCompleto;
                        textboxNombreArchivo.Text = admin.ObtenerNombreArchivo();

                        // Mostrar bytes (limitado para evitar sobrecargar la interfaz)
                        string cadenaBytes = "";
                        int maxBytesToShow = 1000;

                        for (int i = 0; i < Math.Min(bytes.Length, maxBytesToShow); i++)
                        {
                            cadenaBytes += bytes[i] + " ";
                            if (i % 20 == 19) cadenaBytes += Environment.NewLine;
                        }

                        if (bytes.Length > maxBytesToShow)
                        {
                            cadenaBytes += $"... (y {bytes.Length - maxBytesToShow} bytes más)";
                        }

                        richTextBoxBytes.Text = cadenaBytes;

                        buttonAnalisis.Enabled = true;

                        // Limpiar resultados anteriores
                        textBoxVirusEncontrado.Text = "";
                        textBoxEstadoFinal.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// Evento que se ejecuta al hacer clic en el botón "Analizar".
        /// Realiza el análisis de los bytes del archivo y muestra los resultados.
        private void buttonAnalisis_Click(object sender, EventArgs e)
        {
            if (bytes == null || bytes.Length == 0)
            {
                MessageBox.Show("Primero debe seleccionar un archivo válido.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Analizador analizador = new Analizador(bytes);
                var (virusEncontrado, estadoFinal) = analizador.Analizar();

                textBoxVirusEncontrado.Text = virusEncontrado;
                textBoxEstadoFinal.Text = estadoFinal.ToString();

                if (virusEncontrado != "no encontrado")
                {
                    MessageBox.Show($"¡Virus detectado: {virusEncontrado}!", "Resultado del Análisis",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("No se encontraron virus en el archivo.", "Resultado del Análisis",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error durante el análisis: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// Evento que se ejecuta al hacer clic en el botón "Limpiar".
        /// Restablece todos los campos y desactiva el análisis.
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxRuta.Text = "";
            textboxNombreArchivo.Text = "";
            richTextBoxBytes.Text = "";
            textBoxVirusEncontrado.Text = "";
            textBoxEstadoFinal.Text = "";

            bytes = null;
            nombreArchivoCompleto = "";
            buttonAnalisis.Enabled = false;
        }

        // Otros eventos de la interfaz
        private void richTextBoxBytes_TextChanged(object sender, EventArgs e) { }
        private void textBoxRuta_TextChanged(object sender, EventArgs e) { }
        private void Ventana_Load(object sender, EventArgs e) { }
        private void labelNombreArchivo_Click(object sender, EventArgs e) { }
        private void textboxNombreArchivo_TextChanged(object sender, EventArgs e) { }
        private void textBoxVirusEncontrado_TextChanged(object sender, EventArgs e) { }
        private void textBoxEstadoFinal_TextChanged(object sender, EventArgs e) { }
        private void labelTitulo_Click(object sender, EventArgs e) { }
    }
}
