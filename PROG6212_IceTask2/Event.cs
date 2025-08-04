using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6212_IceTask2
{
    public class Event
    {
        string eventName, eventDescription;
        string eventStartDate, eventEndDate;

        public Event(string eventName, string eventDescription, string eventStartDate, string eventEndDate)
        {
            this.eventName = eventName;
            this.eventDescription = eventDescription;
            this.eventStartDate = eventStartDate;
            this.eventEndDate = eventEndDate;
        }

       

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.eventName;
                else if (index == 1)
                    return this.eventDescription;
                else if (index == 2)
                    return this.eventStartDate;
                else if (index == 3)
                    return this.eventEndDate;
                return null;
            }

            set
            {
                if (index == 0)
                    this.eventName = (string)value;
                else if (index == 1)
                    this.eventDescription = (string)value;
                else if (index == 2)
                    this.eventStartDate = (string)value;
                else if (index == 3)
                    this.eventEndDate = (string)value;
            }
        }


        //Second indexer, using string index, attribute names
        public object this[string attrName]
        {
            get
            {
                if (attrName == "name")
                    return this.eventName;
                else if (attrName == "description")
                    return this.eventDescription;
                else if (attrName == "start")
                    return this.eventStartDate;
                else if (attrName == "end")
                    return this.eventEndDate;
                return null;

            }
            set
            {

                if (attrName.ToLower().Equals("name"))
                    this.eventName = (string)value;
                else if (attrName.ToLower().Equals("description"))
                    this.eventDescription = (string)value;
                else if (attrName.ToLower().Equals("start"))
                    this.eventStartDate = (string)value;
                else if (attrName.ToLower().Equals("end"))
                    this.eventEndDate = (string)value;

            }

        }
    }
}
