using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupInstantGroupCallGetInstanceListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "instantGroupCallTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable InstantGroupCallTable { get; set; }
 }
}
