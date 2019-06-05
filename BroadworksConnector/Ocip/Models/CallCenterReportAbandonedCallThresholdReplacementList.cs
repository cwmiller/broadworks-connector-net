using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CallCenterReportAbandonedCallThresholdReplacementList
    {
        private List<int> _abandonedCallThresholdSeconds;

        [XmlElement(ElementName = "abandonedCallThresholdSeconds", IsNullable = false, Namespace = "")]
        public List<int> AbandonedCallThresholdSeconds
        {
            get => _abandonedCallThresholdSeconds;
            set
            {
                AbandonedCallThresholdSecondsSpecified = true;
                _abandonedCallThresholdSeconds = value;
            }
        }

        [XmlIgnore]
        public bool AbandonedCallThresholdSecondsSpecified { get; set; }
    }
}
