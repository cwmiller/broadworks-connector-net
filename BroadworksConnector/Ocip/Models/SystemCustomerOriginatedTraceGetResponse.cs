using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCustomerOriginatedTraceGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "screenMaliciousCallers", IsNullable = false)]
    public bool ScreenMaliciousCallers { get; set; }
 }
}
