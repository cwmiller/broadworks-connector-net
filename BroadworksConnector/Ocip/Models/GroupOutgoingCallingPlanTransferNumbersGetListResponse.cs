using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupOutgoingCallingPlanTransferNumbersGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "groupNumbers", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbers GroupNumbers { get; set; }
    [XmlElement(ElementName = "departmentNumbers", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.OutgoingCallingPlanDepartmentTransferNumbers> DepartmentNumbers { get; set; }
 }
}
