using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dungeon_Buddy
{
    public partial class MonsterIndexForm : Form
    {
        private const String FILE_PATH = "data\\5E Monster Spreadsheet.txt";
        private String[] ENVIRONMENTS = { "Arctic", "Coastal", "Desert", "Forest", "Grassland", "Hills", "Mountain", "Swamp", "Underdark", "Underwater", "Urban" };
        private String[] SIZES = { "Tiny", "Small/Huge", "Small", "Medium", "Large", "Huge", "Gargantuan" };
        private String[] TYPES = { "Aberration", "Beast", "Celestial", "Construct", "Dragon", "Elemental", "Fey", "Fiend", "Giant", "Humanoid", "Monstrosity", "Ooze", "Plant", "Undead" };

        private List<Monster> monsters = new List<Monster>();

        private const int NUMBER_OF_COLUMNS = 14;
        private DataTable monsterTable;

        public MonsterIndexForm()
        {
            InitializeComponent();

            foreach (String env in ENVIRONMENTS)
                environmentCB.Items.Add(env);

            foreach (String size in SIZES)
                sizeCB.Items.Add(size);

            foreach (String type in TYPES)
                typeCB.Items.Add(type);

            PopulateMonsterList(ImportTextFile(FILE_PATH));

            //Create a DataTable object, add columns, and populate it with rows from text file data
            monsterTable = new DataTable();
            GenerateDataTable();
            dataGridView1.DataSource = monsterTable;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
                col.MinimumWidth = 100;

            dataGridView1.AutoResizeColumns();
        }

        /*BELOW ARE METHODS RELATED TO PARSING THE INITIAL TEXT FILE*/

        //Takes a text file, and reads it line by line, returning the total line count
        private int TotalLines(String filePath)
        {
            using (StreamReader fileReader = new StreamReader(filePath))
            {
                int count = 0;
                while (fileReader.ReadLine() != null)
                {
                    count++;
                }
                return count;
            }
        }

        //Takes a text file, reads it line by line and returns a String Array of all lines in the text file
        private String[] ImportTextFile(String filePath)
        {
            String[] textData = new String[TotalLines(FILE_PATH)];

            using (StreamReader fileReader = new StreamReader(filePath))
            {
                int index = 0;
                while (!fileReader.EndOfStream)
                {
                    textData[index] = (fileReader.ReadLine());
                    index++;
                }
            }
            return textData;
        }

        //Takes an individual line of text, Splits it by TAB and returns a String Array with Size NUMBER OF COLUMNS
        //When reading a Tab delimited text file, there ends up being extra tab characters per line, which is why this method takes a sub array from String.Split
        private String[] ParseRow(String row)
        {
            String[] subArray = new String[NUMBER_OF_COLUMNS];
            String[] tempArray = row.Split('\t');

            for (int index = 0; index < subArray.Length; index++)
            {
                subArray[index] = tempArray[index];
            }
            return subArray;
        }

        /*END OF METHODS RELATED TO TEXT FILES*/

        //Takes a String Array and populates a list of Monsters from the data
        private void PopulateMonsterList(String[] data)
        {
            //Loop through each row of the String Array, parse each individual row, and create a monster from the values
            for (int index = 0; index < data.Length; index++)
            {
                string[] temp = ParseRow(data[index]);

                Monster monster = new Monster(index);
                monster.Name = temp[0];
                monster.NpcName = temp[1];
                monster.Size = temp[2];
                monster.MonsterType = temp[3];
                monster.Tag = temp[4];
                monster.Allignment = temp[5];
                monster.Environment = temp[6];

                if (double.TryParse(temp[7], out double cr))
                {
                    monster.ChallengeRating = cr;
                }
                else
                {
                    Console.WriteLine("CR could not be parsed");
                }

                if (double.TryParse(temp[8], out double xp))
                {
                    monster.XP = xp;
                }
                else
                {
                    Console.WriteLine("xp could not be parsed");
                }

                monster.Source = temp[9];
                monster.Page = temp[10];
                monster.Reference = temp[11];
                monster.Srd = temp[12];
                monster.Description = temp[13];

                //Add the monster to the list of monsters
                monsters.Add(monster);
            }

        }

        //First, create an object[] representing all the relavent Instance Variables to store in the Data Table
        //Second, Create a String[] representing all the relavent names of those Instance Variables to use as Column Names for the Data Table
        //Third, Crate a DataColumn[] representing all the columns in the Data Table, by getting the Names and Data Types from the String and Object arrays
        //Fourth, add the Data Columns to the Data Table
        //Fifth, Create a row for each Monster in the list from all the Instance Variables from GetData()
        private void GenerateDataTable()
        {
            //Gets the data[] from monster GetData() method. It is an object array of all the data fields in the monster class
            Object[] data = monsters[0].GetData();

            //Monster class has a method that returns all the Names of Instance Variables present in the GetData() method
            //This creates a String[] of the Names of those fields to then use as Column Names. 
            String[] columnNames = monsters[0].GetFields();

            //Create an array of Data Columns. Set the size to the number of Instance Variables in GetData() method
            DataColumn[] columns = new DataColumn[data.Length];

            //Loop through the columns array, creating a columm from the names in columnNames[] and the type of the data in the data[]
            for (int index = 0; index < columns.Length; index++)
            {
                columns[index] = new DataColumn(columnNames[index], data[index].GetType());
            }

            //Add data columns to the table
            foreach (DataColumn col in columns)
            {
                monsterTable.Columns.Add(col);
            }

            //Loops through each monster in the list, creating a row from the monsters Data
            foreach (Monster monster in monsters)
            {
                DataRow row = monsterTable.NewRow();
                for (int index = 0; index < data.Length; index++)
                {
                    row[index] = monster.GetData()[index];

                }
                monsterTable.Rows.Add(row);
            }
        }

        /*BELOW ARE METHODS RELATED TO THE DATA GRID VIEW*/

        //When a row selection changed event fires, display the information for the first selected row in the side text box
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //If no rows are selected, do nothing
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                richTextBox1.Text = monsters[index].ToString();
            }
        }

        private DataGridViewCell GetCell(string text, DataGridView dGV, int col)
        {
            DataGridViewCell cell = dGV.CurrentCell;

            foreach (DataGridViewRow row in dGV.Rows)
            {
                text.ToLower();
                String text2 = row.Cells[col].Value.ToString().ToLower();

                try
                {
                    if (row.Cells[col].Value != null && text == text2)
                        cell = row.Cells[col];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return cell;
        }

        /*END OF METHODS RELATED TO THE DATA GRID VIEW*/

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = GetCell(searchTB.Text, dataGridView1, 0);

        }

        private void CR_TB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CR_TB2_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchTB_Leave(object sender, EventArgs e)
        {
            searchTB.Text = "Search";
        }

        private void searchTB_Enter(object sender, EventArgs e)
        {
            if (searchTB.Text == "Search")
                searchTB.Text = "";
        }
    }

}
