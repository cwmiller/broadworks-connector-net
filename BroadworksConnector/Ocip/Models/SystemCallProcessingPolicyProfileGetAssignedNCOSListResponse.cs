using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallProcessingPolicyProfileGetAssignedNCOSListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "networkClassOfServiceTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable NetworkClassOfServiceTable { get; set; }
 }
}
