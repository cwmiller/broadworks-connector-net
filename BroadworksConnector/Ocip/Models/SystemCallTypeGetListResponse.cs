using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallTypeGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "callType", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SystemCallType> CallType { get; set; }
 }
}
