using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class IncomingCallingPlanDigitPatternPermission 
{
    [XmlElement(ElementName = "digitPatternName", IsNullable = false)]
    public string DigitPatternName { get; set; }
    [XmlElement(ElementName = "allow", IsNullable = false)]
    public bool Allow { get; set; }
 }
}
