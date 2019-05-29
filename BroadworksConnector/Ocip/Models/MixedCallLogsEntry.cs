using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MixedCallLogsEntry 
{
    [XmlElement(ElementName = "callLogType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallLogsType CallLogType { get; set; }
    [XmlElement(ElementName = "countryCode", IsNullable = false)]
    public string CountryCode { get; set; }
    [XmlElement(ElementName = "callLogId", IsNullable = false)]
    public string CallLogId { get; set; }
    [XmlElement(ElementName = "phoneNumber", IsNullable = false)]
    public string PhoneNumber { get; set; }
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "time", IsNullable = false)]
    public string Time { get; set; }
 }
}
