using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckLinksConsole
{
    public class LinkChecker
    {
        public static IEnumerable<string> GetLinks(string body)
        {
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(body);

            return htmlDoc.DocumentNode
            .SelectNodes("//a[@href]")
            .Select(n => n.GetAttributeValue("href", string.Empty))
            .Where(l => !String.IsNullOrEmpty(l))
            .Where(l => l.StartsWith("http"));
        }
    }
}