using System;
namespace HelloWorld
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FrontName { get; set; }

        public void AddHyperLink (string link)
        {
            Console.WriteLine("link");
        }
    }


}
