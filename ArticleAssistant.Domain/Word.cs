using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleAssistant.Domain
{
    public class Word
    {
        public Word(string value)
        {
            Value = value;
        }

        public string Value { get; }
    }
}
