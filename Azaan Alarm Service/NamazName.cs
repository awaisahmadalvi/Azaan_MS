using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Azaan
{
    public class NamazName
    {
        public String Fajar = "fajar";
        public String Zohar = "zohar";
        public String Asar = "asar";
        public String Maghrib = "maghrib";
        public String Isha = "isha";
        public String Jumma = "jumma";
        public String[] array;
        
        public String this[int index]
        {
            get
            {
                return array[index];
            }
        }

        public int Length
        {
            get { return array.Length; }
        }
        
        public NamazName()
        {
            array = new String[] { Fajar, Zohar, Asar, Maghrib, Isha, Jumma };
        }
        
        public NamazName(String[] activeNamaz)
        {
            array = activeNamaz;
        }
        
        public NamazName(bool isFriday)
        {
            if (isFriday)
                array = new String[] { Fajar, Jumma, Asar, Maghrib, Isha };
            else
                array = new String[] { Fajar, Zohar, Asar, Maghrib, Isha };

        }
    }

    public class attributes
    {
        public String time = "time";
        public String active = "active";
        public String waiting = "waiting";
        public String[] array;
        
        public String this[int index]
        {
            get
            {
                return array[index];
            }
        }
        
        public attributes()
        {
            array = new String[] { time, active, waiting };
        }
    }
}
