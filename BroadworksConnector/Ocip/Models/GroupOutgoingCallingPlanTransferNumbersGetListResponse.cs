using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupOutgoingCallingPlanTransferNumbersGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbers _groupNumbers;

    [XmlElement(ElementName = "groupNumbers", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbers GroupNumbers {
        get => _groupNumbers;
        set {
            GroupNumbersSpecified = true;
            _groupNumbers = value;
        }
    }

    [XmlIgnore]
    public bool GroupNumbersSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDepartmentTransferNumbers> _departmentNumbers;

    [XmlElement(ElementName = "departmentNumbers", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.OutgoingCallingPlanDepartmentTransferNumbers> DepartmentNumbers {
        get => _departmentNumbers;
        set {
            DepartmentNumbersSpecified = true;
            _departmentNumbers = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentNumbersSpecified { get; set; }
}
}
