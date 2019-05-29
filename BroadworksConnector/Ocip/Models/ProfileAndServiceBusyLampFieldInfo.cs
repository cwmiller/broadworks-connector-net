using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ProfileAndServiceBusyLampFieldInfo 
{
    [XmlElement(ElementName = "listURI", IsNullable = false)]
    public string ListURI { get; set; }
    [XmlElement(ElementName = "enableCallParkNotification", IsNullable = false)]
    public bool EnableCallParkNotification { get; set; }
    [XmlElement(ElementName = "monitoredUserTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable MonitoredUserTable { get; set; }
 }
}
