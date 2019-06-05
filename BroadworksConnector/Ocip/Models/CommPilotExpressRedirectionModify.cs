using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CommPilotExpressRedirectionModify
    {
        private BroadworksConnector.Ocip.Models.CommPilotExpressRedirectionAction _action;

        [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CommPilotExpressRedirectionAction Action
        {
            get => _action;
            set
            {
                ActionSpecified = true;
                _action = value;
            }
        }

        [XmlIgnore]
        public bool ActionSpecified { get; set; }
        private string _forwardingPhoneNumber;

        [XmlElement(ElementName = "forwardingPhoneNumber", IsNullable = true, Namespace = "")]
        public string ForwardingPhoneNumber
        {
            get => _forwardingPhoneNumber;
            set
            {
                ForwardingPhoneNumberSpecified = true;
                _forwardingPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool ForwardingPhoneNumberSpecified { get; set; }
    }
}
