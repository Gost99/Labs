using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class SupportSpecialist
    {
        private string _specialistName;
        private SpecialistStatus _status;

        public string Name
        {
            set { _specialistName = value; }
            get { return _specialistName; }
        }

        public SpecialistStatus Status
        {
            set { _status = value; }
            get { return _status; }
        }

        public SupportSpecialist(string name)
        {
            _specialistName = name;
            _status = SpecialistStatus.free;
        }
        public SupportSpecialist(string name, SpecialistStatus status)
        {
            _specialistName = name;
            _status = status;
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
