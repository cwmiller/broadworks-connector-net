using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserGetServiceInstanceListInSystemResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceInstanceTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ServiceInstanceTable { get; set; }
 }
}
