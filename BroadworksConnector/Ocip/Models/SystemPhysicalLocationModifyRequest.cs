using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPhysicalLocationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "alwaysAllowEmergencyCalls", IsNullable = false)]
    public bool AlwaysAllowEmergencyCalls { get; set; }
 }
}
