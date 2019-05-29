using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoamingNetworkModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "mscAddress", IsNullable = false)]
    public string MscAddress { get; set; }
    [XmlElement(ElementName = "networkTranslationIndex", IsNullable = true)]
    public string NetworkTranslationIndex { get; set; }
 }
}
