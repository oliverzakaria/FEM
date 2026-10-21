using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamplePortalClientUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            //panelHeader2.Height= Screen.PrimaryScreen.WorkingArea.Height-500;
        }
        bool header1 = true;
        bool header2 = true;
        bool header3 = true;
        private void label239_Click(object sender, EventArgs e)
        {
            if (header1)
            {
                header1 = false;
                label239.Text = "-";
                Detail1.Visible = false;
                Header22.Location = new Point(Header11.Location.X, Header11.Location.Y + Header11.Height + 5);
                Detail2.Location = new Point(Header11.Location.X, Header22.Location.Y + Header22.Height);
                Header33.Location = new Point(Header11.Location.X, Detail2.Location.Y + Detail2.Height + 5);
                Detail3.Location = new Point(Header11.Location.X, Header33.Location.Y + Header33.Height);
            }
            else
            {
                header1 = true;
                label239.Text = "+";
                Detail1.Visible = true;
                Header22.Location = new Point(Header11.Location.X, Detail1.Location.Y + Detail1.Height + 5);
                Detail2.Location = new Point(Header11.Location.X, Header22.Location.Y + Header22.Height);
                Header33.Location = new Point(Header11.Location.X, Detail2.Location.Y + Detail2.Height + 5);
                Detail3.Location = new Point(Header11.Location.X, Header33.Location.Y + Header33.Height);
            }

        }

      

        private void label243_Click(object sender, EventArgs e)
        {
            if (header2)
            {
                header2 = false;
                label243.Text = "-";
                Detail2.Visible = false;
                Header33.Location = new Point(Header11.Location.X, Header22.Location.Y + Header22.Height + 5);
                Detail3.Location = new Point(Header11.Location.X, Header22.Location.Y + Header22.Height + Header33.Height);
            }
            else
            {
                header2 = true;
                label243.Text = "+";
                Detail2.Visible = true;
                Header33.Location = new Point(Header11.Location.X, Detail3.Height + Header22.Location.Y + Header22.Height + 5);
                Detail3.Location = new Point(Header11.Location.X, Detail3.Height + Header22.Location.Y + Header22.Height + Header33.Height);
            }
        }

        private void label266_Click(object sender, EventArgs e)
        {
            if (header3)
            {
                header3 = false;
                label266.Text = "-";
                Detail3.Visible = false;
            }
            else
            {
                header3 = true;
                label266.Text = "+";
                Detail3.Visible = true;
            }
        }
    }
}
