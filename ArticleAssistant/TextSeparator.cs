using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ArticleAssistant
{
    public class TextSeparator
    {
        private const string separator = @"(\b[^\s]+\b)";

        public IEnumerable<string> Separate(string text)
        {
            return Regex.Matches(text, separator).OfType<Match>().Select(m => m.Value);
        }
    }
}
