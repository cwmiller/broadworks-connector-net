using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointModifyDNISParametersRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "displayDNISNumber", IsNullable = false)]
    public bool DisplayDNISNumber { get; set; }
    [XmlElement(ElementName = "displayDNISName", IsNullable = false)]
    public bool DisplayDNISName { get; set; }
 }
}
