using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGroupPagingModifyOriginatorListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.ReplacementUserIdList _originatorUserIdList;

    [XmlElement(ElementName = "originatorUserIdList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList OriginatorUserIdList {
        get => _originatorUserIdList;
        set {
            OriginatorUserIdListSpecified = true;
            _originatorUserIdList = value;
        }
    }

    [XmlIgnore]
    public bool OriginatorUserIdListSpecified { get; set; }
}
}
