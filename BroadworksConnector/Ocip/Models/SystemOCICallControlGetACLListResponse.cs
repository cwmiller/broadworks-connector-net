using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOCICallControlGetACLListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "aclTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AclTable { get; set; }
 }
}
