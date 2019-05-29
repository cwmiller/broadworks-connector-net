using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallTypeMappingEntry 
{
    [XmlElement(ElementName = "countryCode", IsNullable = false)]
    public string CountryCode { get; set; }
    [XmlElement(ElementName = "digitMap", IsNullable = false)]
    public string DigitMap { get; set; }
    [XmlElement(ElementName = "callType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SystemCallType CallType { get; set; }
 }
}
