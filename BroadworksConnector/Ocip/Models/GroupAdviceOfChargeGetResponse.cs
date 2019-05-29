using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAdviceOfChargeGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useGroupLevelAoCSettings", IsNullable = false)]
    public bool UseGroupLevelAoCSettings { get; set; }
    [XmlElement(ElementName = "delayBetweenNotificationSeconds", IsNullable = false)]
    public int DelayBetweenNotificationSeconds { get; set; }
 }
}
