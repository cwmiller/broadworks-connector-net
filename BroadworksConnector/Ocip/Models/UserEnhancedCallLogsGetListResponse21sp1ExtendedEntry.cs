using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserEnhancedCallLogsGetListResponse21sp1ExtendedEntry 
{
    [XmlElement(ElementName = "extendedCallLog", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ExtendedMixedCallLogsEntry21sp1> ExtendedCallLog { get; set; }
 }
}
