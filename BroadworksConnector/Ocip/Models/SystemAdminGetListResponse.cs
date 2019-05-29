using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAdminGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "systemAdminTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable SystemAdminTable { get; set; }
 }
}
