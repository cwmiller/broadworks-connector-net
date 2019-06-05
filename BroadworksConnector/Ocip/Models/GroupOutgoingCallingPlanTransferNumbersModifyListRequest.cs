using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupOutgoingCallingPlanTransferNumbersModifyListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private string _groupId;

    [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
    public string GroupId {
        get => _groupId;
        set {
            GroupIdSpecified = true;
            _groupId = value;
        }
    }

    [XmlIgnore]
    public bool GroupIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbersModify _groupNumbers;

    [XmlElement(ElementName = "groupNumbers", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbersModify GroupNumbers {
        get => _groupNumbers;
        set {
            GroupNumbersSpecified = true;
            _groupNumbers = value;
        }
    }

    [XmlIgnore]
    public bool GroupNumbersSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.OutgoingCallingPlanDepartmentTransferNumbersModify> _departmentNumbers;

    [XmlElement(ElementName = "departmentNumbers", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.OutgoingCallingPlanDepartmentTransferNumbersModify> DepartmentNumbers {
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
