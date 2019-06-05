using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCommunicationBarringAuthorizationCodeGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadworksConnector.Ocip.Models.CommunicationBarringAuthorizationCodeEntry> _code;

    [XmlElement(ElementName = "code", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CommunicationBarringAuthorizationCodeEntry> Code {
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
