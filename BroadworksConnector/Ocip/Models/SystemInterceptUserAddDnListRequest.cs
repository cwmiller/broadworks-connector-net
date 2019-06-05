using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemInterceptUserAddDnListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private List<BroadworksConnector.Ocip.Models.InterceptDNListEntry> _interceptDNList;

    [XmlElement(ElementName = "interceptDNList", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.InterceptDNListEntry> InterceptDNList {
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
