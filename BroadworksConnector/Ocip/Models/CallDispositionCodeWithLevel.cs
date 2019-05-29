using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallDispositionCodeWithLevel 
{
    [XmlElement(ElementName = "code", IsNullable = false)]
    public string Code { get; set; }
    [XmlElement(ElementName = "level", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallDispositionCodeLevel Level { get; set; }
 }
}
