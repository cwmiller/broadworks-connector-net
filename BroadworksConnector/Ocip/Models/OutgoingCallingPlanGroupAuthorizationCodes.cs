using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingCallingPlanGroupAuthorizationCodes 
{
    private List<BroadworksConnector.Ocip.Models.OutgoingCallingPlanAuthorizationCodeEntry> _codeEntry;

    [XmlElement(ElementName = "codeEntry", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.OutgoingCallingPlanAuthorizationCodeEntry> CodeEntry {
        get => _codeEntry;
        set {
            CodeEntrySpecified = true;
            _codeEntry = value;
        }
    }

    [XmlIgnore]
    public bool CodeEntrySpecified { get; set; }
}
}
