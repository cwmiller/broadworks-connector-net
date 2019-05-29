using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserVoiceMessagingUserModifyGreetingRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "busyAnnouncementSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementSelection BusyAnnouncementSelection { get; set; }
    [XmlElement(ElementName = "busyPersonalAudioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileResource BusyPersonalAudioFile { get; set; }
    [XmlElement(ElementName = "busyPersonalVideoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileResource BusyPersonalVideoFile { get; set; }
    [XmlElement(ElementName = "noAnswerAnnouncementSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingNoAnswerGreetingSelection NoAnswerAnnouncementSelection { get; set; }
    [XmlElement(ElementName = "noAnswerPersonalAudioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileResource NoAnswerPersonalAudioFile { get; set; }
    [XmlElement(ElementName = "noAnswerPersonalVideoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileResource NoAnswerPersonalVideoFile { get; set; }
    [XmlElement(ElementName = "noAnswerAlternateGreeting01", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify NoAnswerAlternateGreeting01 { get; set; }
    [XmlElement(ElementName = "noAnswerAlternateGreeting02", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify NoAnswerAlternateGreeting02 { get; set; }
    [XmlElement(ElementName = "noAnswerAlternateGreeting03", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify NoAnswerAlternateGreeting03 { get; set; }
    [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingNumberOfRings NoAnswerNumberOfRings { get; set; }
 }
}
