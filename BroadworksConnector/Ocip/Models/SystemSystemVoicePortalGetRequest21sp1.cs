using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSystemVoicePortalGetRequest21sp1 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _systemVoicePortalId;

    [XmlElement(ElementName = "systemVoicePortalId", IsNullable = false, Namespace = "")]
    public string SystemVoicePortalId {
        get => _systemVoicePortalId;
        set {
            SystemVoicePortalIdSpecified = true;
            _systemVoicePortalId = value;
        }
    }

    [XmlIgnore]
    public bool SystemVoicePortalIdSpecified { get; set; }
}
}
