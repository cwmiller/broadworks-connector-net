using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterAnnouncementDescriptionList 
{
    [XmlElement(ElementName = "fileDescription1", IsNullable = false)]
    public string FileDescription1 { get; set; }
    [XmlElement(ElementName = "fileDescription2", IsNullable = false)]
    public string FileDescription2 { get; set; }
    [XmlElement(ElementName = "fileDescription3", IsNullable = false)]
    public string FileDescription3 { get; set; }
    [XmlElement(ElementName = "fileDescription4", IsNullable = false)]
    public string FileDescription4 { get; set; }
 }
}
