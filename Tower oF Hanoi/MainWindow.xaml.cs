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

namespace Tower_oF_Hanoi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // difficulty increases if n => 4
            // n = number of disks that have to be moved
            int n = 4;
        }

        void TOH (int n, char from_rod, char to_rod, char aux_rod)
        {
            // corresponding 4, A, C, B
            // then 3, A, B, C
            // then 3, B, C, A
            // then 2, A, C, B
            // then 2, C, B, A
            // then 1, A, B, C
            // then 1, B, C, A
            // this but in reverse

            if (n == 1)
            {
                Console.WriteLine("\n Move disk 1 from rod %c to rod %c", from_rod, to_rod);
                return;

                // https://www.youtube.com/watch?v=YstLjLCGmgg
            }

            TOH(n - 1, from_rod, aux_rod, to_rod);
            Console.WriteLine("\n move disk %d from rod %c to rod %c", n, from_rod, to_rod);
            TOH(n - 1, aux_rod, to_rod, from_rod);
        }

    }


}
