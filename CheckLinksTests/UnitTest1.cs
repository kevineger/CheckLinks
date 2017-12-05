using System;
using System.Linq;
using CheckLinksConsole;
using Xunit;

namespace CheckLinksTests
{
    public class UnitTest1
    {
        [Fact]
        public void WithoutHttpAtStartOfLink_NoLinks()
        {
            var links = LinkChecker.GetLinks("<a href=\"google.com\">");
            Assert.Equal(0, links.Count());
        }

        [Fact]
        public void WithHttpAtStartOfLink_LinkParses()
        {
            var links = LinkChecker.GetLinks("<a href=\"http://google.com\">");
            Assert.Equal(1, links.Count());
            Assert.Equal("http://google.com", links.First());
        }
    }
}
