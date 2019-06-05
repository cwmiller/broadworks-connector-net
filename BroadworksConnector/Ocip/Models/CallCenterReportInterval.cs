using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CallCenterReportInterval
    {
        private BroadworksConnector.Ocip.Models.CallCenterReportIntervalDates _dates;

        [XmlElement(ElementName = "dates", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterReportIntervalDates Dates
        {
            get => _dates;
            set
            {
                DatesSpecified = true;
                _dates = value;
            }
        }

        [XmlIgnore]
        public bool DatesSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterReportCurrentInterval _current;

        [XmlElement(ElementName = "current", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterReportCurrentInterval Current
        {
            get => _current;
            set
            {
                CurrentSpecified = true;
                _current = value;
            }
        }

        [XmlIgnore]
        public bool CurrentSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterReportPastInterval _past;

        [XmlElement(ElementName = "past", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterReportPastInterval Past
        {
            get => _past;
            set
            {
                PastSpecified = true;
                _past = value;
            }
        }

        [XmlIgnore]
        public bool PastSpecified { get; set; }
    }
}
