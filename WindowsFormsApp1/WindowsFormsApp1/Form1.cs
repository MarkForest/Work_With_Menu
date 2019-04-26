using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Color defaultColor = new Color();
        Color defaultFontColor = new Color();
        ContextMenu cm = null;
        public Form1()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            defaultColor = this.BackColor;
            defaultFontColor = this.ForeColor;
            menuStrip2.Visible = false;
            cm = new ContextMenu();
            MenuItem item = new MenuItem("Open");
            MenuItem item2 = new MenuItem("Rus");
            MenuItem item3 = new MenuItem("Eng");
            cm.MenuItems.Add(item);
            cm.MenuItems.Add(item2);
            cm.MenuItems.Add(item3);
            textBox1.ContextMenu = cm;
            item.Click += openToolStripMenuItem_Click;
            item2.Click += russiaToolStripMenuItem_Click;
            item3.Click += englishToolStripMenuItem_Click;



        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(dialog.FileName);
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true ;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, textBox1.Text);
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.White;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
            textBox1.ForeColor = Color.White;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = defaultColor;
            textBox1.ForeColor = defaultFontColor;
        }

        private void russiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip2.Visible = true;
            menuStrip1.Visible = false;

        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip2.Visible = false;
            menuStrip1.Visible = true;
        }
    }
}
