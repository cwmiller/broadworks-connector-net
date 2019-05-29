using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementOCICallControlApplicationIdList 
{
    [XmlElement(ElementName = "applicationId", IsNullable = false)]
    public List<string> ApplicationId { get; set; }
 }
}
