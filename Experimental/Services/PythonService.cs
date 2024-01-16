using Microsoft.Extensions.Configuration;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimental.Services
{
    public class PythonService
    {
        private ScriptEngine _engine;
        private ScriptScope _scope;

        public PythonService(IConfigurationRoot config)
        {
            _engine = IronPython.Hosting.Python.CreateEngine();
            _scope = _engine.CreateScope();
        }
    }
}
