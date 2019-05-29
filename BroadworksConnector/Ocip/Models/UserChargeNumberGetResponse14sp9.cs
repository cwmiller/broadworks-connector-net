using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserChargeNumberGetResponse14sp9 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "phoneNumber", IsNullable = false)]
    public string PhoneNumber { get; set; }
    [XmlElement(ElementName = "useChargeNumberForEnhancedTranslations", IsNullable = false)]
    public bool UseChargeNumberForEnhancedTranslations { get; set; }
    [XmlElement(ElementName = "sendChargeNumberToNetwork", IsNullable = false)]
    public bool SendChargeNumberToNetwork { get; set; }
 }
}
