using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAccountAuthorizationCodesModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "codeType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccountAuthorizationCodeType CodeType { get; set; }
    [XmlElement(ElementName = "numberOfDigits", IsNullable = false)]
    public int NumberOfDigits { get; set; }
    [XmlElement(ElementName = "allowLocalAndTollFreeCalls", IsNullable = false)]
    public bool AllowLocalAndTollFreeCalls { get; set; }
    [XmlElement(ElementName = "mandatoryUsageUserIdList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList MandatoryUsageUserIdList { get; set; }
    [XmlElement(ElementName = "optionalUsageUserIdList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList OptionalUsageUserIdList { get; set; }
 }
}
