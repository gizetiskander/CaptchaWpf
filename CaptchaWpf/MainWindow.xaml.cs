using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;

using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CaptchaWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string TxT = String.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }
         
        

        private void SendBtn_Click(object sender, RoutedEventArgs e)
        {
            if (CaptchaTB.Text == ResultTB.Text)
            {
                MessageBox.Show("Верно!");
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void UpdBtn_Click(object sender, RoutedEventArgs e)
        {
            string allow = " ";

            allow = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";

            allow += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";

            allow += "1,2,3,4,5,6,7,8,9,0";

            char[] a = { ',' };

            string[] arr = allow.Split(a);

            string res = " ";

            string temp = " ";

            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
            {
                temp = arr[(rnd.Next(0, arr.Length))];
                res += temp;
            }
            CaptchaTB.Text = res.Trim();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string allow = " ";

            allow = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";

            allow += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";

            allow += "1,2,3,4,5,6,7,8,9,0";

            char[] a = { ',' };

            string[] arr = allow.Split(a);

            string res = " ";

            string temp = " ";

            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
            {
                temp = arr[(rnd.Next(0, arr.Length))];
                res += temp;
            }
            CaptchaTB.Text = res.Trim();
        }
    }
}
