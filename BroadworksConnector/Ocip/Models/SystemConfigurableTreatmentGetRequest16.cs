using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemConfigurableTreatmentGetRequest16 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "treatmentId", IsNullable = false)]
    public string TreatmentId { get; set; }
 }
}
