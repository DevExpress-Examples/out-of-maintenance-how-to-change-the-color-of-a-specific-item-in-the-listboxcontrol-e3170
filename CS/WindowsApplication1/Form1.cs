using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                checkedListBoxControl1.Items.Add(String.Format("Task{0}", i));
            }
        }

        private void checkedListBoxControl1_DrawItem(object sender, DevExpress.XtraEditors.ListBoxDrawItemEventArgs e)
        {
            e.Appearance.BackColor = e.Index % 2 == 0 ? Color.LightCyan : Color.MistyRose;
            if (checkedListBoxControl1.GetItemChecked(e.Index))
            {
                e.Appearance.BackColor = Color.Gainsboro;
                e.Appearance.Font = new Font(e.Appearance.GetFont(), FontStyle.Italic | FontStyle.Strikeout);
            }
        }
    }
}