// Author Simon Dacey
// Edited by Dhaneesha Rajakaruna 
// Date : Unknown

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace Towers_of_Hanoi
{
    public partial class MainForm : Form
    {
        
        Board gameBoard;
        Disk currentDisk;
        int totMoves = 0;
        BinaryFormatter binFor;

        int i = 0;// this is a variable taken to control the replay step by step. i mean Index
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        int targetPeg;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int color = lblDisk1.BackColor.ToArgb();
            Disk disk1 = new Disk(lblDisk1, color, 4, 1);
            Disk disk2 = new Disk(lblDisk2, color, 3, 1);
            Disk disk3 = new Disk(lblDisk3, color, 2, 1);
            Disk disk4 = new Disk(lblDisk4, color, 1, 1);

            gameBoard = new Board(disk1, disk2, disk3, disk4);
            lblTotal.Text = "Total Moves : " + 0;
            txtMoves.Text = "Welcome to Hanoi                  To win you need to move all pegs from Peg 1 to Peg 3";
            binFor = new BinaryFormatter(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label lb = currentDisk.getLabel();
            lb.Left = 500;      
        }

        private void lblDisk1_MouseDown(object sender, MouseEventArgs e) 
        {            
            currentDisk = gameBoard.FindDisk(sender as Label);  // This code will get the label of the disk the user hold down
            Label aLabel = sender as Label;
            aLabel.DoDragDrop(aLabel, DragDropEffects.All);
        }

        private void lblPeg2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lblPeg2_DragDrop(object sender, DragEventArgs e)
        {
            if (!gameBoard.canStartMove(currentDisk))
            {
                MessageBox.Show("Sorry you may only move the top disk");
                return;
            }

            int oldLevel, oldPeg;
            oldLevel = currentDisk.getLevel() ;
            oldPeg = currentDisk.getPegNum() ;
            Label lb = sender as Label;

            if (lb.Name == "lblPeg1") { targetPeg = 1; }  
            else if (lb.Name == "lblPeg2") { targetPeg = 2; }
            else if (lb.Name == "lblPeg3") { targetPeg = 3; }
            else { targetPeg = -1; }

            if (oldPeg == targetPeg)
            {
                MessageBox.Show("Source peg and destination peg are both the same");
                return;
            }

            if (gameBoard.canDrop(currentDisk, targetPeg))
            {
                try
                {
                    gameBoard.board[oldPeg - 1, oldLevel - 1] = null; // Perform this action ONLY if the drop is valid

                    int newLevel = gameBoard.newLevInPeg(targetPeg);
                    gameBoard.board[targetPeg-1, newLevel] = currentDisk;
                    gameBoard.move(currentDisk, newLevel); // checking if a move is possille
                    totMoves ++;
                    lblTotal.Text = "Total Moves : " + totMoves;
                    txtMoves.Text = gameBoard.allMovesAsString();

                    if (gameBoard.checkWin())  // After a move checking if the user win
                    {
                        if (totMoves <= 15)
                        {
                            MessageBox.Show("You have successfully completed the game with the minimum number of moves");
                        }

                        if (totMoves > 15)
                        {
                            MessageBox.Show("Congratulations you won with '" + totMoves + "' moves. Lowest possible moves were : 15" );
                        }

                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)  // With reset the total moves will be cleared and text of lblTotal and txtMoves made to default
        {
            if (timer.Enabled)
            {
                MessageBox.Show("Please wait for animation to complete");
                return;
            }

            gameBoard.reset();
            totMoves = 0;
            lblTotal.Text = "Total Moves :" + totMoves;
            txtMoves.Text = "Welcome to Hanoi                  To win you need to move all Disks from Peg 1 to Peg 3";
        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e) // Menu item save game
        {
            if (gameBoard.save())
            {
                MessageBox.Show("Write Success");
            }
            else
            {
                MessageBox.Show("Write fail. Make some moves to write"); // Can only save a game if the user has made atleast one move. This is vallidated in Board object
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!gameBoard.hasMoves())
            {
                MessageBox.Show("No moves made");
                return;
            }

            gameBoard.resetForReplay();
            timer.Start();
            lblDisk1.Enabled = false;
            lblDisk2.Enabled = false;
            lblDisk3.Enabled = false;
            lblDisk4.Enabled = false;

        }

        private void timer_Tick(object sender, EventArgs e)  
        {
            int replayStat = gameBoard.animate(i);
            lblAnimation.Show();
            lblAnimation.Text = "Animation Moves :" + (i+1);
            if (replayStat == -1)
            {
                MessageBox.Show("Animation Error !!!", "Error");
            }
            if (replayStat == 0)
            {
                timer.Stop();
                lblAnimation.Hide();
                i = 0;
                MessageBox.Show("End of animation");
                lblDisk1.Enabled = true;
                lblDisk2.Enabled = true;
                lblDisk3.Enabled = true;
                lblDisk4.Enabled = true;

                return;
            }
            i++;
        }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e) // Menu Item Load Game
        {
            gameBoard.reset();
            totMoves = 0;

            ArrayList movements = new ArrayList();
            string[] lines = System.IO.File.ReadAllLines(@"hanoiSave.txt");
            
            foreach (string line in lines)
            {
                movements.Add(line);
            }

            if (movements.Count > 0)
            {
                gameBoard.loadData(movements);
                txtMoves.Text = gameBoard.allMovesAsString();
                lblTotal.Text = "Total Moves :" + lines.Length;
                totMoves = lines.Length;
            }
            else
            {
                MessageBox.Show("No moves found");
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e) // Menu Item New Game
        {
            gameBoard.reset();
            totMoves = 0;
            lblTotal.Text = "Total Moves :" + totMoves;
            txtMoves.Text = "Welcome to Hanoi                  To win you need to move all pegs from Peg 1 to Peg 3";
        }
    }
}
