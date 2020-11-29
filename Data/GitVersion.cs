using System;
using System.Reflection;

namespace Blog.Generator.Data
{
    public static class GitVersion
    {
        private static readonly Type _gitVersionInformationType;

        static GitVersion()
        {
            var assembly = Assembly.GetEntryAssembly();
            _gitVersionInformationType = assembly?.GetType("GitVersionInformation");
        }

        public static object SemVer => GetField("FullSemVer");
        public static string PrefixSemVer => $"v{SemVer}";
        public static object Sha => GetField("Sha");

        private static object GetField(string name) => _gitVersionInformationType.GetField(name)?.GetValue(null);
    }
}
