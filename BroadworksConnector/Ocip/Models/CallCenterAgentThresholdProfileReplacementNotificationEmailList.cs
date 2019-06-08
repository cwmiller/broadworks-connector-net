using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterAgentThresholdProfileReplacementNotificationEmailList 
{
    private List<string> _emailAddress;

    [XmlElement(ElementName = "emailAddress", IsNullable = false, Namespace = "")]
    public List<string> EmailAddress {
        get => _emailAddress;
        set {
            EmailAddressSpecified = true;
            _emailAddress = value;
        }
    }

    [XmlIgnore]
    public bool EmailAddressSpecified { get; set; }
}
}
