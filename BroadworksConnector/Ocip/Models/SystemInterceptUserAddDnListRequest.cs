using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemInterceptUserAddDnListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private List<BroadWorksConnector.Ocip.Models.InterceptDNListEntry> _interceptDNList;

    [XmlElement(ElementName = "interceptDNList", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.InterceptDNListEntry> InterceptDNList {
        get => _interceptDNList;
        set {
            InterceptDNListSpecified = true;
            _interceptDNList = value;
        }
    }

    [XmlIgnore]
    public bool InterceptDNListSpecified { get; set; }
}
}
