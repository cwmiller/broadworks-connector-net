using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserEnhancedCallLogsGetListResponse22LegacyEntry 
{
    private List<BroadWorksConnector.Ocip.Models.MixedCallLogsEntry> _callLog;

    [XmlElement(ElementName = "callLog", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.MixedCallLogsEntry> CallLog {
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
