using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoutingModifyTranslationRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "digits", IsNullable = false)]
    public string Digits { get; set; }
    [XmlElement(ElementName = "routeName", IsNullable = false)]
    public string RouteName { get; set; }
 }
}
