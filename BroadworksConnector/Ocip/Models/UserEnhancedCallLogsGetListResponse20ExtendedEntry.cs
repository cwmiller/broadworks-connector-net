using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserEnhancedCallLogsGetListResponse20ExtendedEntry 
{
    [XmlElement(ElementName = "extendedCallLog", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ExtendedMixedCallLogsEntry20> ExtendedCallLog { get; set; }
 }
}
