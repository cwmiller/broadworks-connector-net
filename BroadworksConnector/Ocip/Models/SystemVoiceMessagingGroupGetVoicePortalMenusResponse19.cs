using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useVoicePortalCustomization", IsNullable = false)]
    public bool UseVoicePortalCustomization { get; set; }
    [XmlElement(ElementName = "voicePortalMainMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19VoicePortalMainMenuKeys VoicePortalMainMenuKeys { get; set; }
    [XmlElement(ElementName = "greetingsMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19GreetingsMenuKeys GreetingsMenuKeys { get; set; }
    [XmlElement(ElementName = "conferenceGreetingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19ConferenceGreetingMenuKeys ConferenceGreetingMenuKeys { get; set; }
    [XmlElement(ElementName = "voiceMessagingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19VoiceMessagingMenuKeys VoiceMessagingMenuKeys { get; set; }
    [XmlElement(ElementName = "playGreetingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19PlayGreetingMenuKeys PlayGreetingMenuKeys { get; set; }
    [XmlElement(ElementName = "changeBusyOrNoAnswerGreetingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19ChangeBusyOrNoAnswerGreetingMenuKeys ChangeBusyOrNoAnswerGreetingMenuKeys { get; set; }
    [XmlElement(ElementName = "recordNewGreetingOrPersonalizedNameMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19RecordNewGreetingOrPersonalizedNameMenuKeys RecordNewGreetingOrPersonalizedNameMenuKeys { get; set; }
    [XmlElement(ElementName = "deleteAllMessagesMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19DeleteAllMessagesMenuKeys DeleteAllMessagesMenuKeys { get; set; }
    [XmlElement(ElementName = "commPilotExpressProfileMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19CommPilotExpressProfileMenuKeys CommPilotExpressProfileMenuKeys { get; set; }
    [XmlElement(ElementName = "personalizedNameMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19PersonalizedNameMenuKeys PersonalizedNameMenuKeys { get; set; }
    [XmlElement(ElementName = "callForwardingOptionsMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19CallForwardingOptionsMenuKeys CallForwardingOptionsMenuKeys { get; set; }
    [XmlElement(ElementName = "changeCallForwardingDestinationMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19ChangeCallForwardingDestinationMenuKeys ChangeCallForwardingDestinationMenuKeys { get; set; }
    [XmlElement(ElementName = "voicePortalCallingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19VoicePortalCallingMenuKeys VoicePortalCallingMenuKeys { get; set; }
    [XmlElement(ElementName = "hotelingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19HotelingMenuKeys HotelingMenuKeys { get; set; }
    [XmlElement(ElementName = "passcodeMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19PasscodeMenuKeys PasscodeMenuKeys { get; set; }
    [XmlElement(ElementName = "playMessagesMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19PlayMessagesMenuKeys PlayMessagesMenuKeys { get; set; }
    [XmlElement(ElementName = "playMessageMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19PlayMessageMenuKeys PlayMessageMenuKeys { get; set; }
    [XmlElement(ElementName = "additionalMessageOptionsMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19AdditionalMessageOptionsMenuKeys AdditionalMessageOptionsMenuKeys { get; set; }
    [XmlElement(ElementName = "forwardOrComposeMessageMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19ForwardOrComposeMessageMenuKeys ForwardOrComposeMessageMenuKeys { get; set; }
    [XmlElement(ElementName = "replyMessageMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19ReplyMessageMenuKeys ReplyMessageMenuKeys { get; set; }
    [XmlElement(ElementName = "sendToDistributionListMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19SendToDistributionListMenuKeys SendToDistributionListMenuKeys { get; set; }
    [XmlElement(ElementName = "selectDistributionListMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19SelectDistributionListMenuKeys SelectDistributionListMenuKeys { get; set; }
    [XmlElement(ElementName = "reviewSelectedDistributionListMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19ReviewSelectedDistributionListMenuKeys ReviewSelectedDistributionListMenuKeys { get; set; }
    [XmlElement(ElementName = "sendMessageToSelectedDistributionListMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19SendMessageToSelectedDistributionListMenuKeys SendMessageToSelectedDistributionListMenuKeys { get; set; }
    [XmlElement(ElementName = "sendToAllGroupMembersMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19SendToAllGroupMembersMenuKeys SendToAllGroupMembersMenuKeys { get; set; }
    [XmlElement(ElementName = "sendToPersonMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19SendToPersonMenuKeys SendToPersonMenuKeys { get; set; }
    [XmlElement(ElementName = "changeCurrentIntroductionOrMessageOrReplyMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19ChangeCurrentIntroductionOrMessageOrReplyMenuKeys ChangeCurrentIntroductionOrMessageOrReplyMenuKeys { get; set; }
    [XmlElement(ElementName = "voicePortalLoginMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19VoicePortalLoginMenuKeys VoicePortalLoginMenuKeys { get; set; }
    [XmlElement(ElementName = "faxMessagingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19FaxMessagingMenuKeys FaxMessagingMenuKeys { get; set; }
    [XmlElement(ElementName = "messageDepositMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19MessageDepositMenuKeys MessageDepositMenuKeys { get; set; }
    [XmlElement(ElementName = "disableMessageDepositMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19DisableMessageDepositMenuKeys DisableMessageDepositMenuKeys { get; set; }
    [XmlElement(ElementName = "greetingOnlyForwardingDestinationMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19GreetingOnlyForwardingDestinationMenuKeys GreetingOnlyForwardingDestinationMenuKeys { get; set; }
 }
}
