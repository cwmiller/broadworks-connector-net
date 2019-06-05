using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderVoiceMessagingGroupModifyVoicePortalRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
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
