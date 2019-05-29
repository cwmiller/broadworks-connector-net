using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemApplicationControllerAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "subscriberId", IsNullable = false)]
    public string SubscriberId { get; set; }
    [XmlElement(ElementName = "channelSetId", IsNullable = false)]
    public string ChannelSetId { get; set; }
 }
}
