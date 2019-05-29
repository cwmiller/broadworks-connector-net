using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserServiceGetAssignmentListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "servicePacksAssignmentTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ServicePacksAssignmentTable { get; set; }
    [XmlElement(ElementName = "userServicesAssignmentTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable UserServicesAssignmentTable { get; set; }
 }
}
