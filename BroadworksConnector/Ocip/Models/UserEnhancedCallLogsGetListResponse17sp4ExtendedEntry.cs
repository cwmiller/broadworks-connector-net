using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserEnhancedCallLogsGetListResponse17sp4ExtendedEntry 
{
    private List<BroadworksConnector.Ocip.Models.ExtendedMixedCallLogsEntry> _extendedCallLog;

    [XmlElement(ElementName = "extendedCallLog", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.ExtendedMixedCallLogsEntry> ExtendedCallLog {
        get => _extendedCallLog;
        set {
            ExtendedCallLogSpecified = true;
            _extendedCallLog = value;
        }
    }

    [XmlIgnore]
    public bool ExtendedCallLogSpecified { get; set; }
}
}
