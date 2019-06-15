using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class RecurrenceRecurDaily 
    {

        
        private int _recurInterval;

        [XmlElement(ElementName = "recurInterval", IsNullable = false, Namespace = "")]
        public int RecurInterval {
            get => _recurInterval;
            set {
                RecurIntervalSpecified = true;
                _recurInterval = value;
            }
        }

        [XmlIgnore]
        public bool RecurIntervalSpecified { get; set; }
        
    }
}
