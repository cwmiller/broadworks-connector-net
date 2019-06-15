using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Report interval for call center enhanced reporting scheduled reports.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CallCenterReportInterval 
    {

        
        private BroadWorksConnector.Ocip.Models.CallCenterReportIntervalDates _dates;

        [XmlElement(ElementName = "dates", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportIntervalDates Dates {
            get => _dates;
            set {
                DatesSpecified = true;
                _dates = value;
            }
        }

        [XmlIgnore]
        public bool DatesSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterReportCurrentInterval _current;

        [XmlElement(ElementName = "current", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportCurrentInterval Current {
            get => _current;
            set {
                CurrentSpecified = true;
                _current = value;
            }
        }

        [XmlIgnore]
        public bool CurrentSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterReportPastInterval _past;

        [XmlElement(ElementName = "past", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportPastInterval Past {
            get => _past;
            set {
                PastSpecified = true;
                _past = value;
            }
        }

        [XmlIgnore]
        public bool PastSpecified { get; set; }
        
    }
}
