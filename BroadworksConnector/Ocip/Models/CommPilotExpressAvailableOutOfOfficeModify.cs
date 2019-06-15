using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// CommPilot Express Available Out Of Office Configuration used in the context of a modify.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CommPilotExpressAvailableOutOfOfficeModify 
    {

        
        private BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionModify _incomingCalls;

        [XmlElement(ElementName = "incomingCalls", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionModify IncomingCalls {
            get => _incomingCalls;
            set {
                IncomingCallsSpecified = true;
                _incomingCalls = value;
            }
        }

        [XmlIgnore]
        public bool IncomingCallsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CommPilotExpressEmailNotifyModify _incomingCallNotify;

        [XmlElement(ElementName = "incomingCallNotify", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressEmailNotifyModify IncomingCallNotify {
            get => _incomingCallNotify;
            set {
                IncomingCallNotifySpecified = true;
                _incomingCallNotify = value;
            }
        }

        [XmlIgnore]
        public bool IncomingCallNotifySpecified { get; set; }
        
    }
}
