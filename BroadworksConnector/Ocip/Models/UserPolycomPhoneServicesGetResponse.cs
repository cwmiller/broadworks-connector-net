using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPolycomPhoneServicesGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
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

    [XmlElement(ElementName = "groupCustomContactDirectory", IsNullable = false, Namespace = "")]
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
