using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallTypeGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadworksConnector.Ocip.Models.SystemCallType> _callType;

    [XmlElement(ElementName = "callType", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SystemCallType> CallType {
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
