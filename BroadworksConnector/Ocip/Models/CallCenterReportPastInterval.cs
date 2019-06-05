using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CallCenterReportPastInterval
    {
        private int _number;

        [XmlElement(ElementName = "number", IsNullable = false, Namespace = "")]
        public int Number
        {
            get => _number;
            set
            {
                NumberSpecified = true;
                _number = value;
            }
        }

        [XmlIgnore]
        public bool NumberSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterReportIntervalTimeUnit _timeUnit;

        [XmlElement(ElementName = "timeUnit", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterReportIntervalTimeUnit TimeUnit
        {
            get => _timeUnit;
            set
            {
                TimeUnitSpecified = true;
                _timeUnit = value;
            }
        }

        [XmlIgnore]
        public bool TimeUnitSpecified { get; set; }
    }
}
