using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementAlternateUserIdEntryList 
{
    private List<BroadworksConnector.Ocip.Models.AlternateUserIdEntry> _alternateUserId;

    [XmlElement(ElementName = "alternateUserId", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.AlternateUserIdEntry> AlternateUserId {
        get => _alternateUserId;
        set {
            AlternateUserIdSpecified = true;
            _alternateUserId = value;
        }
    }

    [XmlIgnore]
    public bool AlternateUserIdSpecified { get; set; }
}
}
