using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserVoiceMessagingUserGetGreetingResponse20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "busyAnnouncementSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementSelection BusyAnnouncementSelection { get; set; }
    [XmlElement(ElementName = "busyPersonalAudioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey BusyPersonalAudioFile { get; set; }
    [XmlElement(ElementName = "busyPersonalVideoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey BusyPersonalVideoFile { get; set; }
    [XmlElement(ElementName = "noAnswerAnnouncementSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingNoAnswerGreetingSelection NoAnswerAnnouncementSelection { get; set; }
    [XmlElement(ElementName = "noAnswerPersonalAudioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey NoAnswerPersonalAudioFile { get; set; }
    [XmlElement(ElementName = "noAnswerPersonalVideoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey NoAnswerPersonalVideoFile { get; set; }
    [XmlElement(ElementName = "noAnswerAlternateGreeting01", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingRead20 NoAnswerAlternateGreeting01 { get; set; }
    [XmlElement(ElementName = "noAnswerAlternateGreeting02", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingRead20 NoAnswerAlternateGreeting02 { get; set; }
    [XmlElement(ElementName = "noAnswerAlternateGreeting03", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingRead20 NoAnswerAlternateGreeting03 { get; set; }
    [XmlElement(ElementName = "extendedAwayEnabled", IsNullable = false)]
    public bool ExtendedAwayEnabled { get; set; }
    [XmlElement(ElementName = "extendedAwayDisableMessageDeposit", IsNullable = false)]
    public bool ExtendedAwayDisableMessageDeposit { get; set; }
    [XmlElement(ElementName = "extendedAwayAudioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey ExtendedAwayAudioFile { get; set; }
    [XmlElement(ElementName = "extendedAwayVideoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey ExtendedAwayVideoFile { get; set; }
    [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingNumberOfRings NoAnswerNumberOfRings { get; set; }
    [XmlElement(ElementName = "disableMessageDeposit", IsNullable = false)]
    public bool DisableMessageDeposit { get; set; }
    [XmlElement(ElementName = "disableMessageDepositAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingDisableMessageDepositSelection DisableMessageDepositAction { get; set; }
    [XmlElement(ElementName = "greetingOnlyForwardDestination", IsNullable = false)]
    public string GreetingOnlyForwardDestination { get; set; }
 }
}
