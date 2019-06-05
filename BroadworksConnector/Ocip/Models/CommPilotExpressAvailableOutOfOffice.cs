using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CommPilotExpressAvailableOutOfOffice
    {
        private BroadworksConnector.Ocip.Models.CommPilotExpressRedirection _incomingCalls;

        [XmlElement(ElementName = "incomingCalls", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CommPilotExpressRedirection IncomingCalls
        {
            get => _incomingCalls;
            set
            {
                IncomingCallsSpecified = true;
                _incomingCalls = value;
            }
        }

        [XmlIgnore]
        public bool IncomingCallsSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CommPilotExpressEmailNotify _incomingCallNotify;

        [XmlElement(ElementName = "incomingCallNotify", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CommPilotExpressEmailNotify IncomingCallNotify
        {
            get => _incomingCallNotify;
            set
            {
                IncomingCallNotifySpecified = true;
                _incomingCallNotify = value;
            }
        }

        [XmlIgnore]
        public bool IncomingCallNotifySpecified { get; set; }
    }
}
