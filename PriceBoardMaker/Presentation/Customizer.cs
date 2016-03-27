using BOARDBoss.Presentation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BOARDBoss.Classes;
using System.IO;

namespace BOARDBoss.Presentation
{
    public partial class Customizer : Form
    {
        public XMLRead xmlr = new XMLRead();
        public GlobalFunctions GlobalFunctions = new GlobalFunctions();

        List<Control> foreColorControls;
        List<Control> itemPriceControls;

        public Customizer(GlobalFunctions gf, MainApp _parent)
        {
            // Create a array of controls so we can enumerate through them in a foreach()
            foreColorControls = new List<Control> { _parent.Item1, _parent.Item2, _parent.Item3, _parent.Item4,
                _parent.Item5, _parent.Item6, _parent.Item7, _parent.Item8, _parent.Item9 };
            itemPriceControls = new List<Control> { _parent.ItemPrice1, _parent.ItemPrice2, _parent.ItemPrice3,
                _parent.ItemPrice4, _parent.ItemPrice5, _parent.ItemPrice6, _parent.ItemPrice7, _parent.ItemPrice8, _parent.ItemPrice9 };

            InitializeComponent();
        }

        private void ImageBGColor_Click(object sender, EventArgs e)
        {
            MainApp frm = (MainApp)Owner;

            ColorDialog1.ShowDialog();

            ImageBGColor.BackColor = ColorDialog1.Color;
            frm.BackColor = ColorDialog1.Color;
        }

        private void TextBGColor_Click(object sender, EventArgs e)
        {
            MainApp frm = (MainApp)Owner;

            ColorDialog1.ShowDialog();

            TextBGColor.BackColor = ColorDialog1.Color;

            frm.Item1.BackColor = ColorDialog1.Color;
            frm.Item2.BackColor = ColorDialog1.Color;
            frm.Item3.BackColor = ColorDialog1.Color;
            frm.Item4.BackColor = ColorDialog1.Color;
            frm.Item5.BackColor = ColorDialog1.Color;
            frm.Item6.BackColor = ColorDialog1.Color;
            frm.Item7.BackColor = ColorDialog1.Color;
            frm.Item8.BackColor = ColorDialog1.Color;
            frm.Item9.BackColor = ColorDialog1.Color;

            frm.ItemPrice1.BackColor = ColorDialog1.Color;
            frm.ItemPrice2.BackColor = ColorDialog1.Color;
            frm.ItemPrice3.BackColor = ColorDialog1.Color;
            frm.ItemPrice4.BackColor = ColorDialog1.Color;
            frm.ItemPrice5.BackColor = ColorDialog1.Color;
            frm.ItemPrice6.BackColor = ColorDialog1.Color;
            frm.ItemPrice7.BackColor = ColorDialog1.Color;
            frm.ItemPrice8.BackColor = ColorDialog1.Color;
            frm.ItemPrice9.BackColor = ColorDialog1.Color;

        }

        private void TextFGColor_Click(object sender, EventArgs e)
        {


            ColorDialog1.ShowDialog();

            TextFGColor.BackColor = ColorDialog1.Color;

            foreach (var c in foreColorControls) { c.ForeColor = ColorDialog1.Color; }
            foreach (var c in itemPriceControls) { c.ForeColor = ColorDialog1.Color; }
        }

        private void TextFont_Click(object sender, EventArgs e)
        {
            MainApp frm = (MainApp)Owner;

            fontDialog1.ShowDialog();

            Font f = fontDialog1.Font;

            frm.Item1.Font = f;
            frm.Item2.Font = f;
            frm.Item3.Font = f;
            frm.Item4.Font = f;
            frm.Item5.Font = f;
            frm.Item6.Font = f;
            frm.Item7.Font = f;
            frm.Item8.Font = f;
            frm.Item9.Font = f;

            frm.ItemPrice1.Font = f;
            frm.ItemPrice2.Font = f;
            frm.ItemPrice3.Font = f;
            frm.ItemPrice4.Font = f;
            frm.ItemPrice5.Font = f;
            frm.ItemPrice6.Font = f;
            frm.ItemPrice7.Font = f;
            frm.ItemPrice8.Font = f;
            frm.ItemPrice9.Font = f;

        }

        private void UseFraming_CheckedChanged(object sender, EventArgs e)
        {
            MainApp frm = (MainApp)Owner;

            if (UseFraming.CheckState == CheckState.Checked)
            {
                FramePicker.Visible = true;
            }
            else
            {
                FramePicker.Visible = false;
                frm.BackgroundImage = null;
                frm.Refresh();
            }

        }

        private void FramePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainApp frm = (MainApp)Owner;

            frm.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + String.Format(@"\Frames\Frame{0}.png", FramePicker.SelectedIndex + 1));
            frm.Refresh();
            frm.GlobalFunctions.bgImageFile = AppDomain.CurrentDomain.BaseDirectory + String.Format(@"\Frames\Frame{0}.png", FramePicker.SelectedIndex + 1);

        }

        private void Customizer_Load(object sender, EventArgs e)
        {
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Boards.xml"))
            {
                MessageBox.Show(this, "There is no previous board saved, unable to load Board.", "No Previous Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                IEnumerable<Board> b = xmlr.GetBoardData();


                foreach (var item in b)
                {
                    if (item.BackgroundImage != null)
                    {
                        UseFraming.CheckState = CheckState.Checked;
                    }
                }
            }
        }
    }
}
