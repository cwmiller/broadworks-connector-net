using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPhysicalLocationGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "alwaysAllowEmergencyCalls", IsNullable = false)]
    public bool AlwaysAllowEmergencyCalls { get; set; }
 }
}
