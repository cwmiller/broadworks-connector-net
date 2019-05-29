using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse14 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useVoicePortalCustomization", IsNullable = false)]
    public bool UseVoicePortalCustomization { get; set; }
    [XmlElement(ElementName = "voicePortalMainMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14VoicePortalMainMenuKeys VoicePortalMainMenuKeys { get; set; }
    [XmlElement(ElementName = "voiceMessagingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14VoiceMessagingMenuKeys VoiceMessagingMenuKeys { get; set; }
    [XmlElement(ElementName = "changeBusyOrNoAnswerGreetingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14ChangeBusyOrNoAnswerGreetingMenuKeys ChangeBusyOrNoAnswerGreetingMenuKeys { get; set; }
    [XmlElement(ElementName = "recordNewGreetingOrPersonalizedNameMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14RecordNewGreetingOrPersonalizedNameMenuKeys RecordNewGreetingOrPersonalizedNameMenuKeys { get; set; }
    [XmlElement(ElementName = "deleteAllMessagesMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14DeleteAllMessagesMenuKeys DeleteAllMessagesMenuKeys { get; set; }
    [XmlElement(ElementName = "commPilotExpressProfileMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14CommPilotExpressProfileMenuKeys CommPilotExpressProfileMenuKeys { get; set; }
    [XmlElement(ElementName = "personalizedNameMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14PersonalizedNameMenuKeys PersonalizedNameMenuKeys { get; set; }
    [XmlElement(ElementName = "callForwardingOptionsMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14CallForwardingOptionsMenuKeys CallForwardingOptionsMenuKeys { get; set; }
    [XmlElement(ElementName = "changeCallForwardingDestinationMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14ChangeCallForwardingDestinationMenuKeys ChangeCallForwardingDestinationMenuKeys { get; set; }
    [XmlElement(ElementName = "voicePortalCallingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14VoicePortalCallingMenuKeys VoicePortalCallingMenuKeys { get; set; }
    [XmlElement(ElementName = "hotelingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14HotelingMenuKeys HotelingMenuKeys { get; set; }
    [XmlElement(ElementName = "passcodeMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14PasscodeMenuKeys PasscodeMenuKeys { get; set; }
    [XmlElement(ElementName = "playMessagesMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14PlayMessagesMenuKeys PlayMessagesMenuKeys { get; set; }
    [XmlElement(ElementName = "playMessageMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14PlayMessageMenuKeys PlayMessageMenuKeys { get; set; }
    [XmlElement(ElementName = "additionalMessageOptionsMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14AdditionalMessageOptionsMenuKeys AdditionalMessageOptionsMenuKeys { get; set; }
    [XmlElement(ElementName = "forwardOrComposeMessageMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14ForwardOrComposeMessageMenuKeys ForwardOrComposeMessageMenuKeys { get; set; }
    [XmlElement(ElementName = "replyMessageMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14ReplyMessageMenuKeys ReplyMessageMenuKeys { get; set; }
    [XmlElement(ElementName = "sendToDistributionListMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14SendToDistributionListMenuKeys SendToDistributionListMenuKeys { get; set; }
    [XmlElement(ElementName = "selectDistributionListMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14SelectDistributionListMenuKeys SelectDistributionListMenuKeys { get; set; }
    [XmlElement(ElementName = "reviewSelectedDistributionListMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14ReviewSelectedDistributionListMenuKeys ReviewSelectedDistributionListMenuKeys { get; set; }
    [XmlElement(ElementName = "sendMessageToSelectedDistributionListMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14SendMessageToSelectedDistributionListMenuKeys SendMessageToSelectedDistributionListMenuKeys { get; set; }
    [XmlElement(ElementName = "sendToAllGroupMembersMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14SendToAllGroupMembersMenuKeys SendToAllGroupMembersMenuKeys { get; set; }
    [XmlElement(ElementName = "sendToPersonMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14SendToPersonMenuKeys SendToPersonMenuKeys { get; set; }
    [XmlElement(ElementName = "changeCurrentIntroductionOrMessageOrReplyMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14ChangeCurrentIntroductionOrMessageOrReplyMenuKeys ChangeCurrentIntroductionOrMessageOrReplyMenuKeys { get; set; }
    [XmlElement(ElementName = "voicePortalLoginMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14VoicePortalLoginMenuKeys VoicePortalLoginMenuKeys { get; set; }
    [XmlElement(ElementName = "faxMessagingMenuKeys", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemVoiceMessagingGroupGetVoicePortalMenusResponse14FaxMessagingMenuKeys FaxMessagingMenuKeys { get; set; }
 }
}
