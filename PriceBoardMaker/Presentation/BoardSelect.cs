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
using System.Xml.Linq;

namespace BOARDBoss.Presentation
{
    
    public partial class BoardSelect : Form
    {
        public XMLRead xmlr = new XMLRead();

        public BoardSelect()
        {
            InitializeComponent();

            PopulateList();
            
        }

        private void PopulateList()
        {
            XmlReader xmlReader = XmlReader.Create(AppDomain.CurrentDomain.BaseDirectory + "/Boards.xml");

            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "Board"))
                {
                    ListBoards.Items.Add(xmlReader.GetAttribute("Name"));
                }
            }
        }

        private void CancelOpen_Click(object sender, EventArgs e)
        {

        }

    

        private void OpenBoard_Click(object sender, EventArgs e)
        {
            // Get the selected board name for future use.
            //string CurrentSelected = ListBoards.GetItemText(ListBoards.SelectedItem);

            // Return some data for Item ID 1
            //string test = xmlr.GetData("1");
 
        }
    }
}
