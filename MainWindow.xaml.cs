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

namespace Monopoly
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {




        class Player
        {
            public string Name { get; set; }
            public double Cash {get; set;}
            public int Position { get; set; }

           public Player(string name,double cash, int position)
            {
                this.name = name;
                this.cash = cash;
                this.position = position;
            }

            public string name;
            public double  cash;
            public int position;
                
        }//End of class player

       
        public int turnCount;
        
       
        public static string nameOne;
        public static string nameTwo;
    
        public MainWindow()
        {
            InitializeComponent();

        }


       
    
    private void button_Click(object sender, RoutedEventArgs e)
        {
            nameOne = tbName1.Text;
            nameTwo = tbName2.Text;

            if ((nameOne.Length>2) || (nameTwo.Length>2))
            {
                MessageBox.Show("Add a player, cant player alone ");
                return;
            }
            MessageBox.Show("Ok, Lets Start");
               tbName1.IsEnabled = false;
               tbName2.IsEnabled = false;
            
    }//end of button_Click

    Player playerOne = new Player(nameOne, 1000.00, 1);
    Player playerTwo = new Player(nameTwo, 1000.00, 1);


        private void btRollDice_Click(object sender, RoutedEventArgs e)
        {
            int result;
            Random rnd = new Random();

            result = rnd.Next(1, 7);
            int result1 = rnd.Next(1, 7);
            int sumDice = result + result1;

            MessageBox.Show("Player move "+sumDice+" squares");
            if (turnCount % 2 == 0)
            {
               
            }
            else
            {
                
            }
            turnCount++;
        }//end of roll dice

        private void btNext_Click(object sender, RoutedEventArgs e)
        {


            if (turnCount % 2 == 0)
            {
                MessageBox.Show("Roll The Dice", playerOne.Name);
            }
            else {
                MessageBox.Show("Roll The Dice", playerTwo.Name);
            }





        }//end of end button




    }//end of main window
}
