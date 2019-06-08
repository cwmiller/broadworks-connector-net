using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCommunicationBarringCallTypeAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _callType;

    [XmlElement(ElementName = "callType", IsNullable = false, Namespace = "")]
    public string CallType {
        get => _callType;
        set {
            CallTypeSpecified = true;
            _callType = value;
        }
    }

    [XmlIgnore]
    public bool CallTypeSpecified { get; set; }
    private string _networkServerCallType;

    [XmlElement(ElementName = "networkServerCallType", IsNullable = false, Namespace = "")]
    public string NetworkServerCallType {
        get => _networkServerCallType;
        set {
            NetworkServerCallTypeSpecified = true;
            _networkServerCallType = value;
        }
    }

    [XmlIgnore]
    public bool NetworkServerCallTypeSpecified { get; set; }
}
}
