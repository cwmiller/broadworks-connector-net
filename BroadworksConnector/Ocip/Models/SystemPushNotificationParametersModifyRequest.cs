using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPushNotificationParametersModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "enforceAllowedApplicationList", IsNullable = false)]
    public bool EnforceAllowedApplicationList { get; set; }
    [XmlElement(ElementName = "maximumRegistrationsPerUser", IsNullable = false)]
    public int MaximumRegistrationsPerUser { get; set; }
    [XmlElement(ElementName = "maximumRegistrationAgeDays", IsNullable = false)]
    public int MaximumRegistrationAgeDays { get; set; }
    [XmlElement(ElementName = "newCallTimeout", IsNullable = false)]
    public int NewCallTimeout { get; set; }
    [XmlElement(ElementName = "subscriptionEventsPerSecond", IsNullable = false)]
    public int SubscriptionEventsPerSecond { get; set; }
 }
}
