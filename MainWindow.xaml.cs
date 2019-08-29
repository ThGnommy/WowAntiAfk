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
        CancellationTokenSource cts = new CancellationTokenSource();

        public MainWindow()
        {
            InitializeComponent();

            Stop_Anti_Afk.IsEnabled = false;
        }

        public async void TaskDelay(CancellationToken token)
        {
            while (s == 1)
            {

                sim.Keyboard.KeyPress(VirtualKeyCode.VK_Q);

                if (s == 0)
                {
                    break;
                }

                try
                {
                    await Task.Delay(10000, token);
                }

                catch (TaskCanceledException ex)
                {
                    return;
                }

            }
        }

        private void StartAntiAFK(object sender, RoutedEventArgs e)
        {
            s = 1;
            TaskDelay(cts.Token);
            Stop_Anti_Afk.IsEnabled = true;
        }

        private void StopAntiAfk(object sender, RoutedEventArgs e)
        {
            s = 0;
            cts.Cancel();
            Stop_Anti_Afk.IsEnabled = false;
        }

        private void Start_Left_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Stop_Left_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}



