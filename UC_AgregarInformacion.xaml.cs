using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using SQLite;

namespace LIT
{
    /// <summary>
    /// Agrega informacion nueva
    /// </summary>
    public partial class UC_AgregarInformacion : UserControl
    {
        public UC_AgregarInformacion()
        {
            InitializeComponent();
        }

        private void BTN_Add_Click(object sender, RoutedEventArgs e)
        {
            NewDataBaseDialog x = new NewDataBaseDialog();
            x.ShowDialog();
            //// Crear una conexión a la base de datos
            //SQLiteConnection conexion = new SQLiteConnection("informacion.db");

            //try
            //{
            //    // Crear una tabla llamada "datos"
            //    conexion.CreateTable<Datos>();

            //    MessageBox.Show("Base de datos creada correctamente.");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al crear la base de datos: " + ex.Message);
            //}
        }

    }

    public class Datos
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }
        public DateTime FirstTime { get; set; }
        public DateTime After24Hrs { get; set; }
        public DateTime AfterWeek { get; set; }
    }
}
