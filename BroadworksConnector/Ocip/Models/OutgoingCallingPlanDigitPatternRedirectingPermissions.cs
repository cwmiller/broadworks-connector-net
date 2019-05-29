using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingCallingPlanDigitPatternRedirectingPermissions 
{
    [XmlElement(ElementName = "digitPatternPermissions", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternRedirectingPermission> DigitPatternPermissions { get; set; }
 }
}
