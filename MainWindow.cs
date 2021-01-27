using CalculadoraWPF;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace CalculadoraWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OperacionesAritmeticas op = new OperacionesAritmeticas();
            try
            {
                txtBox.Text = "3.2+3.4";
                Console.WriteLine(op.getSuma(op.getTerminos(txtBox)));
                Console.Read();
            }
            catch (IOException) { Console.WriteLine("error"); }
        }

        
    }
}
