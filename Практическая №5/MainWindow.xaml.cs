using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Практическая__5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
        Triad tr1 = new Triad();
        Triad tr2 = new Triad();
        Triad tr3 = new Triad();
        int a, b, c;

        private void Fill(object sender, RoutedEventArgs e)
        {
            bool f1, f2, f3;

            f1 = int.TryParse(tr_1.Text, out a);
            f2 = int.TryParse(tr_2.Text, out b);
            f3 = int.TryParse(tr_3.Text, out c);
            if (f1 && f2 && f3)
            {
                tr1.Trid1 = a;
                tr2.Trid2 = b;
                tr3.Trid3 = c;
            }
            else MessageBox.Show("Неправильное значение");
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создать класс Triad (нечётная тройка). Создать необходимые методы и свойства. \nОпределить метод сравнения двух триад на равенство. \nСоздать перегруженный метод сравнения трех триад на равенство.");
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            tr_1.Clear();     
            tr_2.Clear();          
            tr_3.Clear();          
            ravn.Clear();
        }

        private void Sr23(object sender, RoutedEventArgs e)
        {
            bool f1;
            f1 = tr1.Sravn(b, c);
            if (f1) ravn.Text = "2 и 3 тройки равны"; 
            else ravn.Text = "2 и 3 тройки не равны";
        }

        private void Sr13(object sender, RoutedEventArgs e)
        {
            bool f1;
            f1 = tr1.Sravn(a, c);
            if (f1) ravn.Text = "1 и 3 тройки равны"; 
            else ravn.Text = "1 и 3 тройки не равны";
        }

        private void Sr12(object sender, RoutedEventArgs e)
        {
            bool f1;
            f1 = tr1.Sravn(a, b);
            if (f1) ravn.Text = "1 и 2 тройки равны"; 
            else ravn.Text = "1 и 2 тройки не равны";
        }

        private void Sr3(object sender, RoutedEventArgs e)
        {
            bool f1;
            f1 = tr1.Sravn(a, b, c);
            if (f1) ravn.Text = "Все тройки равны"; 
            else ravn.Text = "Все тройки не равны";
        }
    }
}