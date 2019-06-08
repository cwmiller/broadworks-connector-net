using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderVoiceMessagingGroupGetVoicePortalResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.ServiceProviderVoicePortalScope _voicePortalScope;

    [XmlElement(ElementName = "voicePortalScope", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ServiceProviderVoicePortalScope VoicePortalScope {
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
