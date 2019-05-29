using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOCICallControlApplicationAddRequest17 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "applicationId", IsNullable = false)]
    public string ApplicationId { get; set; }
    [XmlElement(ElementName = "enableSystemWide", IsNullable = false)]
    public bool EnableSystemWide { get; set; }
    [XmlElement(ElementName = "notificationTimeoutSeconds", IsNullable = false)]
    public int NotificationTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "maxEventChannelsPerSet", IsNullable = false)]
    public int MaxEventChannelsPerSet { get; set; }
 }
}
