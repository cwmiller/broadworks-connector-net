using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBusyLampFieldGetResponse23 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "displayLocalUserIdentityLastNameFirst", IsNullable = false)]
    public bool DisplayLocalUserIdentityLastNameFirst { get; set; }
    [XmlElement(ElementName = "forceUseOfTCP", IsNullable = false)]
    public bool ForceUseOfTCP { get; set; }
    [XmlElement(ElementName = "enableRedundancy", IsNullable = false)]
    public bool EnableRedundancy { get; set; }
    [XmlElement(ElementName = "redundancyTaskDelayMilliseconds", IsNullable = false)]
    public int RedundancyTaskDelayMilliseconds { get; set; }
    [XmlElement(ElementName = "redundancyTaskIntervalMilliseconds", IsNullable = false)]
    public int RedundancyTaskIntervalMilliseconds { get; set; }
    [XmlElement(ElementName = "maxNumberOfSubscriptionsPerRedundancyTaskInterval", IsNullable = false)]
    public int MaxNumberOfSubscriptionsPerRedundancyTaskInterval { get; set; }
 }
}
