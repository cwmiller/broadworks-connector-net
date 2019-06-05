using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerCollaborateGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _collaborateFromAddress;

    [XmlElement(ElementName = "collaborateFromAddress", IsNullable = false, Namespace = "")]
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
