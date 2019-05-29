using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserVoiceMessagingUserGetVoiceManagementResponse13mp8 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "processing", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingMessageProcessing Processing { get; set; }
    [XmlElement(ElementName = "voiceMessageDeliveryEmailAddress", IsNullable = false)]
    public string VoiceMessageDeliveryEmailAddress { get; set; }
    [XmlElement(ElementName = "usePhoneMessageWaitingIndicator", IsNullable = false)]
    public bool UsePhoneMessageWaitingIndicator { get; set; }
    [XmlElement(ElementName = "sendVoiceMessageNotifyEmail", IsNullable = false)]
    public bool SendVoiceMessageNotifyEmail { get; set; }
    [XmlElement(ElementName = "voiceMessageNotifyEmailAddress", IsNullable = false)]
    public string VoiceMessageNotifyEmailAddress { get; set; }
    [XmlElement(ElementName = "sendCarbonCopyVoiceMessage", IsNullable = false)]
    public bool SendCarbonCopyVoiceMessage { get; set; }
    [XmlElement(ElementName = "voiceMessageCarbonCopyEmailAddress", IsNullable = false)]
    public string VoiceMessageCarbonCopyEmailAddress { get; set; }
    [XmlElement(ElementName = "transferOnZeroToPhoneNumber", IsNullable = false)]
    public bool TransferOnZeroToPhoneNumber { get; set; }
    [XmlElement(ElementName = "transferPhoneNumber", IsNullable = false)]
    public string TransferPhoneNumber { get; set; }
    [XmlElement(ElementName = "alwaysRedirectToVoiceMail", IsNullable = false)]
    public bool AlwaysRedirectToVoiceMail { get; set; }
    [XmlElement(ElementName = "busyRedirectToVoiceMail", IsNullable = false)]
    public bool BusyRedirectToVoiceMail { get; set; }
    [XmlElement(ElementName = "noAnswerRedirectToVoiceMail", IsNullable = false)]
    public bool NoAnswerRedirectToVoiceMail { get; set; }
 }
}
