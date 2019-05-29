using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBusyLampFieldGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "listURI", IsNullable = false)]
    public string ListURI { get; set; }
    [XmlElement(ElementName = "monitoredUserTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable MonitoredUserTable { get; set; }
 }
}
