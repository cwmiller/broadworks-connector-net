using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallBlockingServiceMapEntry 
{
    [XmlElement(ElementName = "callBlockingService", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallBlockingService23 CallBlockingService { get; set; }
    [XmlElement(ElementName = "treatmentId", IsNullable = false)]
    public string TreatmentId { get; set; }
 }
}
