using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCapacityManagementGetInstanceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "callCapacityGroupTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable CallCapacityGroupTable { get; set; }
 }
}
