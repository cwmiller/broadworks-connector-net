using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingPinholeDigitPlanDigitPatternRedirectingPermissions 
{
    [XmlElement(ElementName = "digitPatternPermissions", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternRedirectingPermission> DigitPatternPermissions { get; set; }
 }
}
