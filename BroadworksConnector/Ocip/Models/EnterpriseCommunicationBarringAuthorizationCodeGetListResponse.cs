using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseCommunicationBarringAuthorizationCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadWorksConnector.Ocip.Models.CommunicationBarringAuthorizationCodeConfiguration> _code;

    [XmlElement(ElementName = "code", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.CommunicationBarringAuthorizationCodeConfiguration> Code {
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
