using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useVoicePortalCustomization", IsNullable = false)]
    public bool UseVoicePortalCustomization { get; set; }
    [XmlElement(ElementName = "voicePortalMainMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1VoicePortalMainMenuKeys VoicePortalMainMenuKeys { get; set; }
    [XmlElement(ElementName = "greetingsMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1GreetingsMenuKeys GreetingsMenuKeys { get; set; }
    [XmlElement(ElementName = "conferenceGreetingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1ConferenceGreetingMenuKeys ConferenceGreetingMenuKeys { get; set; }
    [XmlElement(ElementName = "voiceMessagingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1VoiceMessagingMenuKeys VoiceMessagingMenuKeys { get; set; }
    [XmlElement(ElementName = "playGreetingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1PlayGreetingMenuKeys PlayGreetingMenuKeys { get; set; }
    [XmlElement(ElementName = "changeBusyOrNoAnswerGreetingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1ChangeBusyOrNoAnswerGreetingMenuKeys ChangeBusyOrNoAnswerGreetingMenuKeys { get; set; }
    [XmlElement(ElementName = "changeExtendedAwayGreetingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1ChangeExtendedAwayGreetingMenuKeys ChangeExtendedAwayGreetingMenuKeys { get; set; }
    [XmlElement(ElementName = "recordNewGreetingOrPersonalizedNameMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1RecordNewGreetingOrPersonalizedNameMenuKeys RecordNewGreetingOrPersonalizedNameMenuKeys { get; set; }
    [XmlElement(ElementName = "deleteAllMessagesMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1DeleteAllMessagesMenuKeys DeleteAllMessagesMenuKeys { get; set; }
    [XmlElement(ElementName = "commPilotExpressProfileMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1CommPilotExpressProfileMenuKeys CommPilotExpressProfileMenuKeys { get; set; }
    [XmlElement(ElementName = "personalizedNameMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1PersonalizedNameMenuKeys PersonalizedNameMenuKeys { get; set; }
    [XmlElement(ElementName = "callForwardingOptionsMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1CallForwardingOptionsMenuKeys CallForwardingOptionsMenuKeys { get; set; }
    [XmlElement(ElementName = "changeCallForwardingDestinationMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1ChangeCallForwardingDestinationMenuKeys ChangeCallForwardingDestinationMenuKeys { get; set; }
    [XmlElement(ElementName = "voicePortalCallingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1VoicePortalCallingMenuKeys VoicePortalCallingMenuKeys { get; set; }
    [XmlElement(ElementName = "hotelingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1HotelingMenuKeys HotelingMenuKeys { get; set; }
    [XmlElement(ElementName = "passcodeMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1PasscodeMenuKeys PasscodeMenuKeys { get; set; }
    [XmlElement(ElementName = "playMessagesMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1PlayMessagesMenuKeys PlayMessagesMenuKeys { get; set; }
    [XmlElement(ElementName = "playMessageMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1PlayMessageMenuKeys PlayMessageMenuKeys { get; set; }
    [XmlElement(ElementName = "additionalMessageOptionsMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1AdditionalMessageOptionsMenuKeys AdditionalMessageOptionsMenuKeys { get; set; }
    [XmlElement(ElementName = "forwardOrComposeMessageMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1ForwardOrComposeMessageMenuKeys ForwardOrComposeMessageMenuKeys { get; set; }
    [XmlElement(ElementName = "replyMessageMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1ReplyMessageMenuKeys ReplyMessageMenuKeys { get; set; }
    [XmlElement(ElementName = "sendToDistributionListMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1SendToDistributionListMenuKeys SendToDistributionListMenuKeys { get; set; }
    [XmlElement(ElementName = "selectDistributionListMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1SelectDistributionListMenuKeys SelectDistributionListMenuKeys { get; set; }
    [XmlElement(ElementName = "reviewSelectedDistributionListMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1ReviewSelectedDistributionListMenuKeys ReviewSelectedDistributionListMenuKeys { get; set; }
    [XmlElement(ElementName = "sendMessageToSelectedDistributionListMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1SendMessageToSelectedDistributionListMenuKeys SendMessageToSelectedDistributionListMenuKeys { get; set; }
    [XmlElement(ElementName = "sendToAllGroupMembersMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1SendToAllGroupMembersMenuKeys SendToAllGroupMembersMenuKeys { get; set; }
    [XmlElement(ElementName = "sendToPersonMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1SendToPersonMenuKeys SendToPersonMenuKeys { get; set; }
    [XmlElement(ElementName = "changeCurrentIntroductionOrMessageOrReplyMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1ChangeCurrentIntroductionOrMessageOrReplyMenuKeys ChangeCurrentIntroductionOrMessageOrReplyMenuKeys { get; set; }
    [XmlElement(ElementName = "voicePortalLoginMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1VoicePortalLoginMenuKeys VoicePortalLoginMenuKeys { get; set; }
    [XmlElement(ElementName = "faxMessagingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1FaxMessagingMenuKeys FaxMessagingMenuKeys { get; set; }
    [XmlElement(ElementName = "messageDepositMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1MessageDepositMenuKeys MessageDepositMenuKeys { get; set; }
    [XmlElement(ElementName = "disableMessageDepositMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1DisableMessageDepositMenuKeys DisableMessageDepositMenuKeys { get; set; }
    [XmlElement(ElementName = "greetingOnlyForwardingDestinationMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1GreetingOnlyForwardingDestinationMenuKeys GreetingOnlyForwardingDestinationMenuKeys { get; set; }
 }
}
