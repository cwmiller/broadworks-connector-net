using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserFeatureAccessCodeModifyEntry 
{
    [XmlElement(ElementName = "featureAccessCodeName", IsNullable = false)]
    public string FeatureAccessCodeName { get; set; }
    [XmlElement(ElementName = "enableFAC", IsNullable = false)]
    public bool EnableFAC { get; set; }
 }
}
