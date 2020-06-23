using System.Collections.Generic;
using Blog.Generator.Models;
using Statiq.Common;

namespace Blog.Generator.Data
{
    public static class Navigation
    {
        public static IEnumerable<HeaderLink> GetHeaderLinks(IDocument document)
        {
            yield return new HeaderLink(document, "/", "Blog");
            yield return new HeaderLink(document, "/projects", "Projects");
            yield return new HeaderLink(document, "/about", "About");
        }
    }
}
