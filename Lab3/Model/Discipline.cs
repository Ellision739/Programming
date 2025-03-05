using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab3.Model
{
    class Discipline
    {
        private bool _math;
        private bool _programming;
        private bool _project;

        public bool Math { get { return _math; } set { _math = value; } }
        public bool Programming { get { return _programming; } set { _programming = value; } }
        public bool Project { get { return _project; } set { _project = value; } }
        public Discipline(bool math, bool programming, bool project)
        {
            Math = math;
            Programming = programming;
            Project = project;
        }
        public Discipline()
        {
            
        }
    }
}
