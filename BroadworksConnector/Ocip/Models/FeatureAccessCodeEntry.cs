using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class FeatureAccessCodeEntry 
{
    [XmlElement(ElementName = "featureAccessCodeName", IsNullable = false)]
    public string FeatureAccessCodeName { get; set; }
    [XmlElement(ElementName = "mainCode", IsNullable = false)]
    public string MainCode { get; set; }
    [XmlElement(ElementName = "alternateCode", IsNullable = true)]
    public string AlternateCode { get; set; }
 }
}
