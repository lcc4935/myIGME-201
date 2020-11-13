using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classCourseLibrary
{
    public abstract class BasicInfo
    {
        public string name;
        public string major;
        public string minor;
        public string immersion;
    }

    public abstract class ClassInfo
    {
        public string classValue; //ex: IGME
        public string classNumber;
        public string className;
        public string classType;
        public int classCredit;
    }

    public abstract class Schedule
    {
        public string semester;
        public int creditCount;
    }

    public enum type
    {
        major,
        immersion,
        minor,
        genEd,
        genEdPer,
        free,
        adEl,
        wellness,
        coop,
        other,

    }
}
