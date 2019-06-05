using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGroupPagingDeleteTargetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
    private List<string> _targetUserId;

    [XmlElement(ElementName = "targetUserId", IsNullable = false, Namespace = "")]
    public List<string> TargetUserId {
        get => _targetUserId;
        set {
            TargetUserIdSpecified = true;
            _targetUserId = value;
        }
    }

    [XmlIgnore]
    public bool TargetUserIdSpecified { get; set; }
}
}
