using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallNotifyModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "defaultFromAddress", IsNullable = false)]
    public string DefaultFromAddress { get; set; }
    [XmlElement(ElementName = "useShortSubjectLine", IsNullable = false)]
    public bool UseShortSubjectLine { get; set; }
    [XmlElement(ElementName = "useDnInMailBody", IsNullable = false)]
    public bool UseDnInMailBody { get; set; }
 }
}
