using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class AutoAttendantKeyConfiguration20 
{
    [XmlElement(ElementName = "key", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AutoAttendantMenuKey Key { get; set; }
    [XmlElement(ElementName = "entry", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AutoAttendantKeyConfigurationEntry20 Entry { get; set; }
 }
}
