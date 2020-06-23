using Statiq.Common;

namespace Blog.Generator.Models
{
    public class HeaderLink
    {
        public IDocument Document { get; }
        public string Url { get; }
        public string Name { get; }

        public HeaderLink(IDocument document, string url, string name)
        {
            Document = document;
            Url = url;
            Name = name;
        }
    }
}
