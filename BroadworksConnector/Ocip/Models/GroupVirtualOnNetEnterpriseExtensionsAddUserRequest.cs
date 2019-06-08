using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupVirtualOnNetEnterpriseExtensionsAddUserRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadWorksConnector.Ocip.Models.VirtualOnNetUser> _virtualOnNetUser;

    [XmlElement(ElementName = "virtualOnNetUser", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.VirtualOnNetUser> VirtualOnNetUser {
        get => _virtualOnNetUser;
        set {
            VirtualOnNetUserSpecified = true;
            _virtualOnNetUser = value;
        }
    }

    [XmlIgnore]
    public bool VirtualOnNetUserSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.VirtualOnNetUserRange> _virtualOnNetUserRange;

    [XmlElement(ElementName = "virtualOnNetUserRange", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.VirtualOnNetUserRange> VirtualOnNetUserRange {
        get => _virtualOnNetUserRange;
        set {
            VirtualOnNetUserRangeSpecified = true;
            _virtualOnNetUserRange = value;
        }
    }

    [XmlIgnore]
    public bool VirtualOnNetUserRangeSpecified { get; set; }
}
}
