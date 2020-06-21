using System;
using System.Threading.Tasks;
using Statiq.App;
using Statiq.Common;
using Statiq.Web;

namespace Blog.Generator
{
    public static class Program
    {
        public static async Task<int> Main(string[] args)
        {
            return await Bootstrapper.Factory
                .CreateWeb(args)
                .AddSetting(Keys.Host, new Uri(BlogSettings.ServerUri).Host)
                .AddSetting(Keys.LinksUseHttps, true)
                .AddSetting(WebKeys.MirrorResources, true)
                .DeployToGitHubPagesBranch("dolifer", "blog", Config.FromSetting<string>("GITHUB_TOKEN"), "master")
                .AddPipelines()
                .RunAsync();
        }
    }
}