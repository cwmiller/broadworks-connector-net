using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupSessionAdmissionControlGroupGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "sessionAdmissionControlGroupTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable SessionAdmissionControlGroupTable { get; set; }
 }
}
