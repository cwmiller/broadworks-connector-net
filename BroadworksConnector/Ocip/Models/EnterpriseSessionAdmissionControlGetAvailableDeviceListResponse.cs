using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseSessionAdmissionControlGetAvailableDeviceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "accessDevice", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.EnterpriseAccessDevice> AccessDevice { get; set; }
 }
}
