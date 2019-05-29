using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoamingNetworkAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "mscAddress", IsNullable = false)]
    public string MscAddress { get; set; }
    [XmlElement(ElementName = "networkTranslationIndex", IsNullable = false)]
    public string NetworkTranslationIndex { get; set; }
 }
}
