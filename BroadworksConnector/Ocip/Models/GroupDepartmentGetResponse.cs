using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDepartmentGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.DepartmentKey _parentDepartmentKey;

    [XmlElement(ElementName = "parentDepartmentKey", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.DepartmentKey ParentDepartmentKey {
        get => _parentDepartmentKey;
        set {
            ParentDepartmentKeySpecified = true;
            _parentDepartmentKey = value;
        }
    }

    [XmlIgnore]
    public bool ParentDepartmentKeySpecified { get; set; }
    private string _callingLineIdName;

    [XmlElement(ElementName = "callingLineIdName", IsNullable = false, Namespace = "")]
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

    [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = false, Namespace = "")]
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
