using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCountryCodeModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "countryCode", IsNullable = false)]
    public string CountryCode { get; set; }
    [XmlElement(ElementName = "ringPeriodMilliseconds", IsNullable = false)]
    public int RingPeriodMilliseconds { get; set; }
    [XmlElement(ElementName = "offHookWarningTimerSeconds", IsNullable = false)]
    public int OffHookWarningTimerSeconds { get; set; }
    [XmlElement(ElementName = "enableNationalPrefix", IsNullable = false)]
    public bool EnableNationalPrefix { get; set; }
    [XmlElement(ElementName = "nationalPrefix", IsNullable = true)]
    public string NationalPrefix { get; set; }
    [XmlElement(ElementName = "becomeDefaultCountryCode", IsNullable = false)]
    public bool BecomeDefaultCountryCode { get; set; }
    [XmlElement(ElementName = "maxCallWaitingTones", IsNullable = false)]
    public int MaxCallWaitingTones { get; set; }
    [XmlElement(ElementName = "timeBetweenCallWaitingTonesMilliseconds", IsNullable = false)]
    public int TimeBetweenCallWaitingTonesMilliseconds { get; set; }
    [XmlElement(ElementName = "disableNationalPrefixForOffNetCalls", IsNullable = false)]
    public bool DisableNationalPrefixForOffNetCalls { get; set; }
 }
}
