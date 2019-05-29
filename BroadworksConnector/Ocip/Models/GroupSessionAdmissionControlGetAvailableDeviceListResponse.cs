using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupSessionAdmissionControlGetAvailableDeviceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "accessDevice", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.AccessDevice> AccessDevice { get; set; }
 }
}
