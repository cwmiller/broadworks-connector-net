using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAccountAuthorizationCodesGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "type", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccountAuthorizationCodeType Type { get; set; }
    [XmlElement(ElementName = "numberOfDigits", IsNullable = false)]
    public int NumberOfDigits { get; set; }
    [XmlElement(ElementName = "allowLocalAndTollFreeCalls", IsNullable = false)]
    public bool AllowLocalAndTollFreeCalls { get; set; }
    [XmlElement(ElementName = "mandatoryUsageUserTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable MandatoryUsageUserTable { get; set; }
    [XmlElement(ElementName = "optionalUsageUserTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable OptionalUsageUserTable { get; set; }
 }
}
