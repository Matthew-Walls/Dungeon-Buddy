using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Buddy
{
    class DiceRoll
    {
        // Set static array of valid die types for use in validation.
        private static readonly int[] VALIDDICE = new int[6] { 4, 6, 8, 10, 12, 20 };

        // This method can be used to get the results of a dice roll.
        public int Roll(int die, int count)
        {
            // Intialize variable to hold total value of dice roll.
            int total = 0;

            // Check that submitted die is a valid type.
            if (ValidateDie(die))
            {
                // Initialize resuable random object.
                Random rand = new Random();

                // Loop through count, adding a randomized result to total for each.
                for (int i = 0; i < count; i++)
                {
                    total += rand.Next(1, die + 1);
                }
            }
            else
            {
                MessageBox.Show("Invalid die type passed into DiceRoll.", "Error");
            }

            return total;
        }

        // This method can be called to validate the type of dice being rolled is valid.
        private bool ValidateDie(int die)
        {
            // Initialize  variable to hold boolean results.
            bool valid = false;

            // Loop through VALIDDICE array for match on passed die.
            foreach (int d in VALIDDICE)
            {
                if (die == d)
                {
                    valid = true;
                }
            }

            // Return validation result.
            return valid;
        }
    }
}
