using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserVoiceMessagingUserModifyGreetingExecutionServerRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "busyAnnouncementSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementSelection BusyAnnouncementSelection { get; set; }
    [XmlElement(ElementName = "busyPersonalAudioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileNameResource BusyPersonalAudioFile { get; set; }
    [XmlElement(ElementName = "busyPersonalVideoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileNameResource BusyPersonalVideoFile { get; set; }
    [XmlElement(ElementName = "noAnswerAnnouncementSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingNoAnswerGreetingSelection NoAnswerAnnouncementSelection { get; set; }
    [XmlElement(ElementName = "noAnswerPersonalAudioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileNameResource NoAnswerPersonalAudioFile { get; set; }
    [XmlElement(ElementName = "noAnswerPersonalVideoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileNameResource NoAnswerPersonalVideoFile { get; set; }
    [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingNumberOfRings NoAnswerNumberOfRings { get; set; }
    [XmlElement(ElementName = "extendedAwayEnabled", IsNullable = false)]
    public bool ExtendedAwayEnabled { get; set; }
    [XmlElement(ElementName = "extendedAwayDisableMessageDeposit", IsNullable = false)]
    public bool ExtendedAwayDisableMessageDeposit { get; set; }
    [XmlElement(ElementName = "extendedAwayAudioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileNameResource ExtendedAwayAudioFile { get; set; }
    [XmlElement(ElementName = "extendedAwayVideoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileNameResource ExtendedAwayVideoFile { get; set; }
    [XmlElement(ElementName = "disableMessageDeposit", IsNullable = false)]
    public bool DisableMessageDeposit { get; set; }
    [XmlElement(ElementName = "disableMessageDepositAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingDisableMessageDepositSelection DisableMessageDepositAction { get; set; }
    [XmlElement(ElementName = "greetingOnlyForwardDestination", IsNullable = true)]
    public string GreetingOnlyForwardDestination { get; set; }
 }
}
