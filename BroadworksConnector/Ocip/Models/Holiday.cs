using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Holiday entry.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class Holiday 
    {

        
        private string _holidayName;

        [XmlElement(ElementName = "holidayName", IsNullable = false, Namespace = "")]
        public string HolidayName {
            get => _holidayName;
            set {
                HolidayNameSpecified = true;
                _holidayName = value;
            }
        }

        [XmlIgnore]
        public bool HolidayNameSpecified { get; set; }
        
        private string _startDate;

        [XmlElement(ElementName = "startDate", IsNullable = false, Namespace = "")]
        public string StartDate {
            get => _startDate;
            set {
                StartDateSpecified = true;
                _startDate = value;
            }
        }

        [XmlIgnore]
        public bool StartDateSpecified { get; set; }
        
        private string _endDate;

        [XmlElement(ElementName = "endDate", IsNullable = false, Namespace = "")]
        public string EndDate {
            get => _endDate;
            set {
                EndDateSpecified = true;
                _endDate = value;
            }
        }

        [XmlIgnore]
        public bool EndDateSpecified { get; set; }
        
    }
}
