using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diceproject
{
    public partial class Form1 : Form
    {
        private object lbxdiceRoll;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {       //Define a random generator that uses milliseconds as the seed       

                Random myrandom = new Random(DateTime.Now.Millisecond);

                //Create and set the values of the dice to 0
                int Dice1, Dice2, Dice3 = 0;
                int counter = 0;
                //We need a boolean,(True, False) to tell us when the values match
                bool RollDiceAgain = true; 

                //clear the listbox ready for a new roll run 
                lbxdiceroll.Items.Clear();
                do  //roll the dice while ....           
                {                 //pass the random number to two variables                  
                    Dice1 = myrandom.Next(1, 7);
                    Dice2 = myrandom.Next(1, 7);
                    Dice3 = myrandom.Next(1, 7);
                    counter++;
                    //Add them to the listview  

                    lbxdiceroll.Items.Add(Dice1 + " " + Dice2 + " " + Dice3);
                    lblOutput.Text = ("There were " + counter.ToString() + " rolls");

                    if ((Dice1 == Dice2) && (Dice2 == Dice3)) { RollDiceAgain = false; }
                } while (RollDiceAgain == true);
            }   
               // Here is the loop working while both dice are not != equal
        }
    }
}
