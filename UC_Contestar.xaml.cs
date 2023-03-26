using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LIT
{
    /// <summary>
    /// Interaction logic for UC_Contestar.xaml
    /// </summary>
    public partial class UC_Contestar : UserControl
    {
        public UC_Contestar()
        {
            InitializeComponent();
        }

        private void BTN_SearchDB_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            // Configurar opciones del diálogo
            openFileDialog.Title = "Selecciona un archivo .txt";
            openFileDialog.Filter = "Archivos de texto|*.txt";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;

            // Mostrar el diálogo de selección de archivo
            bool? result = openFileDialog.ShowDialog();

            if (result == true)
            {
                // Obtener la ruta completa del archivo seleccionado
                string filePath = openFileDialog.FileName;

                //TODO:Aqui llama al codigo que abre la base de datos
                // Mostrar la ruta completa en la consola
                //Console.WriteLine(filePath);
            }
        }

        private void DisminuirLetraQuestion(object sender, RoutedEventArgs e)
        {
            if (TBX_Pregunta.FontSize > 10)
                TBX_Pregunta.FontSize -= 2;
        }
        private void AumentarLetraQuestion(object sender, RoutedEventArgs e)
        {
            if (TBX_Pregunta.FontSize < 80)
                TBX_Pregunta.FontSize += 2;
        }


        //Answer:
        private void DisminuirLetraAnswer(object sender, RoutedEventArgs e)
        {
            if (TBX_Answer.FontSize > 10)
                TBX_Answer.FontSize -= 2;
        }
        private void AumentarLetraAnswer(object sender, RoutedEventArgs e)
        {
            if (TBX_Answer.FontSize < 80)
                TBX_Answer.FontSize += 2;
        }



    }
}
