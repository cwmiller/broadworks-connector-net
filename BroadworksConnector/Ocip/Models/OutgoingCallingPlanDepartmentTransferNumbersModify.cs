using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingCallingPlanDepartmentTransferNumbersModify 
{
    private BroadWorksConnector.Ocip.Models.DepartmentKey _departmentKey;

    [XmlElement(ElementName = "departmentKey", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DepartmentKey DepartmentKey {
        get => _departmentKey;
        set {
            DepartmentKeySpecified = true;
            _departmentKey = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentKeySpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbersModify _transferNumbers;

    [XmlElement(ElementName = "transferNumbers", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbersModify TransferNumbers {
        get => _transferNumbers;
        set {
            TransferNumbersSpecified = true;
            _transferNumbers = value;
        }
    }

    [XmlIgnore]
    public bool TransferNumbersSpecified { get; set; }
}
}
