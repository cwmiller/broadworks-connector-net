using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDepartmentAdminGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.GroupDepartmentKey _departmentKey;

    [XmlElement(ElementName = "departmentKey", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupDepartmentKey DepartmentKey {
        get => _departmentKey;
        set {
            DepartmentKeySpecified = true;
            _departmentKey = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentKeySpecified { get; set; }
    private string _departmentFullPath;

    [XmlElement(ElementName = "departmentFullPath", IsNullable = false, Namespace = "")]
    public string DepartmentFullPath {
        get => _departmentFullPath;
        set {
            DepartmentFullPathSpecified = true;
            _departmentFullPath = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentFullPathSpecified { get; set; }
    private string _firstName;

    [XmlElement(ElementName = "firstName", IsNullable = false, Namespace = "")]
    public string FirstName {
        get => _firstName;
        set {
            FirstNameSpecified = true;
            _firstName = value;
        }
    }

    [XmlIgnore]
    public bool FirstNameSpecified { get; set; }
    private string _lastName;

    [XmlElement(ElementName = "lastName", IsNullable = false, Namespace = "")]
    public string LastName {
        get => _lastName;
        set {
            LastNameSpecified = true;
            _lastName = value;
        }
    }

    [XmlIgnore]
    public bool LastNameSpecified { get; set; }
    private string _language;

    [XmlElement(ElementName = "language", IsNullable = false, Namespace = "")]
    public string Language {
        get => _language;
        set {
            LanguageSpecified = true;
            _language = value;
        }
    }

    [XmlIgnore]
    public bool LanguageSpecified { get; set; }
}
}
