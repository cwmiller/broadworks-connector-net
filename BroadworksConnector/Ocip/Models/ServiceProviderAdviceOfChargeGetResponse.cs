using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAdviceOfChargeGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useSPLevelAoCSettings", IsNullable = false)]
    public bool UseSPLevelAoCSettings { get; set; }
    [XmlElement(ElementName = "delayBetweenNotificationSeconds", IsNullable = false)]
    public int DelayBetweenNotificationSeconds { get; set; }
 }
}
