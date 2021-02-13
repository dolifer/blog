namespace Blog.Generator.Data
{
    public class Project
    {
        public string Name { get; }
        public string Url { get; }
        public string Tags { get; }
        public string Description { get; }

        public Project(string name, string url, string tags, string description)
        {
            Name = name;
            Url = url;
            Tags = tags;
            Description = description;
        }
    }
}
