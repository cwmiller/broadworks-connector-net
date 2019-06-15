using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The call center enhanced reporting report past interval, for example, last 24 month.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CallCenterReportPastInterval 
    {

        
        private int _number;

        [XmlElement(ElementName = "number", IsNullable = false, Namespace = "")]
        public int Number {
            get => _number;
            set {
                NumberSpecified = true;
                _number = value;
            }
        }

        [XmlIgnore]
        public bool NumberSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterReportIntervalTimeUnit _timeUnit;

        [XmlElement(ElementName = "timeUnit", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportIntervalTimeUnit TimeUnit {
            get => _timeUnit;
            set {
                TimeUnitSpecified = true;
                _timeUnit = value;
            }
        }

        [XmlIgnore]
        public bool TimeUnitSpecified { get; set; }
        
    }
}
