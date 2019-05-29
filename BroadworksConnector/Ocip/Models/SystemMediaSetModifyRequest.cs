using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaSetModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "setName", IsNullable = false)]
    public string SetName { get; set; }
    [XmlElement(ElementName = "mediaNameList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ReplacementMediaNameList MediaNameList { get; set; }
 }
}
