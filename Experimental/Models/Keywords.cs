using Experimental.Utilities;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.Models
{
    public class Keywords
    {
        private List<string> _verbs = new List<string>();
        private List<string> _nouns = new List<string>();
        private List<string> _connectors = new List<string>();
        private List<string> _punctuation = new List<string>();

        public Keywords()
        {
        }

        public Result<Token> GetToken(string word)
        {
            if (_verbs.Contains(word)) { return Result.Ok<Token> ( new Verb(word) ); }
            if (_nouns.Contains(word)) { return Result.Ok<Token>(new Noun(word)); }
            if (_connectors.Contains(word)) { return Result.Ok<Token>(new Connector(word)); }
            return Result.Fail($"'{word}' is not in keyword dictionary.");
        }
        
        public Result<List<Token>> Tokenize(string command)
        {
            var normalized = command.Normalize()?.SplitOnWhiteSpace();
            var result = new List<Token>();
            var errors = new List<string>();
            bool isError = false;
            foreach (var word in normalized)
            {
                var token = GetToken(word);
                if (token.IsSuccess)
                {
                    result.Add(token.Value);
                } else
                {
                    errors.Add(token.Errors.FirstOrDefault().Message);
                    isError = true;
                }
            }
            if (! isError) { return Result.Ok(result); }
            return Result.Fail(errors.Concatenate());
        }


        public Keywords AddVerb(string verb)
        {
            if (!_verbs.Contains(verb))
            {
                _verbs.Add(verb);
            }
            return this;
        }

        public Keywords AddNoun(string noun)
        {
            if (!_nouns.Contains(noun))
            {
                _nouns.Add(noun);
            }
            return this;
        }

        public Keywords AddConnector(string connector)
        {
            if (!_connectors.Contains(connector))
            {
                _connectors.Add(connector);
            }
            return this;
        }

        public Keywords AddPunctuation(string punc)
        {
            if (!_punctuation.Contains(punc))
            {
                _punctuation.Add(punc);
            }
            return this;
        }

    }
}
