using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest22 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private int _userListSizeLimit;

    [XmlElement(ElementName = "userListSizeLimit", IsNullable = false, Namespace = "")]
    public int UserListSizeLimit {
        get => _userListSizeLimit;
        set {
            UserListSizeLimitSpecified = true;
            _userListSizeLimit = value;
        }
    }

    [XmlIgnore]
    public bool UserListSizeLimitSpecified { get; set; }
}
}
