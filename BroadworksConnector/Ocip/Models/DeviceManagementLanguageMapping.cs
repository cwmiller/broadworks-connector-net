using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class DeviceManagementLanguageMapping 
{
    [XmlElement(ElementName = "broadWorksLanguage", IsNullable = false)]
    public string BroadWorksLanguage { get; set; }
    [XmlElement(ElementName = "deviceLanguage", IsNullable = true)]
    public string DeviceLanguage { get; set; }
 }
}
