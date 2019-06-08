using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAutoAttendantSubmenuGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _submenuId;

    [XmlElement(ElementName = "submenuId", IsNullable = false, Namespace = "")]
    public string SubmenuId {
        get => _submenuId;
        set {
            SubmenuIdSpecified = true;
            _submenuId = value;
        }
    }

    [XmlIgnore]
    public bool SubmenuIdSpecified { get; set; }
}
}
