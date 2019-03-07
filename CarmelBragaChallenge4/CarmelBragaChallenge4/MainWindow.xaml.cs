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

namespace CarmelBragaChallenge4
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

        bool firstButtonClicked = false;
        bool secondButtonClicked = false;

        public int firstRandomNumber()
        {
            Random rnd = new Random();
            int firstNum = rnd.Next(0, 100);
            return firstNum;
        }

        public int secondRandomNumber()
        {
            Random rnd = new Random();
            int secondNum = rnd.Next(0, 100);
            return secondNum;
        }

        private void buttonOneClick(object sender, EventArgs e)
        {
            int n1 = firstRandomNumber();
            int n2 = secondRandomNumber();

            BoxOne.Text = n1.ToString();
            BoxTwo.Text = n2.ToString();

            firstButtonClicked = true;
            secondButtonClicked = false;

            if(n1 > n2)
            {
                int r = 0;
                r++;
                RightBox.Text = r.ToString();
            }else if(n2 > n1)
            {
                int w = 0;
                w++;
                WrongBox.Text = w.ToString();
            }
        }
          0
        private void buttonTwoClick(object sender,EventArgs e)
        {
            int n1 = firstRandomNumber();
            int n2 = secondRandomNumber();

            BoxOne.Text = n1.ToString();
            BoxTwo.Text = n2.ToString();

            firstButtonClicked = false;
            secondButtonClicked = true;

            if (n2 > n1)
            {
                int r = 0;
                r++;
                RightBox.Text = r.ToString();
            }
            else if (n1 > n2)
            {
                int w = 0;
                w++;
                WrongBox.Text = w.ToString();
            }

        }

    }

}

