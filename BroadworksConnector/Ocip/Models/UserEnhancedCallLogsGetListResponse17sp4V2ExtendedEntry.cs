using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserEnhancedCallLogsGetListResponse17sp4V2ExtendedEntry 
{
    [XmlElement(ElementName = "extendedCallLog", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ExtendedMixedCallLogsEntry17sp4> ExtendedCallLog { get; set; }
 }
}
