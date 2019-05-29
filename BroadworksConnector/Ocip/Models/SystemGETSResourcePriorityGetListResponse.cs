using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGETSResourcePriorityGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "resourcePriorityTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ResourcePriorityTable { get; set; }
 }
}
