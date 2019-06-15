using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Time range used to filter call logs.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnhancedCallLogsTimeRange 
    {

        
        private string _startDateTime;

        [XmlElement(ElementName = "startDateTime", IsNullable = false, Namespace = "")]
        public string StartDateTime {
            get => _startDateTime;
            set {
                StartDateTimeSpecified = true;
                _startDateTime = value;
            }
        }

        [XmlIgnore]
        public bool StartDateTimeSpecified { get; set; }
        
        private string _endDateTime;

        [XmlElement(ElementName = "endDateTime", IsNullable = false, Namespace = "")]
        public string EndDateTime {
            get => _endDateTime;
            set {
                EndDateTimeSpecified = true;
                _endDateTime = value;
            }
        }

        [XmlIgnore]
        public bool EndDateTimeSpecified { get; set; }
        
    }
}
