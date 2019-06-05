using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallParkAddInstanceRequest16sp2 : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _name;

    [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
    public string Name {
        get => _name;
        set {
            NameSpecified = true;
            _name = value;
        }
    }

    [XmlIgnore]
    public bool NameSpecified { get; set; }
    private List<string> _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public List<string> UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private string _recallAlternateUserId;

    [XmlElement(ElementName = "recallAlternateUserId", IsNullable = false, Namespace = "")]
    public string RecallAlternateUserId {
        get => _recallAlternateUserId;
        set {
            RecallAlternateUserIdSpecified = true;
            _recallAlternateUserId = value;
        }
    }

    [XmlIgnore]
    public bool RecallAlternateUserIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallParkRecallTo _recallTo;

    [XmlElement(ElementName = "recallTo", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallParkRecallTo RecallTo {
        get => _recallTo;
        set {
            RecallToSpecified = true;
            _recallTo = value;
        }
    }

    [XmlIgnore]
    public bool RecallToSpecified { get; set; }
}
}
