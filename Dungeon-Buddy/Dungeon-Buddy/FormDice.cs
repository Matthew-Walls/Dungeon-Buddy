using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Buddy
{
    public partial class FormDice : Form
    {
        public FormDice()
        {
            InitializeComponent();
        }

        // Create DiceRoller instance.
        DiceRoll roll = new DiceRoll();

        static int SIZE = 3;
        int[] lastRoll = new int[SIZE];

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDice_Load(object sender, EventArgs e)
        {
            // Set comboSides items to valid dice from DiceRoll class.
            foreach (int i in roll.ValidDice)
            {
                comboSides.Items.Add(i.ToString());
            }
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            // Parse out entered values to local variables.
            int sides, number;

            if(int.TryParse(comboSides.Text, out sides) == false)
            {
                MessageBox.Show("Please select a valid integer for Sides!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(txtbxNumber.Text, out number) == false || number < 1)
            {
                MessageBox.Show("Please enter a valid postivie integer for Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Copy last roll to history list.
            if (lastRoll[0] != 0 || lastRoll[1] != 0)
            {
                lstbxRollHistory.Items.Add("d"+lastRoll[0].ToString()+" x "+lastRoll[1].ToString()+" = "+lastRoll[2].ToString());
            }

            // Roll the dice and display results!
            lblResults.Text = roll.Roll(sides, number).ToString();

            // Store whole roll in lastRoll[].
            lastRoll[0] = sides;
            lastRoll[1] = number;
            lastRoll[2] = int.Parse(lblResults.Text);
        }
    }
}
