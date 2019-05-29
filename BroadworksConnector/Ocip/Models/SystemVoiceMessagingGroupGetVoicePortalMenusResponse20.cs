using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useVoicePortalCustomization", IsNullable = false)]
    public bool UseVoicePortalCustomization { get; set; }
    [XmlElement(ElementName = "voicePortalMainMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20VoicePortalMainMenuKeys VoicePortalMainMenuKeys { get; set; }
    [XmlElement(ElementName = "announcementMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20AnnouncementMenuKeys AnnouncementMenuKeys { get; set; }
    [XmlElement(ElementName = "announcementRecordingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20AnnouncementRecordingMenuKeys AnnouncementRecordingMenuKeys { get; set; }
    [XmlElement(ElementName = "greetingsMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20GreetingsMenuKeys GreetingsMenuKeys { get; set; }
    [XmlElement(ElementName = "conferenceGreetingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20ConferenceGreetingMenuKeys ConferenceGreetingMenuKeys { get; set; }
    [XmlElement(ElementName = "voiceMessagingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20VoiceMessagingMenuKeys VoiceMessagingMenuKeys { get; set; }
    [XmlElement(ElementName = "playGreetingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20PlayGreetingMenuKeys PlayGreetingMenuKeys { get; set; }
    [XmlElement(ElementName = "changeBusyOrNoAnswerGreetingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20ChangeBusyOrNoAnswerGreetingMenuKeys ChangeBusyOrNoAnswerGreetingMenuKeys { get; set; }
    [XmlElement(ElementName = "changeExtendedAwayGreetingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20ChangeExtendedAwayGreetingMenuKeys ChangeExtendedAwayGreetingMenuKeys { get; set; }
    [XmlElement(ElementName = "recordNewGreetingOrPersonalizedNameMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20RecordNewGreetingOrPersonalizedNameMenuKeys RecordNewGreetingOrPersonalizedNameMenuKeys { get; set; }
    [XmlElement(ElementName = "deleteAllMessagesMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20DeleteAllMessagesMenuKeys DeleteAllMessagesMenuKeys { get; set; }
    [XmlElement(ElementName = "commPilotExpressProfileMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20CommPilotExpressProfileMenuKeys CommPilotExpressProfileMenuKeys { get; set; }
    [XmlElement(ElementName = "personalizedNameMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20PersonalizedNameMenuKeys PersonalizedNameMenuKeys { get; set; }
    [XmlElement(ElementName = "callForwardingOptionsMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20CallForwardingOptionsMenuKeys CallForwardingOptionsMenuKeys { get; set; }
    [XmlElement(ElementName = "changeCallForwardingDestinationMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20ChangeCallForwardingDestinationMenuKeys ChangeCallForwardingDestinationMenuKeys { get; set; }
    [XmlElement(ElementName = "voicePortalCallingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20VoicePortalCallingMenuKeys VoicePortalCallingMenuKeys { get; set; }
    [XmlElement(ElementName = "hotelingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20HotelingMenuKeys HotelingMenuKeys { get; set; }
    [XmlElement(ElementName = "passcodeMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20PasscodeMenuKeys PasscodeMenuKeys { get; set; }
    [XmlElement(ElementName = "playMessagesMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20PlayMessagesMenuKeys PlayMessagesMenuKeys { get; set; }
    [XmlElement(ElementName = "playMessageMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20PlayMessageMenuKeys PlayMessageMenuKeys { get; set; }
    [XmlElement(ElementName = "additionalMessageOptionsMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20AdditionalMessageOptionsMenuKeys AdditionalMessageOptionsMenuKeys { get; set; }
    [XmlElement(ElementName = "forwardOrComposeMessageMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20ForwardOrComposeMessageMenuKeys ForwardOrComposeMessageMenuKeys { get; set; }
    [XmlElement(ElementName = "replyMessageMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20ReplyMessageMenuKeys ReplyMessageMenuKeys { get; set; }
    [XmlElement(ElementName = "sendToDistributionListMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20SendToDistributionListMenuKeys SendToDistributionListMenuKeys { get; set; }
    [XmlElement(ElementName = "selectDistributionListMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20SelectDistributionListMenuKeys SelectDistributionListMenuKeys { get; set; }
    [XmlElement(ElementName = "reviewSelectedDistributionListMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20ReviewSelectedDistributionListMenuKeys ReviewSelectedDistributionListMenuKeys { get; set; }
    [XmlElement(ElementName = "sendMessageToSelectedDistributionListMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20SendMessageToSelectedDistributionListMenuKeys SendMessageToSelectedDistributionListMenuKeys { get; set; }
    [XmlElement(ElementName = "sendToAllGroupMembersMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20SendToAllGroupMembersMenuKeys SendToAllGroupMembersMenuKeys { get; set; }
    [XmlElement(ElementName = "sendToPersonMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20SendToPersonMenuKeys SendToPersonMenuKeys { get; set; }
    [XmlElement(ElementName = "changeCurrentIntroductionOrMessageOrReplyMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20ChangeCurrentIntroductionOrMessageOrReplyMenuKeys ChangeCurrentIntroductionOrMessageOrReplyMenuKeys { get; set; }
    [XmlElement(ElementName = "voicePortalLoginMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20VoicePortalLoginMenuKeys VoicePortalLoginMenuKeys { get; set; }
    [XmlElement(ElementName = "faxMessagingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20FaxMessagingMenuKeys FaxMessagingMenuKeys { get; set; }
    [XmlElement(ElementName = "messageDepositMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20MessageDepositMenuKeys MessageDepositMenuKeys { get; set; }
    [XmlElement(ElementName = "disableMessageDepositMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20DisableMessageDepositMenuKeys DisableMessageDepositMenuKeys { get; set; }
    [XmlElement(ElementName = "greetingOnlyForwardingDestinationMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse20GreetingOnlyForwardingDestinationMenuKeys GreetingOnlyForwardingDestinationMenuKeys { get; set; }
 }
}
