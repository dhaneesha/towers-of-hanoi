// Author Simon Dacey
// Edited by Dhaneesha Rajakaruna 
// Date : Unknown

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Towers_of_Hanoi
{
    [Serializable()]
    class Board
    {
        public Disk[,] board; //2D array used as  map    
        ArrayList movements;
        Disk[] disks; //Array of disks

        const int poleStart = 228;
        const int poleGap = 180;
        const int deckHeight = 215;
        const int diskHeight = 24;

        private const int NUM_DISKS = 4;
        private const int NUM_PEGS = 3;

        public Board()
        {
            board = new Disk[NUM_PEGS, NUM_DISKS];
            movements = new ArrayList();

            //Array of disk objects
            disks = new Disk[NUM_DISKS];
            disks[0] = null;
            disks[1] = null;
            disks[2] = null;
            disks[3] = null;

            //Storing disk object into board array(Two dimensional arrray)
            board = new Disk[NUM_PEGS, NUM_DISKS]; //condition says TWO dimentional array  

            board[0, 3] = new Disk();
            board[0, 2] = new Disk();
            board[0, 1] = new Disk();
            board[0, 0] = new Disk();

            //Creating arraylist of movement 
            movements = new ArrayList();
        }

        //Alterntative constructor
        public Board(Disk d1, Disk d2, Disk d3, Disk d4)
        {
            //Storing into disks array
            disks = new Disk[NUM_DISKS];
            disks[0] = d1;
            disks[1] = d2;
            disks[2] = d3;
            disks[3] = d4;

            //Storing disk object into board array(Two dimensional arrray) 
            board = new Disk[NUM_PEGS, NUM_DISKS]; 
            board[0, 3] = d1;
            board[0, 2] = d2;
            board[0, 1] = d3;
            board[0, 0] = d4;

            //Arraylist of movement.
            movements = new ArrayList();
        }


        public void reset()
        {
            for (int iP = 0; iP < NUM_PEGS; iP++)
            {
                //Remove all elements from board array
                for (int iD = 0; iD < NUM_DISKS; iD++)
                {
                    board[iP, iD] = null;

                    //Update disks array
                    disks[iD].setPegNum(1);               
                    disks[iD].setLevel(NUM_DISKS  - iD);  
                }
            }

            //Reallocate elements 
            board[0, 3] = disks[0]; //Peg 1/Level4 
            board[0, 2] = disks[1]; //Peg 1/Level3 
            board[0, 1] = disks[2]; //Peg 1/Level2
            board[0, 0] = disks[3]; //Peg 1/Level1 

            //Remove all elements from movement arraylist
            movements.Clear();
            Display();
        }
        public void resetForReplay() // made a new function to reset for replay. The only difference i the movents array doesnt get cleared 
        {                            // Did so because simnoon said we cant change parameters to a function
            for (int iP = 0; iP < NUM_PEGS; iP++)
            {
                for (int iD = 0; iD < NUM_DISKS; iD++)
                {
                    board[iP, iD] = null;

                    disks[iD].setPegNum(1);                
                    disks[iD].setLevel(NUM_DISKS - iD);  
                }
            }

            board[0, 3] = disks[0]; 
            board[0, 2] = disks[1]; 
            board[0, 1] = disks[2];
            board[0, 0] = disks[3]; 


            Display();
        }

        public bool canStartMove(Disk aDisk)                //  this methode is suppose to check if a disk is free to move 
        {
            int currentlevel = aDisk.getLevel();
            int currentPeg = aDisk.getPegNum();

            if (currentlevel == 4)
            {
                return true;
            }

            else if (board[currentPeg-1, currentlevel] != null) 
            {
                return false;
            }
            return true;
        }


        public bool canDrop(Disk aDisk, int aPeg)
        {
            int newLevel = newLevInPeg(aPeg);

            if (newLevel == 0) // 0 will be new level if the peg is empty & if so return true
            {
                aDisk.setPegNum(aPeg)  ;   // if drop is possible the pegnumber will be changes to the new peg
                return true;
            }

            if (newLevel > 0 && newLevel < 4)
            {
                try
                {
                    Disk belowDisk = board[aPeg-1, newLevel - 1];
                    if (belowDisk.getDiameter() < aDisk.getDiameter())
                    {
                        MessageBox.Show("Cant place a large disk on a small disk");              // check the diameter of the last disk on peg
                        return false;
                    }
                    aDisk.setPegNum(aPeg);  // if drop is possible the pegnumber will be changes to the new peg
                    return true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }


        public void move(Disk aDisk, int newLevel) 
        {
            Label current = aDisk.getLabel();  // This methode require the pole to be set before getting here
            aDisk.setLevel(newLevel+1);

            int disksID =-1; // default value to reduce errors
            if ((aDisk.getLabel()).Name == "lblDisk1")  { disksID=0;}
            else if ((aDisk.getLabel()).Name == "lblDisk2")  { disksID=1;}
            else if ((aDisk.getLabel()).Name == "lblDisk3") { disksID = 2; }
            else if ((aDisk.getLabel()).Name == "lblDisk4") { disksID = 3; }

            DiskMove newMove = new DiskMove(disksID, aDisk.getPegNum() - 1);
            movements.Add(newMove); // adding the just made move to the movement list
            Display();
        }

        public void animatemove(Disk aDisk, int newLevel) //Methode for makin a move in animation
        {
            Label current = aDisk.getLabel();  // This methode require the pole to be set before getting here
            aDisk.setLevel(newLevel + 1);
            Display();
        }

        public string allMovesAsString()
        {
            string moves = "";
            foreach (DiskMove dm in movements) // runs a for each loop elements in movements
            {
                moves += dm.AsText() + "\n";
            }
            return moves; 
        }


        public void Display() // Used to change the positions of the labels
        {
            foreach (Disk d in disks)
            {
                Label current = d.getLabel();

                current.Hide();
                current.Left = poleStart + ((d.getPegNum() - 1) * poleGap) - (d.getDiameter() / 2);  
                current.Top = deckHeight - ((d.getLevel()-1) * diskHeight);
                current.Show();
            }
        }


        public Disk FindDisk(Label aLabel)
        {
            try
            {
                foreach (Disk d in disks)
                {
                    if (d != null)
                    {
                        if (d.getLabel() == aLabel)
                        {
                            return d;
                        }
                    }                    
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public int newLevInPeg(int pegNum)
        {
            for (int i = 0; i < NUM_DISKS; i++)
            {
                if (board[pegNum-1, i] == null) // checking for first empty slot in peg  , -1 because first peg is 0 
                {
                    return i;
                }
            }
            return -1; // return -1 if peg full
        }

 
        public String getText(int cnt) // I did not require this methode for my game
        {
            return "1";    // Dummy return to avoid syntax error - must be changed
        }


        public void backToSelected(int ind) // I did not require this methode for my game
        {

        }


        public int getPegInd(int ind) // I did not require this methode for my game
        {
             return 1;    // Dummy return to avoid syntax error - must be changed
        }


        public int getLevel(int ind) // I did not require this methode for my game
        {
            return 1;    // Dummy return to avoid syntax error - must be changed
        }


        public void unDo() // I did not require this methode for my game
        {

        }


        public void loadData(ArrayList dm) // Used to load the data from the text file
        {
            movements.Clear();
            foreach (string s in dm)
            {
                DiskMove move = new DiskMove(s);
                movements.Add(move);
            }

            for (int m = 0; m < movements.Count; m++)
            {
                animate( m);
            }
            
        }

        public bool checkWin()  // This methode was made to check if the user win by moving all the disks to the third peg
        { 
            for (int d = 0; d < NUM_DISKS; d++)
            {
                if (board[2, d] == null)
                {
                    return false;
                }               
            }
            return true;
        }

        public int animate(int step) // This methode will animate one step at a time. Works in a similar way to move methode
        {
                DiskMove dm = movements[step] as DiskMove;

                int diskIndex = dm.getDiskInd() ;
                int pegIndex = dm.getPegInd() +1 ;

                string Disk ="";

                if (diskIndex == 0) { Disk = "lblDisk1"; }  // Find the disk label name  
                else if (diskIndex == 1) { Disk = "lblDisk2"; }
                else if (diskIndex == 2) { Disk = "lblDisk3"; }
                else if (diskIndex == 3) { Disk = "lblDisk4"; }

                Disk animateDisk = new Disk();
                foreach (Disk d in disks)
                {
                    if ((d.getLabel()).Name == Disk)
                    {
                        animateDisk = d;
                    }                   
                }

                if (animateDisk == null) 
                    { return -1; } 


                int oldLevel, oldPeg;
                oldLevel = animateDisk.getLevel();
                oldPeg = animateDisk.getPegNum();

                animateDisk.setPegNum(pegIndex);
                this.board[oldPeg - 1, oldLevel - 1] = null;

                int newLevel = newLevInPeg(pegIndex);
                this.board[pegIndex-1 , newLevel] = animateDisk;
                this.animatemove(animateDisk, newLevel);

                if (step +1 == movements.Count)
                {
                    return 0; // Return 0 if there are no more moves left to be animated
                }
            return 1;
        }

        public bool save() // Used to save the values in movement list to a text file
        {
            if (movements.Count > 0)
            {
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"hanoiSave.txt"))
                {
                    foreach (DiskMove mv in movements)
                    {

                        file.WriteLine(mv.commaText());
                    }
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public bool hasMoves()  // To check if there are any items in movemnet array
        {
            if(movements.Count > 0)
            {
                return true;
            }
            return false;
        }
 
   }
}
