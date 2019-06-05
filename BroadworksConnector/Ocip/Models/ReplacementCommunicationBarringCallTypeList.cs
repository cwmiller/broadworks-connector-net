using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCommunicationBarringCallTypeList 
{
    private List<string> _callType;

    [XmlElement(ElementName = "callType", IsNullable = false, Namespace = "")]
    public List<string> CallType {
        get => _callType;
        set {
            CallTypeSpecified = true;
            _callType = value;
        }
    }

    [XmlIgnore]
    public bool CallTypeSpecified { get; set; }
}
}
