using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace BOARDBoss
{
    public class Board
    {
        public string Name { get; set; }
        public string BackgroundColor { get; set; }
        public string BackgroundImage { get; set; }

        public static Board FromElement(XElement element)
        {
            return new Board
            {
                Name = element.Attribute("Name").Value,
                BackgroundColor = element.Attribute("ImageBackgroundColor").Value,
                BackgroundImage = element.Attribute("ImagePicture").Value

            };
        }
    }

    public class Item
    {
        public string Id { get; set; }
        public string ItemText { get; set; }
        public string ItemPriceText { get; set; }
        public string BackgroundColor { get; set; }
        public string ForegroundColor { get; set; }
        public string FontName { get; set; }
        public string FontSize { get; set; }
        public string PriceBackgroundColor { get; set; }
        public string PriceForegroundColor { get; set; }
        public string PriceFont { get; set; }
        public string PriceFontSize { get; set; }

        public static Item FromElement(XElement element)
        {
            return new Item
            {
                Id = element.Attribute("ID").Value,
                ItemText = element.Attribute("ItemText").Value,
                ItemPriceText = element.Attribute("ItemPriceText").Value,
                BackgroundColor = element.Attribute("ItemBackgroundColor").Value,
                ForegroundColor = element.Attribute("ItemForegroundColor").Value,
                FontName = element.Attribute("ItemFontName").Value,
                FontSize = element.Attribute("ItemFontSize").Value,
                PriceBackgroundColor = element.Attribute("ItemPriceBackgroundColor").Value,
                PriceForegroundColor = element.Attribute("ItemPriceForegroundColor").Value,
                PriceFont = element.Attribute("ItemPriceFont").Value,
                PriceFontSize = element.Attribute("ItemPriceFontSize").Value
            };
        }
    }

    public class XMLRead
    {

        public IEnumerable<Item> GetData(string lineNumber)
        {
            var document = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + @"\Boards.xml");
            yield return document.Descendants("Item").Select(Item.FromElement).SingleOrDefault(p => (string)p.Id == lineNumber);
        }

        public IEnumerable<Board> GetBoardData()
        {
            var document = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + @"\Boards.xml");
            return document.Descendants("Board").Select(Board.FromElement);
        }
    }
   


}
