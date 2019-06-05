using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserEnhancedCallLogsGetListResponse17sp4V2LegacyEntry 
{
    private List<BroadworksConnector.Ocip.Models.MixedCallLogsEntry> _callLog;

    [XmlElement(ElementName = "callLog", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.MixedCallLogsEntry> CallLog {
        get => _callLog;
        set {
            CallLogSpecified = true;
            _callLog = value;
        }
    }

    [XmlIgnore]
    public bool CallLogSpecified { get; set; }
}
}
