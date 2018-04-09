using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarGarage.Parser
{
    public class Parser
    {
        private string _cmd;
        private Stack<string> _eventStack;

        public Parser()
        {
            _cmd = null;
            _eventStack = null;
        }
    }
}