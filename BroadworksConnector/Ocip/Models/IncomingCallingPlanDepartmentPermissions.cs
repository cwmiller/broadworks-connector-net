using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class IncomingCallingPlanDepartmentPermissions 
{
    [XmlElement(ElementName = "departmentKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DepartmentKey DepartmentKey { get; set; }
    [XmlElement(ElementName = "departmentFullPathName", IsNullable = false)]
    public string DepartmentFullPathName { get; set; }
    [XmlElement(ElementName = "allowFromWithinGroup", IsNullable = false)]
    public bool AllowFromWithinGroup { get; set; }
    [XmlElement(ElementName = "allowFromOutsideGroup", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.IncomingCallingPlanOutsideCallPermission AllowFromOutsideGroup { get; set; }
    [XmlElement(ElementName = "allowCollectCalls", IsNullable = false)]
    public bool AllowCollectCalls { get; set; }
    [XmlElement(ElementName = "digitPatternPermission", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.IncomingCallingPlanDigitPatternPermission> DigitPatternPermission { get; set; }
 }
}
