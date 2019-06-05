using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserOCICallControlApplicationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.ReplacementOCICallControlApplicationIdList _applicationIdList;

    [XmlElement(ElementName = "applicationIdList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementOCICallControlApplicationIdList ApplicationIdList {
        get => _applicationIdList;
        set {
            ApplicationIdListSpecified = true;
            _applicationIdList = value;
        }
    }

    [XmlIgnore]
    public bool ApplicationIdListSpecified { get; set; }
}
}
