/*
Programa: Simulador de Detección de Virus
// Autores: Mateo Polanco Alvarez | Carlos Andres Arroyave
// Fecha: 27-08-2025
Descripción: Clase que representa un virus. Contiene su nombre, la secuencia de 
bytes que lo caracteriza y el estado final asociado.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPracticaTCOM.Modelos
{
    internal class Virus
    {
  
        public string NombreVirus { get; set; }     // Nombre del virus
        public byte[] SecuenciaVirus { get; set; }  // Secuencia de bytes característica del virus
        public int EstadoFinal { get; set; }        // Estado final asociado a la detección del virus


        /// Constructor para inicializar un virus.
        public Virus(string nombre, byte[] secuencia, int estadoFinal)
        {
            NombreVirus = nombre;
            SecuenciaVirus = secuencia;
            EstadoFinal = estadoFinal;
        }
    }
}
