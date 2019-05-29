using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAccessDeviceCustomTagGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "deviceCustomTagsTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable DeviceCustomTagsTable { get; set; }
 }
}
