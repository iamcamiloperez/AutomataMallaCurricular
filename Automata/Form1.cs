using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel0_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nota = Int32.Parse(comboBox1.Text);
            if (nota >= 30)
            {
                label9.Visible = true;
                comboBox9.Visible = true;
                label13.Visible = true;
                comboBox13.Visible = true;
            }
            else
            {
                label9.Visible = false;
                comboBox9.Visible = false;
                label13.Visible = false;
                comboBox13.Visible = false;
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nota = Int32.Parse(comboBox3.Text);
            if (nota >= 30)
            {
                label12.Visible = true;
                comboBox12.Visible = true;
            }
            else
            {
                label12.Visible = false;
                comboBox12.Visible = false;
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nota = Int32.Parse(comboBox9.Text);
            if (nota >= 30)
            {
                label17.Visible = true;
                comboBox17.Visible = true;
                label16.Visible = true;
                comboBox16.Visible = true;
            }
            else
            {
                label17.Visible = false;
                comboBox17.Visible = false;
                label16.Visible = false;
                comboBox16.Visible = false;
            }
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nota = Int32.Parse(comboBox12.Text);
            if (nota >= 30)
            {
                label19.Visible = true;
                comboBox19.Visible = true;
                label25.Visible = true;
                comboBox25.Visible = true;
            }
            else
            {
                label19.Visible = false;
                comboBox19.Visible = false;
                label25.Visible = false;
                comboBox25.Visible = false;

            }
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nota = Int32.Parse(comboBox13.Text);
            if (nota >= 30)
            {
                label20.Visible = true;
                comboBox20.Visible = true;
            }
            else
            {
                label20.Visible = false;
                comboBox20.Visible = false;
            }
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                int nota = Int32.Parse(comboBox16.Text);
                if (nota >= 30)
                {
                    label23.Visible = true;
                    comboBox23.Visible = true;
                }
                else
                {
                    label23.Visible = false;
                    comboBox23.Visible = false;
                }
            

        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {

                int nota = Int32.Parse(comboBox17.Text);
                if (nota >= 30)
                {
                    label24.Visible = true;
                    comboBox24.Visible = true;
                    label29.Visible = true;
                    comboBox29.Visible = true;
            }
                else
                {
                    label24.Visible = false;
                    comboBox24.Visible = false;
                    label29.Visible = true;
                    comboBox29.Visible = true;
            }

        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nota = Int32.Parse(comboBox19.Text);
            if (nota >= 30)
            {
                label26.Visible = true;
                comboBox26.Visible = true;
            }
            else
            {
                label26.Visible = false;
                comboBox26.Visible = false;
            }
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nota = Int32.Parse(comboBox20.Text);
            if (nota >= 30)
            {
                label27.Visible = true;
                comboBox27.Visible = true;
            }
            else
            {
                label27.Visible = false;
                comboBox27.Visible = false;
            }
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nota = Int32.Parse(comboBox21.Text);
            if (nota >= 30)
            {
                label28.Visible = true;
                comboBox28.Visible = true;
            }
            else
            {
                label28.Visible = false;
                comboBox28.Visible = false;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nota = Int32.Parse(comboBox5.Text);
            if (nota >= 30)
            {
                label30.Visible = true;
                comboBox30.Visible = true;
            }
            else
            {
                label30.Visible = false;
                comboBox30.Visible = false;
            }
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nota = Int32.Parse(comboBox25.Text);
            if (nota >= 30)
            {
                label33.Visible = true;
                comboBox33.Visible = true;
            }
            else
            {
                label33.Visible = false;
                comboBox33.Visible = false;
            }
        }

        private void comboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nota = Int32.Parse(comboBox29.Text);
            if (nota >= 30)
            {
                label35.Visible = true;
                comboBox35.Visible = true;
            }
            else
            {
                label35.Visible = false;
                comboBox35.Visible = false;
            }
        }

        private void comboBox31_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nota = Int32.Parse(comboBox31.Text);
            if (nota >= 30)
            {
                label36.Visible = true;
                comboBox36.Visible = true;
            }
            else
            {
                label36.Visible = false;
                comboBox36.Visible = false;
            }
        }

        private void comboBox30_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nota = Int32.Parse(comboBox30.Text);
            if (nota >= 30)
            {
                label44.Visible = true;
                comboBox44.Visible = true;
            }
            else
            {
                label44.Visible = false;
                comboBox44.Visible = false;
            }
        }

        private void comboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nota = Int32.Parse(comboBox27.Text);
            if (nota >= 30)
            {
                label45.Visible = true;
                comboBox45.Visible = true;
            }
            else
            {
                label45.Visible = false;
                comboBox45.Visible = false;
            }
        }

        private void comboBox42_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nota = Int32.Parse(comboBox42.Text);
            if (nota >= 30)
            {
                label49.Visible = true;
                comboBox49.Visible = true;
            }
            else
            {
                label49.Visible = false;
                comboBox49.Visible = false;
            }
        }

        private void comboBox38_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nota = Int32.Parse(comboBox38.Text);
            if (nota >= 30)
            {
                label51.Visible = true;
                comboBox51.Visible = true;
                label52.Visible = true;
                comboBox52.Visible = true;
            }
            else
            {
                label51.Visible = false;
                comboBox51.Visible = false;
                label52.Visible = true;
                comboBox52.Visible = true;
            }
        }

        private void comboBox48_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nota = Int32.Parse(comboBox48.Text);
            if (nota >= 30)
            {
                label53.Visible = true;
                comboBox53.Visible = true;
            }
            else
            {
                label53.Visible = false;
                comboBox53.Visible = false;
            }
        }
    }
}
