using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingCallingPlanCallMeNowPermissionsModify 
{
    [XmlElement(ElementName = "group", IsNullable = false)]
    public bool Group { get; set; }
    [XmlElement(ElementName = "local", IsNullable = false)]
    public bool Local { get; set; }
    [XmlElement(ElementName = "tollFree", IsNullable = false)]
    public bool TollFree { get; set; }
    [XmlElement(ElementName = "toll", IsNullable = false)]
    public bool Toll { get; set; }
    [XmlElement(ElementName = "international", IsNullable = false)]
    public bool International { get; set; }
    [XmlElement(ElementName = "operatorAssisted", IsNullable = false)]
    public bool OperatorAssisted { get; set; }
    [XmlElement(ElementName = "chargeableDirectoryAssisted", IsNullable = false)]
    public bool ChargeableDirectoryAssisted { get; set; }
    [XmlElement(ElementName = "specialServicesI", IsNullable = false)]
    public bool SpecialServicesI { get; set; }
    [XmlElement(ElementName = "specialServicesII", IsNullable = false)]
    public bool SpecialServicesII { get; set; }
    [XmlElement(ElementName = "premiumServicesI", IsNullable = false)]
    public bool PremiumServicesI { get; set; }
    [XmlElement(ElementName = "premiumServicesII", IsNullable = false)]
    public bool PremiumServicesII { get; set; }
    [XmlElement(ElementName = "casual", IsNullable = false)]
    public bool Casual { get; set; }
    [XmlElement(ElementName = "urlDialing", IsNullable = false)]
    public bool UrlDialing { get; set; }
    [XmlElement(ElementName = "unknown", IsNullable = false)]
    public bool Unknown { get; set; }
 }
}
