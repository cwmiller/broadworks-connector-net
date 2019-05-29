using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingPinholeDigitPlanDigitPatternOriginatingPermission 
{
    [XmlElement(ElementName = "digitPatternName", IsNullable = false)]
    public string DigitPatternName { get; set; }
    [XmlElement(ElementName = "permission", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingPinholeDigitPlanOriginatingPermission Permission { get; set; }
 }
}
