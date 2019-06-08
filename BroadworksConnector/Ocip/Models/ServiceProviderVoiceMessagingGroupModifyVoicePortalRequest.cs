using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderVoiceMessagingGroupModifyVoicePortalRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
