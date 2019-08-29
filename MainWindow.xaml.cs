using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
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
        int s_click = 0;
        InputSimulator sim = new InputSimulator();
        CancellationTokenSource cts = new CancellationTokenSource();
        CancellationTokenSource cts_click = new CancellationTokenSource();

        public MainWindow()
        {
            InitializeComponent();

            Stop_Anti_Afk.IsEnabled = false;
            Stop_Click.IsEnabled = false;
        }

        // KEYBOARD BUTTONS ********************************************************

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

        // CLICK BUTTONS ********************************************************

        public async void ClickTaskDelay(CancellationToken token)
        {
            while (s_click == 1)
            {

                sim.Mouse.RightButtonClick();

                if (s_click == 0)
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

        private void Start_Right_Click(object sender, RoutedEventArgs e)
        {
            s_click = 1;
            ClickTaskDelay(cts_click.Token);
            Stop_Click.IsEnabled = true;
        }

        private void Stop_Right_Click(object sender, RoutedEventArgs e)
        {
            s_click = 0;
            cts_click.Cancel();
            Stop_Click.IsEnabled = false;
        }
    }
}
