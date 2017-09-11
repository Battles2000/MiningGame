using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Game_v._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setup();
        }

        /*
         * 
         * chicken, steak sweet potato
         * turkey quinwa 200g
         * fish brown rice 200g
         * 
         * 
         * water first brown rice
         * quinwa water last
         * 
         */

        public List<Element> elements = new List<Element>();

        public string name = "";
        public ElementNames en = new ElementNames();
        public Random rand = new Random();

        public DateTime date = DateTime.Today;

        public void setup()
        {
            if (File.Exists("prevDate.txt") == false)
                saveInt(date.Date.Day, "prevDate.txt");

            for (int i = 0; i < 63; i++)
            {
                Element temp = new Element();
                temp.name = en.elementNames[i];
                int tempRand = rand.Next(2) + 1;
                if (tempRand == 1)
                    temp.stockGood = true;
                else if (tempRand == 2)
                    temp.stockGood = false;
                if (temp.stockGood == true)
                    temp.stockPrice = rand.Next(-10, -1);
                else if (temp.stockGood == false)
                    temp.stockPrice = rand.Next(1, 10);
                temp.ID = i;

                elements.Add(temp);
            }
            //Console.WriteLine("Date: " + date.Day);

            int prevDate = loadInt("prevDate.txt");
            if(true) {
                for(int i = 0; i < elements.Count(); i++) 
                {
                    //Console.WriteLine(elements[i].name);
                    //Console.WriteLine(elements[i].ID);
                    //Console.WriteLine(elements[i].stockGood);
                    //Console.WriteLine(elements[i].stockPrice);
                }
            }
           
        }

        public void focus()
        {
            label1.Focus();
        }

        // Save and Load
        public void save()
        {
            saveString(name, "name.txt"); 
        }

        public void load()
        {
            name = loadString("name.txt");

            nameLabel.Text = name;
        }

        #region Save Functions
        public void saveInt(int save, string loc)
        {
            TextWriter tw = new StreamWriter(loc);
            
            tw.WriteLine(save);
 
            tw.Close();
        }

        public void saveBool(bool save, string loc)
        {
            TextWriter tw = new StreamWriter(loc);

            tw.WriteLine(save);

            tw.Close();
        }

        public void saveString(string save, string loc)
        {
            TextWriter tw = new StreamWriter(loc);

            tw.WriteLine(save);

            tw.Close();
        }

        public int loadInt(string loc)
        {
            StreamReader sm = new StreamReader(loc);

            return Int32.Parse(sm.ReadLine());
        }

        public bool loadBool(string loc)
        {
            StreamReader sm = new StreamReader(loc);

            return bool.Parse(sm.ReadLine());
        }

        public string loadString(string loc)
        {
            StreamReader sm = new StreamReader(loc);

            return sm.ReadLine();
        }
        #endregion

        // Main Load
        private void Form1_Load(object sender, EventArgs e)
        {	
            load();
            hideMenu();
            hideOption(0);
        }
        
        public void CollectResource(object sender, EventArgs e) {
        	string temp = (sender as Button).Text;
        	// 1
        	if(temp == "Lithium") {
        		focus();
        		
        		Console.WriteLine("Lithium Pressed");
        	}
        	// 2
        	if(temp == "Beryllium") {
        		focus();
        		
        		Console.WriteLine("Beryllium Pressed");
        	}
            // 3
        	if(temp == "Sodium") {
                focus();
                
        		Console.WriteLine("Sodium");
        	}
            // 4
        	if(temp == "Magnesium") {
                focus();
                
        		Console.WriteLine("Magnesium");
        	}
            // 5
        	if(temp == "Aluminum") {
                focus();
                
        		Console.WriteLine("Aluminum");
        	}
            // 6
        	if(temp == "Potassium") {
                focus();
                
        		Console.WriteLine("Potassium");
        	}
            // 7
        	if(temp == "Calcium") {
                focus();
                
        		Console.WriteLine("Calcium");
        	}
            // 8
        	if(temp == "Scandium") {
                focus();
                
        		Console.WriteLine("Scandium");
        	}
            // 9
        	if(temp == "Titanium") {
                focus();
                
        		Console.WriteLine("Titanium");
        	}
            // 10
        	if(temp == "Vandium") {
                focus();
                
        		Console.WriteLine("Vandium");
        	}
            // 11
        	if(temp == "Chromium") {
                focus();
                
        		Console.WriteLine("Chromium");
        	}
            // 12
        	if(temp == "Manganese") {
                focus();
                
        		Console.WriteLine("Manganese");
        	}
            // 13
        	if(temp == "Iron") {
                focus();
                
        		Console.WriteLine("Iron");
        	}
            // 14
        	if(temp == "Cobalt") {
                focus();
                
        		Console.WriteLine("Cobalt");
        	}
            // 15
        	if(temp == "Nickel") {
                focus();
                
        		Console.WriteLine("Nickel");
        	}
            // 16
        	if(temp == "Copper") {
                focus();
                
        		Console.WriteLine("Copper");
        	}
            // 17
        	if(temp == "Zinc") {
                focus();
                
        		Console.WriteLine("Zinc");
        	}
            // 18
        	if(temp == "Gallium") {
                focus();
                
        		Console.WriteLine("Gallium");
        	}
            // 19
        	if(temp == "Rubidium") {
                focus();
                
        		Console.WriteLine("Rubidium");
        	}
            // 20
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 21
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 22
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 23
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 24
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 25
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 26
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 27
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 28
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 29
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 30
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 31
        	if(temp == "") {
        		focus();
                
                Console.WriteLine("");
        	}
            // 32
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 33
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 34
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 35
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 36
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 37
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 38
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 39
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 40
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 41
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 42
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 43
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 44
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 45
        	if(temp == "") {
                focus();
                
        		Console.WriteLine("");
        	}
            // 46
        	if(temp == "") {
                focus();
                
                Console.WriteLine("");
            }
            // 47
            if(temp == "") {
                focus();
                
                Console.WriteLine("");
            }
            // 48
            if(temp == "") {
                focus();
                
                Console.WriteLine("");
            }
            // 49
            if(temp == "") {
                focus();
                
                Console.WriteLine("");
            }
            // 50
            if(temp == "") {
                focus();
                
                Console.WriteLine("");
            }
            // 51
            if(temp == "") {
                focus();
                
                Console.WriteLine("");
            }
            // 52
            if(temp == "") {
                focus();
                
                Console.WriteLine("");
            }
            // 53
            if(temp == "") {
                focus();
                
                Console.WriteLine("");
            }
            // 54
            if(temp == "") {
                focus();
                
                Console.WriteLine("");
            }
            // 55
            if(temp == "") {
                focus();
                
                Console.WriteLine("");
            }
            // 56
            if(temp == "") {
                focus();
                
                Console.WriteLine("");
            }
            // 57
            if(temp == "") {
                focus();
                
                Console.WriteLine("");
            }
            // 58
            if(temp == "") {
                focus();
                
                Console.WriteLine("");
            }
            // 59
            if(temp == "") {
                focus();
                
                Console.WriteLine("");
            }
            // 60
            if(temp == "") {
                focus();
                
                Console.WriteLine("");
            }
            // 61
            if(temp == "") {
                focus();
                
                Console.WriteLine("");
            }
            // 62
            if(temp == "") {
                focus();
                
                Console.WriteLine("");
            }
            // 63
            if(temp == "") {
                focus();
                
                Console.WriteLine("");
            }
        }

        #region Options Menu
        // Option Menu hiding and such
        public void hideOption(int e)
        {
            if(e != 0)
                showMenu();

            // Option Buttons and Such
            exitOptionsBackButton.Visible = false;
            exitOptionsButton.Visible = false;
            nameTextBox.Visible = false;
            label2.Visible = false;
        }

        public void showOption()
        {
            hideMenu();

            // Option Buttons and Such
            exitOptionsBackButton.Visible = true;
            exitOptionsButton.Visible = true;
            nameTextBox.Visible = true;
            label2.Visible = true;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            nameLabel.Text = name;
        }

        private void exitOptionsBackButton_Click(object sender, EventArgs e)
        {
            hideOption(1);
        }

        private void exitOptionsButton_Click(object sender, EventArgs e)
        {
            hideOption(1);
        }
        #endregion

        #region Main Menu
        // Main menu hiding and such
        public void hideMenu()
        {
            exitMenuBackButton.Visible = false;

            // Menu Buttons
            exitMenuButton.Visible = false;
            loadButton.Visible = false;
            saveButton.Visible = false;
            optionsButton.Visible = false;
            saveExitButton.Visible = false;
            quitButton.Visible = false;

            focus();
        }

        public void showMenu()
        {
            exitMenuBackButton.Visible = true;

            // Menu Buttons
            exitMenuButton.Visible = true;
            loadButton.Visible = true;
            saveButton.Visible = true;
            optionsButton.Visible = true;
            saveExitButton.Visible = true;
            quitButton.Visible = true;

            focus();
        }

        // Menu Buttons
        private void exitMenuBackButton_Click(object sender, EventArgs e)
        {
            hideMenu();
            focus();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            showMenu();
            focus();
        }

        private void exitMenuButton_Click(object sender, EventArgs e)
        {
            hideMenu();
            focus();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            save();
            focus();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            load();
            focus();
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            showOption();
            focus();
        }

        private void saveExitButton_Click(object sender, EventArgs e)
        {
            save();
            Application.Exit();
            // focus();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // focus();
        }
        #endregion
        
    }
}