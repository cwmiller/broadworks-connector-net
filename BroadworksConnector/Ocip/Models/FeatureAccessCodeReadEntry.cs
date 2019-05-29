using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class FeatureAccessCodeReadEntry 
{
    [XmlElement(ElementName = "featureAccessCodeName", IsNullable = false)]
    public string FeatureAccessCodeName { get; set; }
    [XmlElement(ElementName = "mainCode", IsNullable = false)]
    public string MainCode { get; set; }
    [XmlElement(ElementName = "alternateCode", IsNullable = false)]
    public string AlternateCode { get; set; }
    [XmlElement(ElementName = "enableFAC", IsNullable = false)]
    public bool EnableFAC { get; set; }
 }
}
