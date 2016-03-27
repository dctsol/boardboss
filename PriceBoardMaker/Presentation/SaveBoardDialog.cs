using BOARDBoss.Classes;
using BOARDBoss.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BOARDBoss.Presentation
{
    public partial class SaveBoardDialog : Form
    {
        
        MainApp _parent;
        XMLRead xmlr = new XMLRead();
        

        public SaveBoardDialog(MainApp parent, GlobalFunctions gf)
        {
            _parent = parent;
            InitializeComponent();    
        }

        private void SaveBoard_Click(object sender, EventArgs e)
        {
            // Check if a Board name was entered, if not, notify user.

            if (BoardName.Text == String.Empty)
            {
                MessageBox.Show(this, "You do not have a named Board, please enter a name for the board and try again.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                BoardName.BackColor = Color.Yellow;
                BoardName.Focus();
            }

            // Write Board.xml File

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            XmlWriter writer = XmlWriter.Create(AppDomain.CurrentDomain.BaseDirectory + @"Boards.xml", settings);

            writer.WriteStartDocument();
            writer.WriteStartElement("Board");
            writer.WriteAttributeString("Name", BoardName.Text);
            writer.WriteAttributeString("ImageBackgroundColor", ColorTranslator.ToHtml(_parent.BackColor));

            //GlobalFunctions gf = Owner;

            if (_parent.GlobalFunctions.bgImageFile != String.Empty)
                writer.WriteAttributeString("ImagePicture", _parent.GlobalFunctions.bgImageFile);
            else
                writer.WriteAttributeString("ImagePicture", "");

            writer.WriteStartElement("Item");
            writer.WriteAttributeString("ID", "1");
            writer.WriteAttributeString("ItemText", _parent.Item1.Text);
            writer.WriteAttributeString("ItemPriceText", _parent.ItemPrice1.Text);
            writer.WriteAttributeString("ItemBackgroundColor", ColorTranslator.ToHtml(_parent.Item1.BackColor));
            writer.WriteAttributeString("ItemForegroundColor", ColorTranslator.ToHtml(_parent.Item1.ForeColor));
            writer.WriteAttributeString("ItemFontName", _parent.Item1.Font.FontFamily.Name);
            writer.WriteAttributeString("ItemFontSize", _parent.Item1.Font.Size.ToString());
            writer.WriteAttributeString("ItemPriceBackgroundColor", ColorTranslator.ToHtml(_parent.ItemPrice1.BackColor));
            writer.WriteAttributeString("ItemPriceForegroundColor", ColorTranslator.ToHtml(_parent.ItemPrice1.ForeColor));
            writer.WriteAttributeString("ItemPriceFont", _parent.ItemPrice1.Font.FontFamily.Name);
            writer.WriteAttributeString("ItemPriceFontSize", _parent.ItemPrice1.Font.Size.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("Item");
            writer.WriteAttributeString("ID", "2");
            writer.WriteAttributeString("ItemText", _parent.Item2.Text);
            writer.WriteAttributeString("ItemPriceText", _parent.ItemPrice2.Text);
            writer.WriteAttributeString("ItemBackgroundColor", ColorTranslator.ToHtml(_parent.Item2.BackColor));
            writer.WriteAttributeString("ItemForegroundColor", ColorTranslator.ToHtml(_parent.Item2.ForeColor));
            writer.WriteAttributeString("ItemFontName", _parent.Item2.Font.FontFamily.Name);
            writer.WriteAttributeString("ItemFontSize", _parent.Item2.Font.Size.ToString());
            writer.WriteAttributeString("ItemPriceBackgroundColor", ColorTranslator.ToHtml(_parent.ItemPrice2.BackColor));
            writer.WriteAttributeString("ItemPriceForegroundColor", ColorTranslator.ToHtml(_parent.ItemPrice2.ForeColor));
            writer.WriteAttributeString("ItemPriceFont", _parent.ItemPrice2.Font.FontFamily.Name);
            writer.WriteAttributeString("ItemPriceFontSize", _parent.ItemPrice2.Font.Size.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("Item");
            writer.WriteAttributeString("ID", "3");
            writer.WriteAttributeString("ItemText", _parent.Item3.Text);
            writer.WriteAttributeString("ItemPriceText", _parent.ItemPrice3.Text);
            writer.WriteAttributeString("ItemBackgroundColor", ColorTranslator.ToHtml(_parent.Item3.BackColor));
            writer.WriteAttributeString("ItemForegroundColor", ColorTranslator.ToHtml(_parent.Item3.ForeColor));
            writer.WriteAttributeString("ItemFontName", _parent.Item3.Font.FontFamily.Name);
            writer.WriteAttributeString("ItemFontSize", _parent.Item3.Font.Size.ToString());
            writer.WriteAttributeString("ItemPriceBackgroundColor", ColorTranslator.ToHtml(_parent.ItemPrice3.BackColor));
            writer.WriteAttributeString("ItemPriceForegroundColor", ColorTranslator.ToHtml(_parent.ItemPrice3.ForeColor));
            writer.WriteAttributeString("ItemPriceFont", _parent.ItemPrice3.Font.FontFamily.Name);
            writer.WriteAttributeString("ItemPriceFontSize", _parent.ItemPrice3.Font.Size.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("Item");
            writer.WriteAttributeString("ID", "4");
            writer.WriteAttributeString("ItemText", _parent.Item4.Text);
            writer.WriteAttributeString("ItemPriceText", _parent.ItemPrice4.Text);
            writer.WriteAttributeString("ItemBackgroundColor", ColorTranslator.ToHtml(_parent.Item4.BackColor));
            writer.WriteAttributeString("ItemForegroundColor", ColorTranslator.ToHtml(_parent.Item4.ForeColor));
            writer.WriteAttributeString("ItemFontName", _parent.Item4.Font.FontFamily.Name);
            writer.WriteAttributeString("ItemFontSize", _parent.Item4.Font.Size.ToString());
            writer.WriteAttributeString("ItemPriceBackgroundColor", ColorTranslator.ToHtml(_parent.ItemPrice4.BackColor));
            writer.WriteAttributeString("ItemPriceForegroundColor", ColorTranslator.ToHtml(_parent.ItemPrice4.ForeColor));
            writer.WriteAttributeString("ItemPriceFont", _parent.ItemPrice4.Font.FontFamily.Name);
            writer.WriteAttributeString("ItemPriceFontSize", _parent.ItemPrice4.Font.Size.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("Item");
            writer.WriteAttributeString("ID", "5");
            writer.WriteAttributeString("ItemText", _parent.Item5.Text);
            writer.WriteAttributeString("ItemPriceText", _parent.ItemPrice5.Text);
            writer.WriteAttributeString("ItemBackgroundColor", ColorTranslator.ToHtml(_parent.Item5.BackColor));
            writer.WriteAttributeString("ItemForegroundColor", ColorTranslator.ToHtml(_parent.Item5.ForeColor));
            writer.WriteAttributeString("ItemFontName", _parent.Item5.Font.FontFamily.Name);
            writer.WriteAttributeString("ItemFontSize", _parent.Item5.Font.Size.ToString());
            writer.WriteAttributeString("ItemPriceBackgroundColor", ColorTranslator.ToHtml(_parent.ItemPrice5.BackColor));
            writer.WriteAttributeString("ItemPriceForegroundColor", ColorTranslator.ToHtml(_parent.ItemPrice5.ForeColor));
            writer.WriteAttributeString("ItemPriceFont", _parent.ItemPrice5.Font.FontFamily.Name);
            writer.WriteAttributeString("ItemPriceFontSize", _parent.ItemPrice5.Font.Size.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("Item");
            writer.WriteAttributeString("ID", "6");
            writer.WriteAttributeString("ItemText", _parent.Item6.Text);
            writer.WriteAttributeString("ItemPriceText", _parent.ItemPrice6.Text);
            writer.WriteAttributeString("ItemBackgroundColor", ColorTranslator.ToHtml(_parent.Item6.BackColor));
            writer.WriteAttributeString("ItemForegroundColor", ColorTranslator.ToHtml(_parent.Item6.ForeColor));
            writer.WriteAttributeString("ItemFontName", _parent.Item6.Font.FontFamily.Name);
            writer.WriteAttributeString("ItemFontSize", _parent.Item6.Font.Size.ToString());
            writer.WriteAttributeString("ItemPriceBackgroundColor", ColorTranslator.ToHtml(_parent.ItemPrice6.BackColor));
            writer.WriteAttributeString("ItemPriceForegroundColor", ColorTranslator.ToHtml(_parent.ItemPrice6.ForeColor));
            writer.WriteAttributeString("ItemPriceFont", _parent.ItemPrice6.Font.FontFamily.Name);
            writer.WriteAttributeString("ItemPriceFontSize", _parent.ItemPrice6.Font.Size.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("Item");
            writer.WriteAttributeString("ID", "7");
            writer.WriteAttributeString("ItemText", _parent.Item7.Text);
            writer.WriteAttributeString("ItemPriceText", _parent.ItemPrice7.Text);
            writer.WriteAttributeString("ItemBackgroundColor", ColorTranslator.ToHtml(_parent.Item7.BackColor));
            writer.WriteAttributeString("ItemForegroundColor", ColorTranslator.ToHtml(_parent.Item7.ForeColor));
            writer.WriteAttributeString("ItemFontName", _parent.Item7.Font.FontFamily.Name);
            writer.WriteAttributeString("ItemFontSize", _parent.Item7.Font.Size.ToString());
            writer.WriteAttributeString("ItemPriceBackgroundColor", ColorTranslator.ToHtml(_parent.ItemPrice7.BackColor));
            writer.WriteAttributeString("ItemPriceForegroundColor", ColorTranslator.ToHtml(_parent.ItemPrice7.ForeColor));
            writer.WriteAttributeString("ItemPriceFont", _parent.ItemPrice7.Font.FontFamily.Name);
            writer.WriteAttributeString("ItemPriceFontSize", _parent.ItemPrice7.Font.Size.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("Item");
            writer.WriteAttributeString("ID", "8");
            writer.WriteAttributeString("ItemText", _parent.Item8.Text);
            writer.WriteAttributeString("ItemPriceText", _parent.ItemPrice8.Text);
            writer.WriteAttributeString("ItemBackgroundColor", ColorTranslator.ToHtml(_parent.Item8.BackColor));
            writer.WriteAttributeString("ItemForegroundColor", ColorTranslator.ToHtml(_parent.Item8.ForeColor));
            writer.WriteAttributeString("ItemFontName", _parent.Item8.Font.FontFamily.Name);
            writer.WriteAttributeString("ItemFontSize", _parent.Item8.Font.Size.ToString());
            writer.WriteAttributeString("ItemPriceBackgroundColor", ColorTranslator.ToHtml(_parent.ItemPrice8.BackColor));
            writer.WriteAttributeString("ItemPriceForegroundColor", ColorTranslator.ToHtml(_parent.ItemPrice8.ForeColor));
            writer.WriteAttributeString("ItemPriceFont", _parent.ItemPrice8.Font.FontFamily.Name);
            writer.WriteAttributeString("ItemPriceFontSize", _parent.ItemPrice8.Font.Size.ToString());
            writer.WriteEndElement();

            writer.WriteStartElement("Item");
            writer.WriteAttributeString("ID", "9");
            writer.WriteAttributeString("ItemText", _parent.Item9.Text);
            writer.WriteAttributeString("ItemPriceText", _parent.ItemPrice9.Text);
            writer.WriteAttributeString("ItemBackgroundColor", ColorTranslator.ToHtml(_parent.Item9.BackColor));
            writer.WriteAttributeString("ItemForegroundColor", ColorTranslator.ToHtml(_parent.Item9.ForeColor));
            writer.WriteAttributeString("ItemFontName", _parent.Item9.Font.FontFamily.Name);
            writer.WriteAttributeString("ItemFontSize", _parent.Item9.Font.Size.ToString());
            writer.WriteAttributeString("ItemPriceBackgroundColor", ColorTranslator.ToHtml(_parent.ItemPrice9.BackColor));
            writer.WriteAttributeString("ItemPriceForegroundColor", ColorTranslator.ToHtml(_parent.ItemPrice9.ForeColor));
            writer.WriteAttributeString("ItemPriceFont", _parent.ItemPrice9.Font.FontFamily.Name);
            writer.WriteAttributeString("ItemPriceFontSize", _parent.ItemPrice9.Font.Size.ToString());
            writer.WriteEndElement();

            writer.WriteEndElement();
            writer.WriteEndDocument();

            writer.Flush();
            writer.Close();

            this.Close();
        }
    }
}
