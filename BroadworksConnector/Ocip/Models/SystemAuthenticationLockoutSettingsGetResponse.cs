using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAuthenticationLockoutSettingsGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "counterResetIntervalDays", IsNullable = false)]
    public int CounterResetIntervalDays { get; set; }
    [XmlElement(ElementName = "counterResetHour", IsNullable = false)]
    public int CounterResetHour { get; set; }
    [XmlElement(ElementName = "counterResetMinute", IsNullable = false)]
    public int CounterResetMinute { get; set; }
    [XmlElement(ElementName = "emergencySIPBypassAllowed", IsNullable = false)]
    public bool EmergencySIPBypassAllowed { get; set; }
 }
}
