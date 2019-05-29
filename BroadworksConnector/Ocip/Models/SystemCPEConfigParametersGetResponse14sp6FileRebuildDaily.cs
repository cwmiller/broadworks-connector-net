using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCPEConfigParametersGetResponse14sp6FileRebuildDaily 
{
    [XmlElement(ElementName = "startHour", IsNullable = false)]
    public int StartHour { get; set; }
    [XmlElement(ElementName = "startMinute", IsNullable = false)]
    public int StartMinute { get; set; }
 }
}
