using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAdviceOfChargeModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "useGroupLevelAoCSettings", IsNullable = false)]
    public bool UseGroupLevelAoCSettings { get; set; }
    [XmlElement(ElementName = "delayBetweenNotificationSeconds", IsNullable = false)]
    public int DelayBetweenNotificationSeconds { get; set; }
 }
}
