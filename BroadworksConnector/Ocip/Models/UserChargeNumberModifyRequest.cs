using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserChargeNumberModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "phoneNumber", IsNullable = true)]
    public string PhoneNumber { get; set; }
    [XmlElement(ElementName = "useChargeNumberForEnhancedTranslations", IsNullable = false)]
    public bool UseChargeNumberForEnhancedTranslations { get; set; }
    [XmlElement(ElementName = "sendChargeNumberToNetwork", IsNullable = false)]
    public bool SendChargeNumberToNetwork { get; set; }
 }
}
