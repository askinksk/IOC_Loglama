using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GokFramework.Logger
{
    public interface ILogger
    {
        void Log(MethodBase methodBase, string message);
    }
}
