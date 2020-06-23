namespace Blog.Generator.Models
{
    public class HeaderLink
    {
        public string Url { get; }
        public string Name { get; }
        public bool IsActive { get; }

        public HeaderLink(string documentUrl, string sectionName, string url, string name)
        {
            IsActive = documentUrl.StartsWith(sectionName);
            Url = url;
            Name = name;
        }
    }
}
