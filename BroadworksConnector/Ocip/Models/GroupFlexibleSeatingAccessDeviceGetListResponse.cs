using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFlexibleSeatingAccessDeviceGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "availableAccessDevice", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.GroupFlexibleSeatingAccessDeviceGetListResponseAvailableAccessDevice> AvailableAccessDevice { get; set; }
 }
}
