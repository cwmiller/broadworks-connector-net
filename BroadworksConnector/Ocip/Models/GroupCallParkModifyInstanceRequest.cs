using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallParkModifyInstanceRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _newName;

    [XmlElement(ElementName = "newName", IsNullable = false, Namespace = "")]
    public string NewName {
        get => _newName;
        set {
            NewNameSpecified = true;
            _newName = value;
        }
    }

    [XmlIgnore]
    public bool NewNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ReplacementUserIdList _userIdList;

    [XmlElement(ElementName = "userIdList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList UserIdList {
        get => _userIdList;
        set {
            UserIdListSpecified = true;
            _userIdList = value;
        }
    }

    [XmlIgnore]
    public bool UserIdListSpecified { get; set; }
    private string _recallAlternateUserId;

    [XmlElement(ElementName = "recallAlternateUserId", IsNullable = true, Namespace = "")]
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
