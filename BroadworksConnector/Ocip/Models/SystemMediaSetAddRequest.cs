using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaSetAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "setName", IsNullable = false)]
    public string SetName { get; set; }
    [XmlElement(ElementName = "mediaName", IsNullable = false)]
    public List<string> MediaName { get; set; }
 }
}
