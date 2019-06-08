using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupPolycomPhoneServicesModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private bool _includeGroupCommonPhoneListInDirectory;

    [XmlElement(ElementName = "includeGroupCommonPhoneListInDirectory", IsNullable = false, Namespace = "")]
    public bool IncludeGroupCommonPhoneListInDirectory {
        get => _includeGroupCommonPhoneListInDirectory;
        set {
            IncludeGroupCommonPhoneListInDirectorySpecified = true;
            _includeGroupCommonPhoneListInDirectory = value;
        }
    }

    [XmlIgnore]
    public bool IncludeGroupCommonPhoneListInDirectorySpecified { get; set; }
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
