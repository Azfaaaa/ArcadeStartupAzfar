using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace ArcadeStartupAzfar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            beginningLabel.Visible = false;
            fightLabel.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SoundPlayer cntdwn = new SoundPlayer(Properties.Resources._685903__elliottdj__3_2_1_fight);
            cntdwn.Play();
            Refresh();
            Thread.Sleep(1000);
            startButton.Visible = false;
            beginningLabel.Visible = true;
            Refresh();
            Thread.Sleep(500);
            polybiusLabel.Visible = false;
            Refresh();
            Thread.Sleep(500);

            polybiusLabel.Visible = true;
            beginningLabel.Text = "Game will begin in... 2";
            Refresh();

            Thread.Sleep(500);
            polybiusLabel.Visible = false;
            Refresh();

            Thread.Sleep(500);
            polybiusLabel.Visible = true;
            beginningLabel.Text = "Game will begin in... 1";
            Refresh();

            Thread.Sleep(500);
            polybiusLabel.Visible = false;
            beginningLabel.Visible = false;
            Refresh();

            Thread.Sleep(750);
            this.BackColor = Color.DarkRed;
            fightLabel.Visible = true;
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void fightLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
