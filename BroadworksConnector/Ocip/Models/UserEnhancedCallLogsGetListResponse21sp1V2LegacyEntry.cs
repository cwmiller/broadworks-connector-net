using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserEnhancedCallLogsGetListResponse21sp1V2LegacyEntry 
{
    [XmlElement(ElementName = "callLog", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.MixedCallLogsEntry> CallLog { get; set; }
 }
}
