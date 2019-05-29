using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAlternateUserIdGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "userIdTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable UserIdTable { get; set; }
 }
}
