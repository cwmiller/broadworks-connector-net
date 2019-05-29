using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserVoiceMessagingUserModifyRequest23 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "mailServerSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingUserMailServerSelection MailServerSelection { get; set; }
    [XmlElement(ElementName = "groupMailServerEmailAddress", IsNullable = false)]
    public string GroupMailServerEmailAddress { get; set; }
    [XmlElement(ElementName = "groupMailServerUserId", IsNullable = false)]
    public string GroupMailServerUserId { get; set; }
    [XmlElement(ElementName = "groupMailServerPassword", IsNullable = false)]
    public string GroupMailServerPassword { get; set; }
    [XmlElement(ElementName = "useGroupDefaultMailServerFullMailboxLimit", IsNullable = false)]
    public bool UseGroupDefaultMailServerFullMailboxLimit { get; set; }
    [XmlElement(ElementName = "groupMailServerFullMailboxLimit", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingMailboxLengthMinutes GroupMailServerFullMailboxLimit { get; set; }
    [XmlElement(ElementName = "personalMailServerNetAddress", IsNullable = false)]
    public string PersonalMailServerNetAddress { get; set; }
    [XmlElement(ElementName = "personalMailServerProtocol", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingMailServerProtocol PersonalMailServerProtocol { get; set; }
    [XmlElement(ElementName = "personalMailServerRealDeleteForImap", IsNullable = false)]
    public bool PersonalMailServerRealDeleteForImap { get; set; }
    [XmlElement(ElementName = "personalMailServerEmailAddress", IsNullable = false)]
    public string PersonalMailServerEmailAddress { get; set; }
    [XmlElement(ElementName = "personalMailServerUserId", IsNullable = false)]
    public string PersonalMailServerUserId { get; set; }
    [XmlElement(ElementName = "personalMailServerPassword", IsNullable = false)]
    public string PersonalMailServerPassword { get; set; }
    [XmlElement(ElementName = "voiceMessagingDistributionList", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.VoiceMessagingDistributionListModify> VoiceMessagingDistributionList { get; set; }
    [XmlElement(ElementName = "busyAnnouncementSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementSelection BusyAnnouncementSelection { get; set; }
    [XmlElement(ElementName = "busyPersonalAudioFile", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey BusyPersonalAudioFile { get; set; }
    [XmlElement(ElementName = "busyPersonalVideoFile", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey BusyPersonalVideoFile { get; set; }
    [XmlElement(ElementName = "noAnswerAnnouncementSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingNoAnswerGreetingSelection NoAnswerAnnouncementSelection { get; set; }
    [XmlElement(ElementName = "noAnswerPersonalAudioFile", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey NoAnswerPersonalAudioFile { get; set; }
    [XmlElement(ElementName = "noAnswerPersonalVideoFile", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey NoAnswerPersonalVideoFile { get; set; }
    [XmlElement(ElementName = "noAnswerAlternateGreeting01", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify20 NoAnswerAlternateGreeting01 { get; set; }
    [XmlElement(ElementName = "noAnswerAlternateGreeting02", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify20 NoAnswerAlternateGreeting02 { get; set; }
    [XmlElement(ElementName = "noAnswerAlternateGreeting03", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingAlternateNoAnswerGreetingModify20 NoAnswerAlternateGreeting03 { get; set; }
    [XmlElement(ElementName = "extendedAwayEnabled", IsNullable = false)]
    public bool ExtendedAwayEnabled { get; set; }
    [XmlElement(ElementName = "extendedAwayDisableMessageDeposit", IsNullable = false)]
    public bool ExtendedAwayDisableMessageDeposit { get; set; }
    [XmlElement(ElementName = "extendedAwayAudioFile", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey ExtendedAwayAudioFile { get; set; }
    [XmlElement(ElementName = "extendedAwayVideoFile", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey ExtendedAwayVideoFile { get; set; }
    [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingNumberOfRings NoAnswerNumberOfRings { get; set; }
    [XmlElement(ElementName = "disableMessageDeposit", IsNullable = false)]
    public bool DisableMessageDeposit { get; set; }
    [XmlElement(ElementName = "disableMessageDepositAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingDisableMessageDepositSelection DisableMessageDepositAction { get; set; }
    [XmlElement(ElementName = "greetingOnlyForwardDestination", IsNullable = true)]
    public string GreetingOnlyForwardDestination { get; set; }
    [XmlElement(ElementName = "outgoingSMDIMWIisActive", IsNullable = false)]
    public bool OutgoingSMDIMWIisActive { get; set; }
    [XmlElement(ElementName = "outgoingSMDIMWIPhoneNumberList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementOutgoingDNList OutgoingSMDIMWIPhoneNumberList { get; set; }
    [XmlElement(ElementName = "voiceManagementisActive", IsNullable = false)]
    public bool VoiceManagementisActive { get; set; }
    [XmlElement(ElementName = "processing", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingMessageProcessing Processing { get; set; }
    [XmlElement(ElementName = "voiceMessageDeliveryEmailAddress", IsNullable = true)]
    public string VoiceMessageDeliveryEmailAddress { get; set; }
    [XmlElement(ElementName = "usePhoneMessageWaitingIndicator", IsNullable = false)]
    public bool UsePhoneMessageWaitingIndicator { get; set; }
    [XmlElement(ElementName = "sendVoiceMessageNotifyEmail", IsNullable = false)]
    public bool SendVoiceMessageNotifyEmail { get; set; }
    [XmlElement(ElementName = "voiceMessageNotifyEmailAddress", IsNullable = true)]
    public string VoiceMessageNotifyEmailAddress { get; set; }
    [XmlElement(ElementName = "sendCarbonCopyVoiceMessage", IsNullable = false)]
    public bool SendCarbonCopyVoiceMessage { get; set; }
    [XmlElement(ElementName = "voiceMessageCarbonCopyEmailAddress", IsNullable = true)]
    public string VoiceMessageCarbonCopyEmailAddress { get; set; }
    [XmlElement(ElementName = "transferOnZeroToPhoneNumber", IsNullable = false)]
    public bool TransferOnZeroToPhoneNumber { get; set; }
    [XmlElement(ElementName = "transferPhoneNumber", IsNullable = true)]
    public string TransferPhoneNumber { get; set; }
    [XmlElement(ElementName = "alwaysRedirectToVoiceMail", IsNullable = false)]
    public bool AlwaysRedirectToVoiceMail { get; set; }
    [XmlElement(ElementName = "busyRedirectToVoiceMail", IsNullable = false)]
    public bool BusyRedirectToVoiceMail { get; set; }
    [XmlElement(ElementName = "noAnswerRedirectToVoiceMail", IsNullable = false)]
    public bool NoAnswerRedirectToVoiceMail { get; set; }
    [XmlElement(ElementName = "outOfPrimaryZoneRedirectToVoiceMail", IsNullable = false)]
    public bool OutOfPrimaryZoneRedirectToVoiceMail { get; set; }
    [XmlElement(ElementName = "usePersonalizedName", IsNullable = false)]
    public bool UsePersonalizedName { get; set; }
    [XmlElement(ElementName = "voicePortalAutoLogin", IsNullable = false)]
    public bool VoicePortalAutoLogin { get; set; }
    [XmlElement(ElementName = "personalizedNameAudioFile", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey PersonalizedNameAudioFile { get; set; }
    [XmlElement(ElementName = "userMessagingAliasList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingAliasReplacementList UserMessagingAliasList { get; set; }
 }
}
