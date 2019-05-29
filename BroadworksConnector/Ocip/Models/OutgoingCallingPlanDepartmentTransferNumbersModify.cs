using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingCallingPlanDepartmentTransferNumbersModify 
{
    [XmlElement(ElementName = "departmentKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DepartmentKey DepartmentKey { get; set; }
    [XmlElement(ElementName = "transferNumbers", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbersModify TransferNumbers { get; set; }
 }
}
