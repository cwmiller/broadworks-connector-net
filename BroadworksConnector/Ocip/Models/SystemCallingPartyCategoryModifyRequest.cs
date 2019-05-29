using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallingPartyCategoryModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "category", IsNullable = false)]
    public string Category { get; set; }
    [XmlElement(ElementName = "cpcValue", IsNullable = true)]
    public string CpcValue { get; set; }
    [XmlElement(ElementName = "isupOliValue", IsNullable = true)]
    public int? IsupOliValue { get; set; }
    [XmlElement(ElementName = "gtdOliValue", IsNullable = true)]
    public string GtdOliValue { get; set; }
    [XmlElement(ElementName = "userCategory", IsNullable = false)]
    public bool UserCategory { get; set; }
    [XmlElement(ElementName = "payPhone", IsNullable = false)]
    public bool PayPhone { get; set; }
    [XmlElement(ElementName = "operator", IsNullable = false)]
    public bool Operator { get; set; }
    [XmlElement(ElementName = "becomeDefault", IsNullable = false)]
    public bool BecomeDefault { get; set; }
    [XmlElement(ElementName = "collectCall", IsNullable = false)]
    public bool CollectCall { get; set; }
    [XmlElement(ElementName = "webDisplayKey", IsNullable = true)]
    public string WebDisplayKey { get; set; }
 }
}
