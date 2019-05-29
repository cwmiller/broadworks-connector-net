using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterGetAvailableDNISListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "availableDNIS", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.DNISKey> AvailableDNIS { get; set; }
 }
}
