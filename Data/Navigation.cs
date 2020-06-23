using System.Collections.Generic;
using Blog.Generator.Models;
using Statiq.Common;

namespace Blog.Generator.Data
{
    public static class Navigation
    {
        public static IEnumerable<HeaderLink> GetHeaderLinks(IDocument document)
        {
            var url = document.GetString("Section") ?? document.GetLink();

            yield return new HeaderLink(url, "/blog", "/", "Blog");
            yield return new HeaderLink(url, "/projects",  "/projects", "Projects");
            yield return new HeaderLink(url, "/about", "/about", "About");
        }
    }
}
