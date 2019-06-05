using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPolycomPhoneServicesModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.AccessDevice _accessDevice;

    [XmlElement(ElementName = "accessDevice", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AccessDevice AccessDevice {
        get => _accessDevice;
        set {
            AccessDeviceSpecified = true;
            _accessDevice = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceSpecified { get; set; }
    private bool _integratePhoneDirectoryWithBroadWorks;

    [XmlElement(ElementName = "integratePhoneDirectoryWithBroadWorks", IsNullable = false, Namespace = "")]
    public bool IntegratePhoneDirectoryWithBroadWorks {
        get => _integratePhoneDirectoryWithBroadWorks;
        set {
            IntegratePhoneDirectoryWithBroadWorksSpecified = true;
            _integratePhoneDirectoryWithBroadWorks = value;
        }
    }

    [XmlIgnore]
    public bool IntegratePhoneDirectoryWithBroadWorksSpecified { get; set; }
    private bool _includeUserPersonalPhoneListInDirectory;

    [XmlElement(ElementName = "includeUserPersonalPhoneListInDirectory", IsNullable = false, Namespace = "")]
    public bool IncludeUserPersonalPhoneListInDirectory {
        get => _includeUserPersonalPhoneListInDirectory;
        set {
            IncludeUserPersonalPhoneListInDirectorySpecified = true;
            _includeUserPersonalPhoneListInDirectory = value;
        }
    }

    [XmlIgnore]
    public bool IncludeUserPersonalPhoneListInDirectorySpecified { get; set; }
    private bool _includeGroupCustomContactDirectoryInDirectory;

    [XmlElement(ElementName = "includeGroupCustomContactDirectoryInDirectory", IsNullable = false, Namespace = "")]
    public bool IncludeGroupCustomContactDirectoryInDirectory {
        get => _includeGroupCustomContactDirectoryInDirectory;
        set {
            IncludeGroupCustomContactDirectoryInDirectorySpecified = true;
            _includeGroupCustomContactDirectoryInDirectory = value;
        }
    }

    [XmlIgnore]
    public bool IncludeGroupCustomContactDirectoryInDirectorySpecified { get; set; }
    private string _groupCustomContactDirectory;

    [XmlElement(ElementName = "groupCustomContactDirectory", IsNullable = true, Namespace = "")]
    public string GroupCustomContactDirectory {
        get => _groupCustomContactDirectory;
        set {
            GroupCustomContactDirectorySpecified = true;
            _groupCustomContactDirectory = value;
        }
    }

    [XmlIgnore]
    public bool GroupCustomContactDirectorySpecified { get; set; }
}
}
