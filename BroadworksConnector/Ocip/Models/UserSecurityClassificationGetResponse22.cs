using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSecurityClassificationGetResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "securityClassification", IsNullable = false)]
    public string SecurityClassification { get; set; }
    [XmlElement(ElementName = "customizedSecurityClassification", IsNullable = false)]
    public string CustomizedSecurityClassification { get; set; }
 }
}
