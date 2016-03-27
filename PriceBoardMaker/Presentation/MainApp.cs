using BOARDBoss.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BOARDBoss.Presentation
{
    public partial class MainApp : Form
    {
        public XMLRead xmlr = new XMLRead();

        public GlobalFunctions GlobalFunctions = new GlobalFunctions();
        public string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Atek\avstv\avstv.mdb;";
        public int screenMode = 0;
        public int lastId = 0;

        public MainApp()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void ConfigureTemplate_Click(object sender, EventArgs e)
        {
            using (Customizer frm = new Customizer(this.GlobalFunctions, this))
            {
                frm.ShowDialog(this);
            }
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendToAvs_Click(object sender, EventArgs e)
        {
            string savedFile = String.Empty;
            int screenNumber = 0;
            string savedWithPath = String.Empty;

            // First read the data from database so we know how many screens we can work with.

            OleDbConnection myConn = new OleDbConnection(connStr);

            try
            {
                myConn.Open(); // Open a connection to the database

                string queryGetScreenMode = @"SELECT ScreenMode FROM Config;";

                OleDbCommand Cmd = new OleDbCommand(queryGetScreenMode, myConn);
                Cmd.CommandText = queryGetScreenMode;
                Cmd.CommandType = CommandType.Text;

                OleDbDataReader reader = Cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    string screenModeRaw = reader.GetValue(0).ToString();

                    screenMode = Convert.ToInt32(screenModeRaw);

                }
            }
            catch (OleDbException oleEx)
            {
                MessageBox.Show(this, oleEx.Message, "Database Errorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myConn.Close();
            }

            // Next, depending on ScreenMode, populate the combobox appropiately.

            DialogStart:
            using (SaveImageName frm = new SaveImageName(this))
            {

                switch (screenMode)
                {
                    case 0:
                        frm.ScreenNumber.Items.Add("1");
                        frm.ScreenLayout.Image = Properties.Resources.ScreenLayout1;

                        break;
                    case 1:
                        frm.ScreenNumber.Items.Add("1");
                        frm.ScreenNumber.Items.Add("2");
                        frm.ScreenLayout.Image = Properties.Resources.ScreenLayout2V;
                        break;
                    case 2:
                        frm.ScreenNumber.Items.Add("1");
                        frm.ScreenNumber.Items.Add("2");
                        frm.ScreenLayout.Image = Properties.Resources.ScreenLayout2H;
                        break;
                    case 3:
                        frm.ScreenNumber.Items.Add("1");
                        frm.ScreenNumber.Items.Add("2");
                        frm.ScreenNumber.Items.Add("3");
                        frm.ScreenLayout.Image = Properties.Resources.ScreenLayout3;
                        break;
                    case 4:
                        frm.ScreenNumber.Items.Add("1");
                        frm.ScreenNumber.Items.Add("2");
                        frm.ScreenNumber.Items.Add("3");
                        frm.ScreenNumber.Items.Add("4");
                        frm.ScreenLayout.Image = Properties.Resources.ScreenLayout4;
                        break;
                }

                if (Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Atek\avstv\avstv.mdb" == null)
                    MessageBox.Show(this, "You do not have AVSTV Installed on this computer, please install and try again.", "Invalid App", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                frm.ScreenNumber.SelectedIndex = 0;

                DialogResult dr = frm.ShowDialog(this);

                if (dr == DialogResult.OK)
                {
                    if (frm.ImageName.Text == String.Empty)
                    {
                        MessageBox.Show(this, "Please specify the name of this menu board.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        goto DialogStart;
                    }
                    else
                    {
                        screenNumber = Convert.ToInt32(frm.ScreenNumber.Text); // Works
                        savedFile = frm.ImageName.Text;

                        FlowPanel.Visible = false;

                        Bitmap b = new Bitmap(Width, Height);
                        DrawToBitmap(b, new Rectangle(0, 0, Width, Height));

                        if (frm.ImageName.Text != String.Empty)
                        {
                            b.Save(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Atek\avstv\Media\" + savedFile + ".jpg");
                            savedWithPath = savedFile + ".jpg";
                        }

                        // Next, we need to read the media table to determine the last ID used.
                        // We can store the image into AVS's database at the LAST ID + 1.

                        try
                        {
                            myConn.Open(); // Open a connection to the database

                            string queryGetScreenMode = @"SELECT TOP 1 Id FROM Media ORDER BY Id DESC";

                            OleDbCommand Cmd = new OleDbCommand(queryGetScreenMode, myConn);
                            Cmd.CommandText = queryGetScreenMode;
                            Cmd.CommandType = CommandType.Text;

                            OleDbDataReader reader = Cmd.ExecuteReader(CommandBehavior.CloseConnection);

                            while (reader.Read())
                            {
                                string id = reader.GetValue(0).ToString();

                                lastId = Convert.ToInt32(id);
                            }
                        }
                        catch (OleDbException oleEx)
                        {
                            MessageBox.Show(this, oleEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            myConn.Close();
                        }

                        // Now save the new entry into the database.
                        try
                        {
                            myConn.Open(); // Open a connection to the database

                            lastId++; // Take last Id and increment it by 1.
                            string strCmd = @"INSERT INTO media VALUES (" + lastId + ", 1, " + screenNumber + ", '" +
                                savedWithPath + "', 1, 1, 1, 1, 1, 1, 1, 0, 0, 5, 0); ";

                            OleDbCommand Cmd = new OleDbCommand(strCmd, myConn);
                            Cmd.CommandText = strCmd;
                            Cmd.CommandType = CommandType.Text;

                            Cmd.ExecuteNonQuery();
                        }
                        catch (OleDbException oleEx)
                        {
                            MessageBox.Show(this, oleEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            MessageBox.Show(this, "Image sent to AVSTV", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            myConn.Close();
                        }

                        FlowPanel.Visible = true;
                    }

                }
            }
        }

        private void LoadMenu_Click(object sender, EventArgs e)
        {
            // Check if Boards.xml exists, if not, post error.

            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Boards.xml"))
            {
                MessageBox.Show(this, "There is no previous board saved, unable to load Board.", "No Previous Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                IEnumerable<Board> b = xmlr.GetBoardData();

                IEnumerable<Item> i1 = xmlr.GetData("1");
                IEnumerable<Item> i2 = xmlr.GetData("2");
                IEnumerable<Item> i3 = xmlr.GetData("3");
                IEnumerable<Item> i4 = xmlr.GetData("4");
                IEnumerable<Item> i5 = xmlr.GetData("5");
                IEnumerable<Item> i6 = xmlr.GetData("6");
                IEnumerable<Item> i7 = xmlr.GetData("7");
                IEnumerable<Item> i8 = xmlr.GetData("8");
                IEnumerable<Item> i9 = xmlr.GetData("9");

                var fname = new FontConverter();

                foreach (var item in b)
                {
                    BackColor = ColorTranslator.FromHtml(item.BackgroundColor);

                    BackgroundImage = Image.FromFile(item.BackgroundImage);

                }

                foreach (var item in i1)
                {
                    Item1.Text = item.ItemText;
                    ItemPrice1.Text = item.ItemPriceText;
                    Item1.BackColor = ColorTranslator.FromHtml(item.BackgroundColor);
                    Item1.ForeColor = ColorTranslator.FromHtml(item.ForegroundColor);
                    ItemPrice1.BackColor = ColorTranslator.FromHtml(item.PriceBackgroundColor);
                    ItemPrice1.ForeColor = ColorTranslator.FromHtml(item.PriceForegroundColor);

                    Font itemFontname = fname.ConvertFromString(item.FontName) as Font;
                    Font itemFont = new Font(itemFontname.ToString(), float.Parse(item.FontSize));

                    Font itemPriceFontname = fname.ConvertFromString(item.PriceFont) as Font;
                    Font itemPriceFont = new Font(itemPriceFontname.ToString(), float.Parse(item.PriceFontSize));

                    Item1.Font = itemFont;
                    ItemPrice1.Font = itemPriceFont;
                }

                foreach (var item in i2)
                {
                    Item2.Text = item.ItemText;
                    ItemPrice2.Text = item.ItemPriceText;
                    Item2.BackColor = ColorTranslator.FromHtml(item.BackgroundColor);
                    Item2.ForeColor = ColorTranslator.FromHtml(item.ForegroundColor);
                    ItemPrice2.BackColor = ColorTranslator.FromHtml(item.PriceBackgroundColor);
                    ItemPrice2.ForeColor = ColorTranslator.FromHtml(item.PriceForegroundColor);

                    Font fontname = fname.ConvertFromString(item.FontName) as Font;
                    Font font = new Font(fontname.ToString(), float.Parse(item.FontSize));

                    Font itemPriceFontname = fname.ConvertFromString(item.PriceFont) as Font;
                    Font itemPriceFont = new Font(itemPriceFontname.ToString(), float.Parse(item.PriceFontSize));

                    Item2.Font = font;
                    ItemPrice2.Font = itemPriceFont;
                }

                foreach (var item in i3)
                {
                    Item3.Text = item.ItemText;
                    ItemPrice3.Text = item.ItemPriceText;
                    Item3.BackColor = ColorTranslator.FromHtml(item.BackgroundColor);
                    Item3.ForeColor = ColorTranslator.FromHtml(item.ForegroundColor);
                    ItemPrice3.BackColor = ColorTranslator.FromHtml(item.PriceBackgroundColor);
                    ItemPrice3.ForeColor = ColorTranslator.FromHtml(item.PriceForegroundColor);

                    Font fontname = fname.ConvertFromString(item.FontName) as Font;
                    Font font = new Font(fontname.ToString(), float.Parse(item.FontSize));

                    Font itemPriceFontname = fname.ConvertFromString(item.PriceFont) as Font;
                    Font itemPriceFont = new Font(itemPriceFontname.ToString(), float.Parse(item.PriceFontSize));

                    Item3.Font = font;
                    ItemPrice3.Font = itemPriceFont;

                }

                foreach (var item in i4)
                {
                    Item4.Text = item.ItemText;
                    ItemPrice4.Text = item.ItemPriceText;
                    Item4.BackColor = ColorTranslator.FromHtml(item.BackgroundColor);
                    Item4.ForeColor = ColorTranslator.FromHtml(item.ForegroundColor);
                    ItemPrice4.BackColor = ColorTranslator.FromHtml(item.PriceBackgroundColor);
                    ItemPrice4.ForeColor = ColorTranslator.FromHtml(item.PriceForegroundColor);

                    Font fontname = fname.ConvertFromString(item.FontName) as Font;
                    Font font = new Font(fontname.ToString(), float.Parse(item.FontSize));

                    Font itemPriceFontname = fname.ConvertFromString(item.PriceFont) as Font;
                    Font itemPriceFont = new Font(itemPriceFontname.ToString(), float.Parse(item.PriceFontSize));

                    Item4.Font = font;
                    ItemPrice4.Font = itemPriceFont;
                }

                foreach (var item in i5)
                {
                    Item5.Text = item.ItemText;
                    ItemPrice5.Text = item.ItemPriceText;
                    Item5.BackColor = ColorTranslator.FromHtml(item.BackgroundColor);
                    Item5.ForeColor = ColorTranslator.FromHtml(item.ForegroundColor);
                    ItemPrice5.BackColor = ColorTranslator.FromHtml(item.PriceBackgroundColor);
                    ItemPrice5.ForeColor = ColorTranslator.FromHtml(item.PriceForegroundColor);

                    Font fontname = fname.ConvertFromString(item.FontName) as Font;
                    Font font = new Font(fontname.ToString(), float.Parse(item.FontSize));

                    Font itemPriceFontname = fname.ConvertFromString(item.PriceFont) as Font;
                    Font itemPriceFont = new Font(itemPriceFontname.ToString(), float.Parse(item.PriceFontSize));

                    Item5.Font = font;
                    ItemPrice5.Font = itemPriceFont;
                }

                foreach (var item in i6)
                {
                    Item6.Text = item.ItemText;
                    ItemPrice6.Text = item.ItemPriceText;
                    Item6.BackColor = ColorTranslator.FromHtml(item.BackgroundColor);
                    Item6.ForeColor = ColorTranslator.FromHtml(item.ForegroundColor);
                    ItemPrice6.BackColor = ColorTranslator.FromHtml(item.PriceBackgroundColor);
                    ItemPrice6.ForeColor = ColorTranslator.FromHtml(item.PriceForegroundColor);

                    Font fontname = fname.ConvertFromString(item.FontName) as Font;
                    Font font = new Font(fontname.ToString(), float.Parse(item.FontSize));

                    Font itemPriceFontname = fname.ConvertFromString(item.PriceFont) as Font;
                    Font itemPriceFont = new Font(itemPriceFontname.ToString(), float.Parse(item.PriceFontSize));

                    Item6.Font = font;
                    ItemPrice6.Font = itemPriceFont;
                }

                foreach (var item in i7)
                {
                    Item7.Text = item.ItemText;
                    ItemPrice7.Text = item.ItemPriceText;
                    Item7.BackColor = ColorTranslator.FromHtml(item.BackgroundColor);
                    Item7.ForeColor = ColorTranslator.FromHtml(item.ForegroundColor);
                    ItemPrice7.BackColor = ColorTranslator.FromHtml(item.PriceBackgroundColor);
                    ItemPrice7.ForeColor = ColorTranslator.FromHtml(item.PriceForegroundColor);

                    Font fontname = fname.ConvertFromString(item.FontName) as Font;
                    Font font = new Font(fontname.ToString(), float.Parse(item.FontSize));

                    Font itemPriceFontname = fname.ConvertFromString(item.PriceFont) as Font;
                    Font itemPriceFont = new Font(itemPriceFontname.ToString(), float.Parse(item.PriceFontSize));

                    Item7.Font = font;
                    ItemPrice7.Font = itemPriceFont;
                }

                foreach (var item in i8)
                {
                    Item8.Text = item.ItemText;
                    ItemPrice8.Text = item.ItemPriceText;
                    Item8.BackColor = ColorTranslator.FromHtml(item.BackgroundColor);
                    Item8.ForeColor = ColorTranslator.FromHtml(item.ForegroundColor);
                    ItemPrice8.BackColor = ColorTranslator.FromHtml(item.PriceBackgroundColor);
                    ItemPrice8.ForeColor = ColorTranslator.FromHtml(item.PriceForegroundColor);

                    Font fontname = fname.ConvertFromString(item.FontName) as Font;
                    Font font = new Font(fontname.ToString(), float.Parse(item.FontSize));

                    Font itemPriceFontname = fname.ConvertFromString(item.PriceFont) as Font;
                    Font itemPriceFont = new Font(itemPriceFontname.ToString(), float.Parse(item.PriceFontSize));

                    Item8.Font = font;
                    ItemPrice8.Font = itemPriceFont;
                }

                foreach (var item in i9)
                {
                    Item9.Text = item.ItemText;
                    ItemPrice9.Text = item.ItemPriceText;
                    Item9.BackColor = ColorTranslator.FromHtml(item.BackgroundColor);
                    Item9.ForeColor = ColorTranslator.FromHtml(item.ForegroundColor);
                    ItemPrice9.BackColor = ColorTranslator.FromHtml(item.PriceBackgroundColor);
                    ItemPrice9.ForeColor = ColorTranslator.FromHtml(item.PriceForegroundColor);

                    Font fontname = fname.ConvertFromString(item.FontName) as Font;
                    Font font = new Font(fontname.ToString(), float.Parse(item.FontSize));

                    Font itemPriceFontname = fname.ConvertFromString(item.PriceFont) as Font;
                    Font itemPriceFont = new Font(itemPriceFontname.ToString(), float.Parse(item.PriceFontSize));

                    Item9.Font = font;
                    ItemPrice9.Font = itemPriceFont;
                }
            }
        }

        private void SaveBoard_Click(object sender, EventArgs e)
        {
            using (SaveBoardDialog f = new SaveBoardDialog(this, this.GlobalFunctions))
                f.ShowDialog();
        }

        private void AboutApp_Click(object sender, EventArgs e)
        {
            using (AboutApp frm = new AboutApp())
                frm.ShowDialog();
        }
    }
}
