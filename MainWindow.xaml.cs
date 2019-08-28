using System;
using System.Threading;
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
using WindowsInput.Native;
using WindowsInput;

namespace Wow_Anti_Afk
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int s = 0;
        InputSimulator sim = new InputSimulator();


        public MainWindow()
        {
            InitializeComponent();
        }

        private async void StartAntiAFK(object sender, RoutedEventArgs e)
        {
            s = 1;

            while (s == 1)
            {
                await Task.Delay(3000);
                sim.Keyboard.KeyPress(VirtualKeyCode.SPACE);

                if(s == 0)
                {
                    break;
                }
            }

        }

        private void StopAntiAfk(object sender, RoutedEventArgs e)
        {
            s = 0;
        }
    }
}



