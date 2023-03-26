using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using Microsoft.Win32;
using SQLite;

namespace LIT
{
    public partial class NewDataBaseDialog : Window
    {
        string FolderPath = "";
        public NewDataBaseDialog()
        {
            InitializeComponent();
        }

        private void BtnCreateDataBase_Click(object sender, RoutedEventArgs e)
        {
            if(TBX_Nombre.Text == string.Empty || TBX_Nombre.Text == null)
            {
                MessageBox.Show("Introduzca el nombre");
                return;
            }

            // Crear una conexión a la base de datos
            //string tesxt = Environment.SpecialFolder.ToString() + "/" + TBX_Nombre.Text + ".db";
            SQLiteConnection conexion = new SQLiteConnection(Environment.SpecialFolder.MyDocuments+"/"+TBX_Nombre.Text+".db");

            try
            {
                // Crear una tabla llamada "datos"
                conexion.CreateTable<Datos>();

                MessageBox.Show("Base de datos creada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la base de datos: " + ex.Message);
            }
        }

        private void BTNSelectFolder_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            // Configurar opciones del diálogo
            openFileDialog.Title = "Selecciona una carpeta para guardar la base de datos";
            openFileDialog.Filter = "Carpetas|*.db";
            openFileDialog.CheckFileExists = false;
            openFileDialog.CheckPathExists = true;
            openFileDialog.FileName = TBX_Nombre.Text;

            // Mostrar el diálogo de selección de carpeta
            bool? result = openFileDialog.ShowDialog();

            if (result == true)
            {
                // Obtener la carpeta seleccionada por el usuario
                string folderPath = System.IO.Path.GetDirectoryName(openFileDialog.FileName);

                TBX_Path.Text = folderPath+"\\"+openFileDialog.FileName;
            }

        }

        private void CreateDatabase()
        {

        }
    }
}
