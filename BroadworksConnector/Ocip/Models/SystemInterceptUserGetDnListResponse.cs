using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemInterceptUserGetDnListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "interceptUserList", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.InterceptDNListEntry> InterceptUserList { get; set; }
 }
}
