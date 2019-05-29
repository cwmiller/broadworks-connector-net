using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPushNotificationAllowedApplicationGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "applicationTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ApplicationTable { get; set; }
 }
}
