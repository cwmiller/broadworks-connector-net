using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberPortabilityQueryStatusAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "status", IsNullable = false)]
    public string Status { get; set; }
    [XmlElement(ElementName = "treatmentFileName", IsNullable = false)]
    public string TreatmentFileName { get; set; }
 }
}
