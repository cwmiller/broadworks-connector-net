using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class VoicePortalLoginMenuKeysModifyEntry 
{
    private string _accessUsingOtherMailboxId;

    [XmlElement(ElementName = "accessUsingOtherMailboxId", IsNullable = true, Namespace = "")]
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
