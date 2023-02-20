using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КрестикиНолики
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turnCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (turn)
            {
                b.BackColor = Color.Red;
            }
            else
                b.BackColor = Color.Green;
            turn = !turn;
            b.Enabled = false;
            turnCount++;
            CheckWinner();
        }
        private void CheckWinner()
        {
            bool win = false;
            if (X1.BackColor == X2.BackColor & X2.BackColor == X3.BackColor & !X1.Enabled) win = true;
            if (Y1.BackColor == Y2.BackColor & Y2.BackColor == Y3.BackColor & !Y1.Enabled) win = true;
            if (Z1.BackColor == Z2.BackColor & Z2.BackColor == Z3.BackColor & !Z1.Enabled) win = true;

            if (X1.BackColor == Y1.BackColor & Y1.BackColor == Z1.BackColor & !X1.Enabled) win = true;
            if (X2.BackColor == Y2.BackColor & Y2.BackColor == Z2.BackColor & !X2.Enabled) win = true;
            if (X3.BackColor == Y3.BackColor & Y3.BackColor == Z3.BackColor & !X3.Enabled) win = true;

            if (X1.BackColor == Y2.BackColor & Y2.BackColor == Z3.BackColor & !X1.Enabled) win = true;
            if (X3.BackColor == Y2.BackColor & Y2.BackColor == Z1.BackColor & !X3.Enabled) win = true;

            if (win)
            {
                if (turn)
                {
                    MessageBox.Show("Победа - Зелёный");
                }
                else
                {
                    MessageBox.Show("Победа - Красный");
                }

            }
            else if (turnCount == 9)
            {
                 MessageBox.Show("Ничья");
            }
        }
    }
}
