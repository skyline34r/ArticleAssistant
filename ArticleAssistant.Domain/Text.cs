using System;

namespace ArticleAssistant.Domain
{
    public class Text
    {
        public Text(string value)
        {
            Value = value;
        }

        public string Value { get; }
    }
}
