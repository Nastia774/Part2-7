using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_7._2
{
    struct Train
    {
        string _nameDest;
        uint _numTrain;
        double _timeDep;
        public string NameDest
        {
            set
            { _nameDest = value; }
            get
            { return _nameDest; }
        }
        public uint NumTrain
        {
            set
            { _numTrain = value; }
            get
            { return _numTrain; }
        }
        public double TimeDep
        {
            set
            { _timeDep = value; }
            get
            { return _timeDep; }
        }
    }
}
