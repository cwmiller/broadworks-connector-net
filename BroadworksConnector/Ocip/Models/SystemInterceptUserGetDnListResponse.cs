using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemInterceptUserGetDnListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadworksConnector.Ocip.Models.InterceptDNListEntry> _interceptUserList;

    [XmlElement(ElementName = "interceptUserList", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.InterceptDNListEntry> InterceptUserList {
        get => _interceptUserList;
        set {
            InterceptUserListSpecified = true;
            _interceptUserList = value;
        }
    }

    [XmlIgnore]
    public bool InterceptUserListSpecified { get; set; }
}
}
