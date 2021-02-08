// Last Modified By:    
// Last Modified Date:  February 7, 2021

// Author:  Kyle Chapman
// Date:    February 7, 2021
// Description:
//  It's a tic-tac-toe game! Is that supposed to be hypenated?
//  There are 9 buttons in a 2D array. When clicked, they are assigned
//  a letter based on whoever's turn it is and disabled.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class formTicTacToe : Form
    {
        #region "Declarations"

        // This boolean value shows whether it's X's turn; otherwise it's O's turn.
        bool isTurnX = true;
        // This boolean value represents the win condition.
        bool isWinner = false;
        // Here's an array of buttons, representing the squares on the board.
        Button[,] squares;

        #endregion

        public formTicTacToe()
        {
            InitializeComponent();
            
            // When the form is loaded, assign the Buttons to the array.
            squares = new Button[,]
            {
                   {buttonRow0Column0,buttonRow0Column1, buttonRow0Column2 },
                {buttonRow1Column0, buttonRow1Column1, buttonRow1Column2 },
                {buttonRow2Column0, buttonRow2Column1, buttonRow2Column2 }

            };
        }

        #region "Event Handlers"
        
        /// <summary>
        /// When a button is clicked, assign it a letter, disable the button, and if there was no winner change the turn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TicTacToeSquareClick(object sender, EventArgs e)
        {
            // This next line casts the generic object "sender" to a Button.
            // This happens to work because this event handler is only active on buttons.
            Button buttonClicked = (Button)sender;

            // Set the text on the button.
            if (isTurnX)
            {
                buttonClicked.Text = "X";
            }
            else
            {
                buttonClicked.Text = "O";
            }

            // Disable the button.
            buttonClicked.Enabled = false;

            // Evaluate whether somebody won.
            EvaluateWin();
            
            // Don't swap turns if somebody has won!
            if (!isWinner)
            {
                // Swap turns.
                ChangeTurn();
            }

            // Put the focus on the Reset button.
            buttonReset.Focus();
        }

        /// <summary>
        /// The Reset button clears things and re-enables controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            SetDefaults();
        }

        #endregion

        #region "Functions"

        /// <summary>
        /// This clears the text property of all controls in the array of controls that is passed in
        /// </summary>
        /// <param name="controlArray">An array of controls with a text property to clear</param>
        private void ClearControls(Control[,] controlArray)
        {
            // For every control in the list that is passed in, empty its text property.
            foreach (Control controlToClear in controlArray)
            {
                controlToClear.Text = String.Empty;
            }
        }

        /// <summary>
        /// This enables or disables all controls in the array that is passed in.
        /// </summary>
        /// <param name="controlArray">An array of controls to enable or disable</param>
        /// <param name="enabledStatus">Boolean: set controls to enabled?</param>
        private void SetControlsEnabled(Control[,] controlArray, bool enabledStatus)
        {
            // For every control in the list that is passed in, empty its text property.
            foreach (Control controlToClear in controlArray)
            {
                controlToClear.Enabled = enabledStatus;
            }
        }

        /// <summary>
        /// Clears things and re-enables controls.
        /// </summary>
        private void SetDefaults()
        {
            // Clear all buttons.
            ClearControls(squares);
            // Re-enabled and controls that may be disabled.
            SetControlsEnabled(squares, true);
            // Ensure that there is no winner.
            isWinner = false;
            // ChangeTurn resets the status label and gives the loser the first turn.
            ChangeTurn();
        }

        /// <summary>
        /// If it's currently X's turn, change it to O's turn, and vice-versa.
        /// </summary>
        private void ChangeTurn()
        {
            // Set this boolean value to the opposite of itself. "isTurnX equals not isTurnX".
            isTurnX = !isTurnX;

            if (isTurnX)
            {
                labelGameStatus.Text = "X's Turn";
            }
            else
            {
                labelGameStatus.Text = "O's Turn";
            }
        }

        /// <summary>
        /// Determine if the current player has won.
        /// </summary>
        private void EvaluateWin()
        {

        // **************************************
        // This is the part where you code stuff!
        // **************************************

        // First, check all rows.
        // Use a For loop to check if all boxes in the same dimension
        // have the same value - doesn't even matter what the value is
        // as long as it's the same!
        
            for (int rowCount = 0; rowCount < squares.GetUpperBound(0); rowCount++)
            {
                // What does "GetUpperBound(0)" mean above?

                // Something to do with squares(rowCount,0), squares(rowCount,1), etc.
                // How can we analyze the rows to figure out if someone wins?
                // When someone wins, set isWinner = true;.
            }

            // Next, check all columns. This will be done pretty much the same way as the rows.
            
            // Finally, we have to check the two diagonals.
            // It is not going to save us any work to use loops
            // so let's just do it like this:
            if (squares[0, 0].Text != String.Empty &&
                squares[0, 0].Text == squares[1, 1].Text &&
                squares[0, 0].Text == squares[2, 2].Text)
            {
                isWinner = true;
            }
            else if(squares[0, 2].Text != String.Empty &&
                squares[0, 2].Text == squares[1, 1].Text &&
                squares[0, 2].Text == squares[2, 0].Text)
            {
                isWinner = true;
            }

            // **************************************************
            // Here are some notes about extra stuff you can try.
            // **************************************************

            // You don't have to do any of these things but here are several added value features... for bonus marks!
            // Do one of these for a +0.5 and two of them for a +1.

            // 1) If you want to get a little bit fancy...
            // Make the winning line show up in a different colour!

            // 2) If you want to get even fancier...
            // Make this generate a relevant message when the game is a draw/tie game! (cat game?)

            // 3) If you want to get *super* fancy...
            // Could you make a 4x4 board? Or a 5x5 board?

            // 4) If you like efficiency...
            // How could you do everything in the EvaluateWin() function within a single loop?

            // 5) Holy crap you must want to make your life difficult for yourself if you pick this option:
            // Can you make it so that you can use arrow keys to move between the different squares in a natural way?

            // *********************************************
            // This is the part where you stop coding stuff!
            // *********************************************

            // If there's a winner, show who it is!
            if (isWinner)
            {
                if (isTurnX)
                {
                    labelGameStatus.Text = "X wins!";
                }
                else
                {
                    labelGameStatus.Text = "O wins!";
                }

                // Disable all squares to prevent further play.
                SetControlsEnabled(squares, false);
            }
        }

        #endregion

    }
}
