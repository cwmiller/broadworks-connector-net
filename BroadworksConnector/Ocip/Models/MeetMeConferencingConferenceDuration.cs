using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MeetMeConferencingConferenceDuration 
{
    [XmlElement(ElementName = "hours", IsNullable = false)]
    public int Hours { get; set; }
    [XmlElement(ElementName = "minutes", IsNullable = false)]
    public int Minutes { get; set; }
 }
}
