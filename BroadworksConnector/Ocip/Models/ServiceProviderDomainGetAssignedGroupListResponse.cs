using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDomainGetAssignedGroupListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "groupTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable GroupTable { get; set; }
 }
}
