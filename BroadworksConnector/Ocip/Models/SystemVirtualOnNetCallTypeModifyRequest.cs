using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVirtualOnNetCallTypeModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _virtualOnNetCallTypeName;

    [XmlElement(ElementName = "virtualOnNetCallTypeName", IsNullable = false, Namespace = "")]
    public string VirtualOnNetCallTypeName {
        get => _virtualOnNetCallTypeName;
        set {
            VirtualOnNetCallTypeNameSpecified = true;
            _virtualOnNetCallTypeName = value;
        }
    }

    [XmlIgnore]
    public bool VirtualOnNetCallTypeNameSpecified { get; set; }
    private string _virtualOnNetCallTypeCdrValue;

    [XmlElement(ElementName = "virtualOnNetCallTypeCdrValue", IsNullable = false, Namespace = "")]
    public string VirtualOnNetCallTypeCdrValue {
        get => _virtualOnNetCallTypeCdrValue;
        set {
            VirtualOnNetCallTypeCdrValueSpecified = true;
            _virtualOnNetCallTypeCdrValue = value;
        }
    }

    [XmlIgnore]
    public bool VirtualOnNetCallTypeCdrValueSpecified { get; set; }
}
}
