using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserVoiceMessagingUserModifyVoicePortalRequest20 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "usePersonalizedName", IsNullable = false)]
    public bool UsePersonalizedName { get; set; }
    [XmlElement(ElementName = "voicePortalAutoLogin", IsNullable = false)]
    public bool VoicePortalAutoLogin { get; set; }
    [XmlElement(ElementName = "personalizedNameAudioFile", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey PersonalizedNameAudioFile { get; set; }
 }
}
