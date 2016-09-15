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

namespace WpfCourse001
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

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Button source = e.OriginalSource as Button;
            if (source == null) return;

            Window window = null;
            switch (source.Name)
            {
                case "btn_001":
                    window = new Exercise1();                             
                    break;
                case "btn_002":
                    window = new Exercise2();
                    break;
                case "btn_003":
                    window = new Exercise3();
                    break;
                case "btn_004":
                    window = new Exercise4();
                    break;
                case "btn_005":
                    window = new Exercise5();
                    break;
                case "btn_006":
                    window = new Exercise6();
                    break;                
            }

            if (window == null)
                return;
            
            window.Show();
            window.Focus();            
        }
    }
}
