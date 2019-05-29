using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemThirdPartyIMPModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceNetAddress", IsNullable = true)]
    public string ServiceNetAddress { get; set; }
    [XmlElement(ElementName = "servicePort", IsNullable = true)]
    public int? ServicePort { get; set; }
    [XmlElement(ElementName = "boshURL", IsNullable = true)]
    public string BoshURL { get; set; }
 }
}
