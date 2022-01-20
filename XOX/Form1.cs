using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOX
{
    public partial class Form1 : Form
    {
        //variable that stores the sign of player that is on the move
        private string playeronthemove = "X";
        //variable that shows if someone won the game
        private bool someoneWon = false;
        public Form1()
        {
            InitializeComponent();
            //Text shown in text box on the begining
            txtPlayerOntTheMove.Text= "PLAYER X IS PLAYING NOW ";
        }

        //event after click on any button
        private void buttons_click(object sender,EventArgs e)
        {
            var button = (Button)sender;
            //if player x is on move and this button text is clear
            if (playeronthemove == "X" && button.Text == "" && someoneWon==false)
            {
                //button text will be "X"
                button.Text = "X";
                //if any of this options is true it is the end of the game and app will show us message box
                if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
                   button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
                   button3.Text == "X" && button6.Text == "X" && button9.Text == "X" ||
                   button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
                   button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
                   button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
                   button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
                   button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                {
                    someoneWon = true;
                    //in message box we have options to click yes or no
                    DialogResult dialogResult = MessageBox.Show("PLAYER X WON!!! \n Do you want to play again??", "END OF THE GAME", MessageBoxButtons.YesNo);
                    //if we click on yes,text of all buttons will be empty string and player on the move will be player X
                    if (dialogResult == DialogResult.Yes)
                    {
                        button1.Text = "";
                        button2.Text = "";
                        button3.Text = "";
                        button4.Text = "";
                        button5.Text = "";
                        button6.Text = "";
                        button7.Text = "";
                        button8.Text = "";
                        button9.Text = "";
                        playeronthemove = "X";
                    }
                    //if we click on no the application will close
                    else if (dialogResult == DialogResult.No)
                    {
                        System.Diagnostics.Process.GetCurrentProcess().Kill();
                    }
                }
                else if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != ""
                && button7.Text != "" && button8.Text != "" && button9.Text != "" && someoneWon == false)
                {
                    //in message box we have options to click yes or no
                    DialogResult dialogResult = MessageBox.Show("ITS A DRAW!!! \n Do you want to play again??", "END OF THE GAME", MessageBoxButtons.YesNo);
                    //if we click on yes,text of all buttons will be empty string and player on the move will be player X
                    if (dialogResult == DialogResult.Yes)
                    {
                        button1.Text = "";
                        button2.Text = "";
                        button3.Text = "";
                        button4.Text = "";
                        button5.Text = "";
                        button6.Text = "";
                        button7.Text = "";
                        button8.Text = "";
                        button9.Text = "";
                        playeronthemove = "X";
                    }
                    //if we click on no the application will close
                    else if (dialogResult == DialogResult.No)
                    {
                        System.Diagnostics.Process.GetCurrentProcess().Kill();
                    }
                }
                //if it is not the end of the game ,player Y is on the move
                else
                {
                    playeronthemove = "Y";
                    txtPlayerOntTheMove.Text = "PLAYER Y IS PLAYING NOW ";
                }
            }
            //If player Y is on move and this button text is clear
            else if (playeronthemove == "Y" && button.Text == "" && someoneWon==false)
            {
                //button text will be "Y"

                button.Text = "Y";
                //if any of this options is true it is the end of the game and app will show us message box
                if (button1.Text == "Y" && button4.Text == "Y" && button7.Text == "Y" ||
                    button2.Text == "Y" && button5.Text == "Y" && button8.Text == "Y" ||
                    button3.Text == "Y" && button6.Text == "Y" && button9.Text == "Y" ||
                    button1.Text == "Y" && button2.Text == "Y" && button3.Text == "Y" ||
                    button4.Text == "Y" && button5.Text == "Y" && button6.Text == "Y" ||
                    button7.Text == "Y" && button8.Text == "Y" && button9.Text == "Y" ||
                    button1.Text == "Y" && button5.Text == "Y" && button9.Text == "Y" ||
                    button3.Text == "Y" && button5.Text == "Y" && button7.Text == "Y")
                {
                    someoneWon = true;
                    //in message box we have options to click yes or no
                    DialogResult dialogResult = MessageBox.Show("PLAYER Y WON!!! \n Do you want to play again??", "END OF THE GAME", MessageBoxButtons.YesNo);
                    //if we click on yes,text of all buttons will be empty string and player on the move will be player X
                    if (dialogResult == DialogResult.Yes)
                    {
                        button1.Text = "";
                        button2.Text = "";
                        button3.Text = "";
                        button4.Text = "";
                        button5.Text = "";
                        button6.Text = "";
                        button7.Text = "";
                        button8.Text = "";
                        button9.Text = "";
                        playeronthemove = "X";
                        someoneWon = false;
                    }
                    //if we click on no the application will close
                    else if (dialogResult == DialogResult.No)
                    {
                        System.Diagnostics.Process.GetCurrentProcess().Kill();
                    }
                }
                else if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != ""
                && button7.Text != "" && button8.Text != "" && button9.Text != "" && someoneWon == false)
                {
                    //in message box we have options to click yes or no
                    DialogResult dialogResult = MessageBox.Show("ITS A DRAW!!! \n Do you want to play again??", "END OF THE GAME", MessageBoxButtons.YesNo);
                    //if we click on yes,text of all buttons will be empty string and player on the move will be player X
                    if (dialogResult == DialogResult.Yes)
                    {
                        button1.Text = "";
                        button2.Text = "";
                        button3.Text = "";
                        button4.Text = "";
                        button5.Text = "";
                        button6.Text = "";
                        button7.Text = "";
                        button8.Text = "";
                        button9.Text = "";
                        playeronthemove = "X";
                        someoneWon = false;
                    }
                    //if we click on no the application will close
                    else if (dialogResult == DialogResult.No)
                    {
                        System.Diagnostics.Process.GetCurrentProcess().Kill();
                    }
                }
                else
                {
                    playeronthemove = "X";
                    txtPlayerOntTheMove.Text = "PLAYER X IS PLAYING NOW ";
                }
            }
           
            else
            {
                MessageBox.Show("Error");
            }
                
            

        }

    }
}
