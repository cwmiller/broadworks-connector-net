using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemInterceptUserGetDnListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadWorksConnector.Ocip.Models.InterceptDNListEntry> _interceptUserList;

    [XmlElement(ElementName = "interceptUserList", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.InterceptDNListEntry> InterceptUserList {
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
