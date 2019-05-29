using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAccessDeviceGetAvailableDetailListResponse14 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "availableAccessDevice", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.GroupAccessDeviceGetAvailableDetailListResponse14AvailableAccessDevice> AvailableAccessDevice { get; set; }
 }
}
