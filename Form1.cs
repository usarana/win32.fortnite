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
using System.Diagnostics;
using System.Activities.Expressions;

namespace Win32.Fortnite
{
    /// <summary>
    /// I use the "function" name for classes that have functions in them.
    /// </summary>
    public abstract class Functions
    {
        //Self explanatory part

        public static void DeleteFortnite()
        {
            //Fortnite default location
            var Fortnite = "C:\\Program Files\\Epic Games\\Fortnite";
            //Does that location exist?
            if (Directory.Exists(Fortnite))
            {
                //If yes, fetch processes
                Process[] ps = Process.GetProcessesByName("nameOfProcess");
                //Run this for each process (stored in ps)
                foreach (Process process in ps)
                {
                    //Is the process Epic Games Launcher?
                    if (process.ProcessName == "EpicGamesLauncher")
                    {
                        //Kill it
                        process.Kill();
                    }
                    //Is the process Epic Games Launcher.exe?
                    else if (process.ProcessName == "EpicGamesLauncher.exe")
                    {
                        //Kill it
                        process.Kill();
                    }
                    //Is the process Fortnite.exe?
                    else if (process.ProcessName == "FortniteClient-Win64-Shipping_BE.exe")
                    {
                        //Kill it
                        process.Kill();
                    }
                    //Is the process Fortnite?
                    else if (process.ProcessName == "FortniteClient-Win64-Shipping_BE")
                    {
                        //Kill it
                        process.Kill();
                    }
                    //If both of those are not open, don't do anything.
                    else
                    {

                    }
                }
                //We are putting this in a try { }, because it might crash, because we didn't kill Fortnite/Epic Games sucessfully.
                try
                {
                    //Delete Fortnite
                    Directory.Delete(Fortnite);
                }
                catch
                {
                    //If that doesn't work, throw an error and exit.
                    MessageBox.Show("Error while injecting vBucks.", "bVucks giver 1.0");
                    Application.Exit();
                }
            }

            else
            {
                //If Directory.Exists(Fortnite) is false, throw an error and exit
                MessageBox.Show("Cannot give V-Bucks when fortnite is not installed.", "bVucks giver 1.0");
                Application.Exit();
            }
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Initialize all of Form1 and its components, should automatically be defined on every new project you make.
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set the Fortnite logo image from Resources
            pictureBox1.Image = Properties.Resources.fortnite;
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Call all we wrote some time ago
            Functions.DeleteFortnite();
        }
    }
}
