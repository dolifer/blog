using Statiq.Common;

namespace Blog.Generator.Extensions
{
    public static class DocumentExtensions
    {
        public static string GetProperty(this IDocument document, string key, string fallbackKey = null)
        {
            var keyValue = document.GetString(key);

            if (!string.IsNullOrWhiteSpace(keyValue))
            {
                return keyValue;
            }

            if (string.IsNullOrWhiteSpace(fallbackKey))
            {
                return null;
            }

            var fallbackValue = document.GetString(fallbackKey);

            return !string.IsNullOrWhiteSpace(fallbackValue) ? fallbackValue : null;
        }

        public static string GetLeadImage(this IDocument document)
        {
            var image = document.GetString("Image");
            var imageLink = document.GetString("ImageLink");

            if (!string.IsNullOrWhiteSpace(image) && !string.IsNullOrWhiteSpace(imageLink))
            {
                return image;
            }

            return null;
        }
    }
}
