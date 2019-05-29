using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserVoiceMessagingUserGetAdvancedVoiceManagementResponse14sp3 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "mailServerSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.VoiceMessagingUserMailServerSelection MailServerSelection { get; set; }
    [XmlElement(ElementName = "groupMailServerEmailAddress", IsNullable = false)]
    public string GroupMailServerEmailAddress { get; set; }
    [XmlElement(ElementName = "groupMailServerUserId", IsNullable = false)]
    public string GroupMailServerUserId { get; set; }
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
 }
}
