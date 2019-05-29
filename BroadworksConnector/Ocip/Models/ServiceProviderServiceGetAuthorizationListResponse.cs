using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServiceGetAuthorizationListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "groupServicesAuthorizationTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable GroupServicesAuthorizationTable { get; set; }
    [XmlElement(ElementName = "userServicesAuthorizationTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable UserServicesAuthorizationTable { get; set; }
 }
}
