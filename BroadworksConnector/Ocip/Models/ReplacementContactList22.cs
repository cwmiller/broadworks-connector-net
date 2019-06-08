using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementContactList22 
{
    private List<BroadWorksConnector.Ocip.Models.SIPContactInfo> _contact;

    [XmlElement(ElementName = "contact", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SIPContactInfo> Contact {
        get => _contact;
        set {
            ContactSpecified = true;
            _contact = value;
        }
    }

    [XmlIgnore]
    public bool ContactSpecified { get; set; }
}
}
