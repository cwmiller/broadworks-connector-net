using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCommunicationBarringCallTypeModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "callType", IsNullable = false)]
    public string CallType { get; set; }
    [XmlElement(ElementName = "networkServerCallType", IsNullable = false)]
    public string NetworkServerCallType { get; set; }
 }
}
