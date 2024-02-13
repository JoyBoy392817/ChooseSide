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

namespace ChooseSide
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int score = 0;
        int correctAnswer;
        public MainWindow()
        {
            InitializeComponent();
            ResetRightAnswer();
        }
        void ResetRightAnswer() 
        {
            Random rnd = new Random();
            correctAnswer = rnd.Next(0, 2);
        }
        void ChangeBackground(Colors colors)
        {
            
        }
        void ChangeScore(bool increase)
        {

        }
        private void ButtonClick(int side)
        {
            if(side == correctAnswer)
            {
                ChangeScore(true);
                ChangeBackground( );
            }
            else
            {
                ChangeScore(false);
            }
        }
        private void btnRight_Click(object sender, RoutedEventArgs e)
        {
            ButtonClick(0);
        }
        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            ButtonClick(1);
        }
    }
}
