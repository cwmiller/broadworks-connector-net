using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCommunicationBarringAuthorizationCodeGetListResponse21sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadworksConnector.Ocip.Models.CommunicationBarringAuthorizationCodeConfiguration> _code;

    [XmlElement(ElementName = "code", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CommunicationBarringAuthorizationCodeConfiguration> Code {
        get => _code;
        set {
            CodeSpecified = true;
            _code = value;
        }
    }

    [XmlIgnore]
    public bool CodeSpecified { get; set; }
}
}
