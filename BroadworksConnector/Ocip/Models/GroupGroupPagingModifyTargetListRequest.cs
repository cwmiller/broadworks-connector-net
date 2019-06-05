using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGroupPagingModifyTargetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.ReplacementUserIdList _targetUserIdList;

    [XmlElement(ElementName = "targetUserIdList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList TargetUserIdList {
        get => _targetUserIdList;
        set {
            TargetUserIdListSpecified = true;
            _targetUserIdList = value;
        }
    }

    [XmlIgnore]
    public bool TargetUserIdListSpecified { get; set; }
}
}
