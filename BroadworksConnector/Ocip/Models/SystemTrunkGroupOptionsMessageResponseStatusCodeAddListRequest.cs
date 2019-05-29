using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTrunkGroupOptionsMessageResponseStatusCodeAddListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "statusCode", IsNullable = false)]
    public List<string> StatusCode { get; set; }
 }
}
