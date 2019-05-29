using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTreatmentMappingCallBlockingServiceDeleteRequest23 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "callBlockingService", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallBlockingService23 CallBlockingService { get; set; }
 }
}
