using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCPEConfigParametersModifyRequestFileRebuildHourly 
{
    private int _startMinute;

    [XmlElement(ElementName = "startMinute", IsNullable = false, Namespace = "")]
    public int StartMinute {
        get => _startMinute;
        set {
            StartMinuteSpecified = true;
            _startMinute = value;
        }
    }

    [XmlIgnore]
    public bool StartMinuteSpecified { get; set; }
}
}
