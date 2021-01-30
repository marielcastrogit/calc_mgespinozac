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
        private Controlador c;
        public MainWindow()
        {
            InitializeComponent();
            setControllers();
        }

        private void setControllers()
        {
            c = new Controlador(this);
            txtBox.PreviewTextInput += new TextCompositionEventHandler(c.validarTeclado);

            //Agregamos un controlador del comando pegar al textBox
            //El elemento es el txtBox y el delegado de manipularlo es c.cancelarComando
            DataObject.AddPastingHandler(txtBox, c.cancelarComando);

            //Estableciendo el control para los botones
            //Botones con operaciones especiales:
            factorial.Click += new RoutedEventHandler(c.controlarBotones);
            enesimoTerminoFibo.Click += new RoutedEventHandler(c.controlarBotones);
            esPrimo.Click += new RoutedEventHandler(c.controlarBotones);
            desplegarSerie.Click += new RoutedEventHandler(c.controlarBotones);

            //Botones que contienen numeros: 
            num0.Click += new RoutedEventHandler(c.controlarBotones);
            num1.Click += new RoutedEventHandler(c.controlarBotones);
            num2.Click += new RoutedEventHandler(c.controlarBotones);
            num3.Click += new RoutedEventHandler(c.controlarBotones);
            num4.Click += new RoutedEventHandler(c.controlarBotones);
            num5.Click += new RoutedEventHandler(c.controlarBotones);
            num6.Click += new RoutedEventHandler(c.controlarBotones);
            num7.Click += new RoutedEventHandler(c.controlarBotones);
            num8.Click += new RoutedEventHandler(c.controlarBotones);
            num9.Click += new RoutedEventHandler(c.controlarBotones);

            //Botones que contienen signos de operaciones aritmeticas:
            sumar.Click += new RoutedEventHandler(c.controlarBotones);
            multiplicar.Click += new RoutedEventHandler(c.controlarBotones);
            dividir.Click += new RoutedEventHandler(c.controlarBotones);
            restar.Click += new RoutedEventHandler(c.controlarBotones);
            igual.Click += new RoutedEventHandler(c.controlarBotones);

            //Botones que borran contenido:
            borrarTodo.Click += new RoutedEventHandler(c.controlarBotones);
            borrarReciente.Click += new RoutedEventHandler(c.controlarBotones);
            borrarUltimoDigito.Click += new RoutedEventHandler(c.controlarBotones);

            punto.Click += new RoutedEventHandler(c.controlarBotones);

            

        }
       

    }
}
