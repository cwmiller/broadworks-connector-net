using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDepartmentModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _departmentName;

    [XmlElement(ElementName = "departmentName", IsNullable = false, Namespace = "")]
    public string DepartmentName {
        get => _departmentName;
        set {
            DepartmentNameSpecified = true;
            _departmentName = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentNameSpecified { get; set; }
    private string _newDepartmentName;

    [XmlElement(ElementName = "newDepartmentName", IsNullable = false, Namespace = "")]
    public string NewDepartmentName {
        get => _newDepartmentName;
        set {
            NewDepartmentNameSpecified = true;
            _newDepartmentName = value;
        }
    }

    [XmlIgnore]
    public bool NewDepartmentNameSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.DepartmentKey _newParentDepartmentKey;

    [XmlElement(ElementName = "newParentDepartmentKey", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DepartmentKey NewParentDepartmentKey {
        get => _newParentDepartmentKey;
        set {
            NewParentDepartmentKeySpecified = true;
            _newParentDepartmentKey = value;
        }
    }

    [XmlIgnore]
    public bool NewParentDepartmentKeySpecified { get; set; }
    private string _callingLineIdName;

    [XmlElement(ElementName = "callingLineIdName", IsNullable = true, Namespace = "")]
    public string CallingLineIdName {
        get => _callingLineIdName;
        set {
            CallingLineIdNameSpecified = true;
            _callingLineIdName = value;
        }
    }

    [XmlIgnore]
    public bool CallingLineIdNameSpecified { get; set; }
    private string _callingLineIdPhoneNumber;

    [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = true, Namespace = "")]
    public string CallingLineIdPhoneNumber {
        get => _callingLineIdPhoneNumber;
        set {
            CallingLineIdPhoneNumberSpecified = true;
            _callingLineIdPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool CallingLineIdPhoneNumberSpecified { get; set; }
}
}
