using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaGroupCodecModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "name", IsNullable = false)]
    public string Name { get; set; }
    [XmlElement(ElementName = "codecName", IsNullable = false)]
    public string CodecName { get; set; }
    [XmlElement(ElementName = "codecWeight", IsNullable = false)]
    public int CodecWeight { get; set; }
 }
}
