using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAutomaticCollectCallPrefixDigitsAddListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "prefixDigitsEntry", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.AutomaticCollectCallPrefixDigitsEntry> PrefixDigitsEntry { get; set; }
 }
}
