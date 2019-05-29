using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberPortabilityQueryDigitPatternModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "digitPattern", IsNullable = false)]
    public string DigitPattern { get; set; }
    [XmlElement(ElementName = "newDigitPattern", IsNullable = false)]
    public string NewDigitPattern { get; set; }
    [XmlElement(ElementName = "status", IsNullable = false)]
    public string Status { get; set; }
 }
}
