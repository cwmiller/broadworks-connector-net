using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterAgentUnavailableCodeGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "unavailableCodesTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable UnavailableCodesTable { get; set; }
 }
}
