using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVirtualOnNetCallTypeGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "virtualOnNetCallTypeTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable VirtualOnNetCallTypeTable { get; set; }
 }
}
