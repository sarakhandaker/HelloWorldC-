using System;
namespace HelloWorld
{
    public class Text : Shape
    {
        public int FontSize { get; set; }
        public string FrontName { get; set; }

        public void AddHyperLink (string link)
        {
            Console.WriteLine("link");
        }
    }


}
