namespace CSharp.Essential.Unit4
{
    abstract class BaseDocument
    {
        protected string content;

        abstract public string Content { protected get; set; }
        abstract public void Show();

    }
}