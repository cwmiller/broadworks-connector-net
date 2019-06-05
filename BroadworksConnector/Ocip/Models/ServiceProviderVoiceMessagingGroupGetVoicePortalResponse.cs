using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderVoiceMessagingGroupGetVoicePortalResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.ServiceProviderVoicePortalScope _voicePortalScope;

    [XmlElement(ElementName = "voicePortalScope", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderVoicePortalScope VoicePortalScope {
        get => _voicePortalScope;
        set {
            VoicePortalScopeSpecified = true;
            _voicePortalScope = value;
        }
    }

    [XmlIgnore]
    public bool VoicePortalScopeSpecified { get; set; }
}
}
