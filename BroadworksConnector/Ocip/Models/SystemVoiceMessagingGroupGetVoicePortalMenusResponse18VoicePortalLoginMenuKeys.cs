using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse18VoicePortalLoginMenuKeys 
{
    private string _accessUsingOtherMailboxId;

    [XmlElement(ElementName = "accessUsingOtherMailboxId", IsNullable = false, Namespace = "")]
    public string AccessUsingOtherMailboxId {
        get => _accessUsingOtherMailboxId;
        set {
            AccessUsingOtherMailboxIdSpecified = true;
            _accessUsingOtherMailboxId = value;
        }
    }

    [XmlIgnore]
    public bool AccessUsingOtherMailboxIdSpecified { get; set; }
}
}
