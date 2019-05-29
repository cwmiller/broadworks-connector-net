using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterAnnouncementURLList 
{
    [XmlElement(ElementName = "url1", IsNullable = false)]
    public string Url1 { get; set; }
    [XmlElement(ElementName = "url2", IsNullable = false)]
    public string Url2 { get; set; }
    [XmlElement(ElementName = "url3", IsNullable = false)]
    public string Url3 { get; set; }
    [XmlElement(ElementName = "url4", IsNullable = false)]
    public string Url4 { get; set; }
 }
}
