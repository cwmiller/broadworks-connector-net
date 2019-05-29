using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserVoiceMessagingUserModifyGreetingRequest16 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "busyAnnouncementSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementSelection BusyAnnouncementSelection { get; set; }
    [XmlElement(ElementName = "busyPersonalAudioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource BusyPersonalAudioFile { get; set; }
    [XmlElement(ElementName = "busyPersonalVideoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource BusyPersonalVideoFile { get; set; }
    [XmlElement(ElementName = "noAnswerAnnouncementSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingNoAnswerGreetingSelection NoAnswerAnnouncementSelection { get; set; }
    [XmlElement(ElementName = "noAnswerPersonalAudioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource NoAnswerPersonalAudioFile { get; set; }
    [XmlElement(ElementName = "noAnswerPersonalVideoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource NoAnswerPersonalVideoFile { get; set; }
    [XmlElement(ElementName = "extendedAwayEnabled", IsNullable = false)]
    public bool ExtendedAwayEnabled { get; set; }
    [XmlElement(ElementName = "extendedAwayDisableMessageDeposit", IsNullable = false)]
    public bool ExtendedAwayDisableMessageDeposit { get; set; }
    [XmlElement(ElementName = "extendedAwayAudioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource ExtendedAwayAudioFile { get; set; }
    [XmlElement(ElementName = "extendedAwayVideoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource ExtendedAwayVideoFile { get; set; }
    [XmlElement(ElementName = "noAnswerAlternateGreeting01", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify16 NoAnswerAlternateGreeting01 { get; set; }
    [XmlElement(ElementName = "noAnswerAlternateGreeting02", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify16 NoAnswerAlternateGreeting02 { get; set; }
    [XmlElement(ElementName = "noAnswerAlternateGreeting03", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify16 NoAnswerAlternateGreeting03 { get; set; }
    [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingNumberOfRings NoAnswerNumberOfRings { get; set; }
    [XmlElement(ElementName = "disableMessageDeposit", IsNullable = false)]
    public bool DisableMessageDeposit { get; set; }
    [XmlElement(ElementName = "disableMessageDepositAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingDisableMessageDepositSelection DisableMessageDepositAction { get; set; }
    [XmlElement(ElementName = "greetingOnlyForwardDestination", IsNullable = true)]
    public string GreetingOnlyForwardDestination { get; set; }
 }
}
