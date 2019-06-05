using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVirtualOnNetCallTypeGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _virtualOnNetCallTypeTable;

    [XmlElement(ElementName = "virtualOnNetCallTypeTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable VirtualOnNetCallTypeTable {
        get => _virtualOnNetCallTypeTable;
        set {
            VirtualOnNetCallTypeTableSpecified = true;
            _virtualOnNetCallTypeTable = value;
        }
    }

    [XmlIgnore]
    public bool VirtualOnNetCallTypeTableSpecified { get; set; }
}
}
