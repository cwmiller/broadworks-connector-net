using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserOutgoingCallingPlanPinholeDigitPlanOriginatingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "useCustomSettings", IsNullable = false)]
    public bool UseCustomSettings { get; set; }
    [XmlElement(ElementName = "userPermissions", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternOriginatingPermissions UserPermissions { get; set; }
 }
}
