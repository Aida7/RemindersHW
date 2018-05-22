using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace Reminders
{

    /*Создать приложение-напоминалку.Пользователь может создавать таймер, 
    который будет запускаться раз в указанное время и предупреждать
    о каком-то деле, которое тоже задаёт пользователь.*/
   
    public partial class MainWindow : Window
    {
        
       
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void SaveButton_Clik(object sender, RoutedEventArgs e)
        {
            Timers timers = new Timers();
            List<Timers> list = new List<Timers>();
            Dispatcher.Invoke(() =>
            {

                timeNow.Text = DateTime.Now.ToLongTimeString();
            });
            timers.Text = text.Text;

            (from number
                          in list.AsParallel()
             where number.TimeSecond==DateTime.Now
             select number).ForAll(number => MessageBox.Show(text.Text));
        }
        

    }
}
