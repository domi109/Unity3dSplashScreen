//--------------------------------------------------------------------------------------//
// don't forget to put Unity script in to start scene ideally into an empty game object
//--------------------------------------------------------------------------------------//

//--------------------------------------------------------------------------------------//
// this is public domain source code by Domi Rosenberger
//--------------------------------------------------------------------------------------//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GAME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //--------------------------------------------------------------------------------------//
        // launch game from sub-folder 
        //--------------------------------------------------------------------------------------//
        private void Form1_Load(object sender, EventArgs e)
        {
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = (@"Game\Unity.exe");
            ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            ExternalProcess.Start();
        }

        //--------------------------------------------------------------------------------------//
        // wait a while to have enough time for the game to launch, then close the splash screen
        //--------------------------------------------------------------------------------------//
        private void timer1_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }        
    }
}
