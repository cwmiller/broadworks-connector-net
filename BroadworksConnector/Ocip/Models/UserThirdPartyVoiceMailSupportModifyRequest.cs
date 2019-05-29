using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserThirdPartyVoiceMailSupportModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "busyRedirectToVoiceMail", IsNullable = false)]
    public bool BusyRedirectToVoiceMail { get; set; }
    [XmlElement(ElementName = "noAnswerRedirectToVoiceMail", IsNullable = false)]
    public bool NoAnswerRedirectToVoiceMail { get; set; }
    [XmlElement(ElementName = "serverSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ThirdPartyVoiceMailSupportServerSelection ServerSelection { get; set; }
    [XmlElement(ElementName = "userServer", IsNullable = true)]
    public string UserServer { get; set; }
    [XmlElement(ElementName = "mailboxIdType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ThirdPartyVoiceMailSupportMailboxIdType MailboxIdType { get; set; }
    [XmlElement(ElementName = "mailboxURL", IsNullable = true)]
    public string MailboxURL { get; set; }
    [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ThirdPartyVoiceMailSupportNumberOfRings NoAnswerNumberOfRings { get; set; }
    [XmlElement(ElementName = "alwaysRedirectToVoiceMail", IsNullable = false)]
    public bool AlwaysRedirectToVoiceMail { get; set; }
    [XmlElement(ElementName = "outOfPrimaryZoneRedirectToVoiceMail", IsNullable = false)]
    public bool OutOfPrimaryZoneRedirectToVoiceMail { get; set; }
 }
}
