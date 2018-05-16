namespace CSharp.Essential.Unit6
{
    partial class Book
    {
        public class Note
        {
            string text = "";
            public string Text
            {
                get { return text; }
                set
                {
                    if (text != "")
                        text += "\n";
                    text += value;
                }

            }
        }
    }
}