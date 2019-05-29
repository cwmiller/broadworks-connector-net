using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDeviceTypeCustomTagGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceProviderDeviceTypeCustomTagsTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ServiceProviderDeviceTypeCustomTagsTable { get; set; }
 }
}
