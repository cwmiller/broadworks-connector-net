using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingPinholeDigitPlanDigitPatternRedirectingDepartmentPermissionsModify 
{
    [XmlElement(ElementName = "departmentKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DepartmentKey DepartmentKey { get; set; }
    [XmlElement(ElementName = "digitPatternPermissions", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingPinholeDigitPlanDigitPatternRedirectingPermissions DigitPatternPermissions { get; set; }
 }
}
