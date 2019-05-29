using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAdminGetPagedSortedListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceProviderAdminTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ServiceProviderAdminTable { get; set; }
 }
}
