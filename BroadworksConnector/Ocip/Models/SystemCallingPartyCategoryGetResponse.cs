using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallingPartyCategoryGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "cpcValue", IsNullable = false)]
    public string CpcValue { get; set; }
    [XmlElement(ElementName = "isupOliValue", IsNullable = false)]
    public int IsupOliValue { get; set; }
    [XmlElement(ElementName = "gtdOliValue", IsNullable = false)]
    public string GtdOliValue { get; set; }
    [XmlElement(ElementName = "userCategory", IsNullable = false)]
    public bool UserCategory { get; set; }
    [XmlElement(ElementName = "payPhone", IsNullable = false)]
    public bool PayPhone { get; set; }
    [XmlElement(ElementName = "operator", IsNullable = false)]
    public bool Operator { get; set; }
    [XmlElement(ElementName = "default", IsNullable = false)]
    public bool Default { get; set; }
    [XmlElement(ElementName = "collectCall", IsNullable = false)]
    public bool CollectCall { get; set; }
    [XmlElement(ElementName = "webDisplayKey", IsNullable = false)]
    public string WebDisplayKey { get; set; }
 }
}
