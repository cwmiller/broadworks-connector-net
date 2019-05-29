using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserVoiceMessagingUserGetVoicePortalResponse20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "usePersonalizedName", IsNullable = false)]
    public bool UsePersonalizedName { get; set; }
    [XmlElement(ElementName = "voicePortalAutoLogin", IsNullable = false)]
    public bool VoicePortalAutoLogin { get; set; }
    [XmlElement(ElementName = "personalizedNameAudioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey PersonalizedNameAudioFile { get; set; }
 }
}
