using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingPinholeDigitPlanDigitPatternOriginatingPermissions 
{
    [XmlElement(ElementName = "digitPatternPermissions", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternOriginatingPermission> DigitPatternPermissions { get; set; }
 }
}
