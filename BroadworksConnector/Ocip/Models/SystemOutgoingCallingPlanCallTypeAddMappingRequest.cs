using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOutgoingCallingPlanCallTypeAddMappingRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "countryCode", IsNullable = false)]
    public string CountryCode { get; set; }
    [XmlElement(ElementName = "digitMap", IsNullable = false)]
    public string DigitMap { get; set; }
    [XmlElement(ElementName = "callType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OutgoingCallingPlanCallType CallType { get; set; }
 }
}
