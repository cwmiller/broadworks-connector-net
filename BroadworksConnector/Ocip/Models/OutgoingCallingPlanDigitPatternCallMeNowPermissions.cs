using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingCallingPlanDigitPatternCallMeNowPermissions 
{
    [XmlElement(ElementName = "digitPatternPermissions", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.OutgoingCallingPlanDigitPatternCallMeNowPermission> DigitPatternPermissions { get; set; }
 }
}
