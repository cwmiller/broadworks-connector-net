using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCollaborateBridgeGetInstanceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "collaborateBridgeTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable CollaborateBridgeTable { get; set; }
 }
}
