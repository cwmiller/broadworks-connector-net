using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberPortabilityQueryStatusModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "statusName", IsNullable = false)]
    public string StatusName { get; set; }
    [XmlElement(ElementName = "newStatusName", IsNullable = false)]
    public string NewStatusName { get; set; }
    [XmlElement(ElementName = "treatmentFileName", IsNullable = true)]
    public string TreatmentFileName { get; set; }
 }
}
