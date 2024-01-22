using FluentResults;

namespace Experimental.Models
{
    public interface ICommand
    {
        Result<string> Execute();        
    }
}
