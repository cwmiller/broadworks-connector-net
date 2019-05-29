using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupIntegratedIMPGetResponse21sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useServiceProviderSetting", IsNullable = false)]
    public bool UseServiceProviderSetting { get; set; }
    [XmlElement(ElementName = "serviceDomain", IsNullable = false)]
    public string ServiceDomain { get; set; }
    [XmlElement(ElementName = "effectiveServiceDomain", IsNullable = false)]
    public string EffectiveServiceDomain { get; set; }
    [XmlElement(ElementName = "addServiceProviderInIMPUserId", IsNullable = false)]
    public bool AddServiceProviderInIMPUserId { get; set; }
    [XmlElement(ElementName = "defaultImpIdType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.IntegratedIMPUserIDType DefaultImpIdType { get; set; }
 }
}
