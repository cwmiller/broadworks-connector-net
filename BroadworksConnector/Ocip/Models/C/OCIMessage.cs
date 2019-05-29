using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models.C
{
[Serializable]
[XmlRoot(Namespace = "C")]
public  class OCIMessage 
{
    [XmlElement(ElementName = "sessionId", IsNullable = false, Namespace = "")]
    public string SessionId { get; set; }
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "phoneNumber", IsNullable = false)]
    public string PhoneNumber { get; set; }
    [XmlElement(ElementName = "linePort", IsNullable = false)]
    public string LinePort { get; set; }
    [XmlElement(ElementName = "command", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.C.OCICommand> Command { get; set; }
 }
}
