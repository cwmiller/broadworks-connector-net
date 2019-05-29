using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupVoiceMessagingGroupModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "useMailServerSetting", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingGroupMailServerChoices UseMailServerSetting { get; set; }
    [XmlElement(ElementName = "warnCallerBeforeRecordingVoiceMessage", IsNullable = false)]
    public bool WarnCallerBeforeRecordingVoiceMessage { get; set; }
    [XmlElement(ElementName = "allowUsersConfiguringAdvancedSettings", IsNullable = false)]
    public bool AllowUsersConfiguringAdvancedSettings { get; set; }
    [XmlElement(ElementName = "allowComposeOrForwardMessageToEntireGroup", IsNullable = false)]
    public bool AllowComposeOrForwardMessageToEntireGroup { get; set; }
    [XmlElement(ElementName = "mailServerNetAddress", IsNullable = true)]
    public string MailServerNetAddress { get; set; }
    [XmlElement(ElementName = "mailServerProtocol", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingMailServerProtocol MailServerProtocol { get; set; }
    [XmlElement(ElementName = "realDeleteForImap", IsNullable = false)]
    public bool RealDeleteForImap { get; set; }
    [XmlElement(ElementName = "maxMailboxLengthMinutes", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingMailboxLengthMinutes MaxMailboxLengthMinutes { get; set; }
    [XmlElement(ElementName = "doesMessageAge", IsNullable = false)]
    public bool DoesMessageAge { get; set; }
    [XmlElement(ElementName = "holdPeriodDays", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingHoldPeriodDays HoldPeriodDays { get; set; }
 }
}
