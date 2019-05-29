using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class AutoAttendantKeyModifyConfiguration20 
{
    [XmlElement(ElementName = "key", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AutoAttendantMenuKey Key { get; set; }
    [XmlElement(ElementName = "entry", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AutoAttendantKeyConfigurationModifyEntry20 Entry { get; set; }
 }
}
