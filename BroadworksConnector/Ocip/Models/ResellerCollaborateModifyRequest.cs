using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerCollaborateModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _resellerId;

    [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
    public string ResellerId {
        get => _resellerId;
        set {
            ResellerIdSpecified = true;
            _resellerId = value;
        }
    }

    [XmlIgnore]
    public bool ResellerIdSpecified { get; set; }
    private string _collaborateFromAddress;

    [XmlElement(ElementName = "collaborateFromAddress", IsNullable = true, Namespace = "")]
    public string CollaborateFromAddress {
        get => _collaborateFromAddress;
        set {
            CollaborateFromAddressSpecified = true;
            _collaborateFromAddress = value;
        }
    }

    [XmlIgnore]
    public bool CollaborateFromAddressSpecified { get; set; }
}
}
