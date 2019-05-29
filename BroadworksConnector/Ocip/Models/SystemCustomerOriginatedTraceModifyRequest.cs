using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCustomerOriginatedTraceModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "screenMaliciousCallers", IsNullable = false)]
    public bool ScreenMaliciousCallers { get; set; }
 }
}
