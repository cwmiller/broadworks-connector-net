using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTreatmentMappingCallBlockingServiceAddRequest22V2 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "callBlockingService", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallBlockingService22V2 CallBlockingService { get; set; }
    [XmlElement(ElementName = "treatmentId", IsNullable = false)]
    public string TreatmentId { get; set; }
 }
}
