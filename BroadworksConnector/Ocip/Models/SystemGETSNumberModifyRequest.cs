using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGETSNumberModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "number", IsNullable = false)]
    public string Number { get; set; }
    [XmlElement(ElementName = "type", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GETSNumberType Type { get; set; }
    [XmlElement(ElementName = "description", IsNullable = true)]
    public string Description { get; set; }
 }
}
