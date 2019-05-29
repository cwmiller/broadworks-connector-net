using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerAdminGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "resellerAdminTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ResellerAdminTable { get; set; }
 }
}
