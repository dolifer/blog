using System.Threading.Tasks;
using Statiq.App;
using Statiq.Web;

namespace Blog.Generator
{
    public static class Program
    {
        public static async Task<int> Main(string[] args)
        {
            return await Bootstrapper.Factory
                .CreateWeb(args)
                .RunAsync();
        }
    }
}