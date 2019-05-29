using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserVoiceMessagingUserGetGreetingResponse13mp16 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "busyAnnouncementSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementSelection BusyAnnouncementSelection { get; set; }
    [XmlElement(ElementName = "busyPersonalAudioFile", IsNullable = false)]
    public string BusyPersonalAudioFile { get; set; }
    [XmlElement(ElementName = "busyPersonalVideoFile", IsNullable = false)]
    public string BusyPersonalVideoFile { get; set; }
    [XmlElement(ElementName = "noAnswerAnnouncementSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingNoAnswerGreetingSelection NoAnswerAnnouncementSelection { get; set; }
    [XmlElement(ElementName = "noAnswerPersonalAudioFile", IsNullable = false)]
    public string NoAnswerPersonalAudioFile { get; set; }
    [XmlElement(ElementName = "noAnswerPersonalVideoFile", IsNullable = false)]
    public string NoAnswerPersonalVideoFile { get; set; }
    [XmlElement(ElementName = "noAnswerAlternateGreeting01", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingRead NoAnswerAlternateGreeting01 { get; set; }
    [XmlElement(ElementName = "noAnswerAlternateGreeting02", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingRead NoAnswerAlternateGreeting02 { get; set; }
    [XmlElement(ElementName = "noAnswerAlternateGreeting03", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingRead NoAnswerAlternateGreeting03 { get; set; }
    [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingNumberOfRings NoAnswerNumberOfRings { get; set; }
 }
}
