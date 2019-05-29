using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupVoiceMessagingGroupGetVoicePortalBrandingResponse16 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "voicePortalGreetingSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingBrandingSelection VoicePortalGreetingSelection { get; set; }
    [XmlElement(ElementName = "voicePortalGreetingFileDescription", IsNullable = false)]
    public string VoicePortalGreetingFileDescription { get; set; }
    [XmlElement(ElementName = "voicePortalGreetingMediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType VoicePortalGreetingMediaType { get; set; }
    [XmlElement(ElementName = "voiceMessagingGreetingSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingBrandingSelection VoiceMessagingGreetingSelection { get; set; }
    [XmlElement(ElementName = "voiceMessagingGreetingFileDescription", IsNullable = false)]
    public string VoiceMessagingGreetingFileDescription { get; set; }
    [XmlElement(ElementName = "voiceMessagingGreetingMediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType VoiceMessagingGreetingMediaType { get; set; }
 }
}
