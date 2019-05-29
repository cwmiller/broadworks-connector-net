using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccessDeviceGetListResponse14 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "accessDeviceTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AccessDeviceTable { get; set; }
 }
}
