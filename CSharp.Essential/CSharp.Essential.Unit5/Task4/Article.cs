using System;

namespace CSharp.Essential.Unit5
{
    public class Article
    {
        private string itemName;
        private string storeName;
        private double priceUah;

        public Article(string itemName, string storeName, double priceUah)
        {
            this.itemName = itemName;
            this.storeName = storeName;
            this.priceUah = priceUah;
        }

        public string ItemName
        {
            get { return itemName; }
        }

        public void ShowArticleInfo()
        {
            Console.WriteLine("\nArticle name: {0}",ItemName    );
            Console.WriteLine("Located at Store: {0}",storeName);
            Console.WriteLine("Price in UAH: {0}",priceUah);
        }
        
        public string ShowAItemInfo()
        {
            return string.Format("Article name: {0}, Located at: {1}, Price {2} UAH", ItemName, storeName, priceUah);
        }
    }
}