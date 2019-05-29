using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupIntegratedIMPGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useServiceProviderSetting", IsNullable = false)]
    public bool UseServiceProviderSetting { get; set; }
    [XmlElement(ElementName = "serviceDomain", IsNullable = false)]
    public string ServiceDomain { get; set; }
 }
}
