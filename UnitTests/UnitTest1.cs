

using Experimental.Models;

namespace UnitTests
{
    public class Tests
    {
        private static Keywords _keywords = new Keywords();

        [SetUp]
        public void Setup()
        {
            _keywords
                .AddVerb("go")
                .AddVerb("exit")
                .AddNoun("west")
                .AddNoun("north")
                .AddConnector("to")
                .AddPunctuation("@")
                .AddPunctuation(";");
        }

        [Test]
        public void Keywords_tokenizes_simple_command()
        {
            var command = "go to west; go to north; @ exit";

            var tokens = _keywords.Tokenize(command);

            if (tokens.IsFailed)
            {
                Assert.Fail(tokens.Errors[0].Message);
            }

            Assert.Pass();
        }
    }
}