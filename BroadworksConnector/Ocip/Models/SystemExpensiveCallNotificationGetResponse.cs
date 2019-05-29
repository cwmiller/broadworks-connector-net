using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemExpensiveCallNotificationGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enablePostAnnouncementDelayTimer", IsNullable = false)]
    public bool EnablePostAnnouncementDelayTimer { get; set; }
    [XmlElement(ElementName = "postAnnouncementDelaySeconds", IsNullable = false)]
    public int PostAnnouncementDelaySeconds { get; set; }
 }
}
