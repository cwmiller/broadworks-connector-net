using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderVoiceMessagingGroupGetVoicePortalBrandingResponse16 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "voicePortalGreetingSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingBrandingSelection VoicePortalGreetingSelection { get; set; }
    [XmlElement(ElementName = "voicePortalGreetingFileDescription", IsNullable = false)]
    public string VoicePortalGreetingFileDescription { get; set; }
    [XmlElement(ElementName = "voicePortalGreetingMediaFileType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType VoicePortalGreetingMediaFileType { get; set; }
    [XmlElement(ElementName = "voiceMessagingGreetingSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingBrandingSelection VoiceMessagingGreetingSelection { get; set; }
    [XmlElement(ElementName = "voiceMessagingGreetingFileDescription", IsNullable = false)]
    public string VoiceMessagingGreetingFileDescription { get; set; }
    [XmlElement(ElementName = "voiceMessagingGreetingMediaFileType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType VoiceMessagingGreetingMediaFileType { get; set; }
 }
}
