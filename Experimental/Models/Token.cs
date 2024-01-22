using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Experimental.Utilities;

namespace Experimental.Models
{
    public abstract class Token
    {
        private string _word;

        public Token(string word) { _word = word; }
        public string Word { get { return _word;} }
    }

    public class Verb : Token
    {
        public Verb(string word) : base(word) { }
    }

    public class Noun : Token
    {
        public Noun(string word) : base(word) { }
    }

    public class Connector : Token
    {
        public Connector(string word) : base(word) { }
    }

}
