using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserOCICallControlApplicationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private BroadWorksConnector.Ocip.Models.ReplacementOCICallControlApplicationIdList _applicationIdList;

    [XmlElement(ElementName = "applicationIdList", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ReplacementOCICallControlApplicationIdList ApplicationIdList {
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