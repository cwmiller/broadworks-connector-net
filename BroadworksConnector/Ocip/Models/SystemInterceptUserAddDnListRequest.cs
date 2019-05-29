using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemInterceptUserAddDnListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "interceptDNList", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.InterceptDNListEntry> InterceptDNList { get; set; }
 }
}
