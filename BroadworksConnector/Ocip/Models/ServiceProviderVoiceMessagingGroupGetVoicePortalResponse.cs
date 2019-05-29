using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderVoiceMessagingGroupGetVoicePortalResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "voicePortalScope", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderVoicePortalScope VoicePortalScope { get; set; }
 }
}
