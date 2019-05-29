using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemThirdPartyIMPGetResponse19 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceNetAddress", IsNullable = false)]
    public string ServiceNetAddress { get; set; }
    [XmlElement(ElementName = "servicePort", IsNullable = false)]
    public int ServicePort { get; set; }
    [XmlElement(ElementName = "boshURL", IsNullable = false)]
    public string BoshURL { get; set; }
 }
}
