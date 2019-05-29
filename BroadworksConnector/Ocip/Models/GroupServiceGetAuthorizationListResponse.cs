using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupServiceGetAuthorizationListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "servicePacksAuthorizationTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ServicePacksAuthorizationTable { get; set; }
    [XmlElement(ElementName = "groupServicesAuthorizationTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable GroupServicesAuthorizationTable { get; set; }
    [XmlElement(ElementName = "userServicesAuthorizationTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable UserServicesAuthorizationTable { get; set; }
 }
}
