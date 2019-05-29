using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderFeatureAccessCodeModifyListRequest21 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "featureAccessCode", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.FeatureAccessCodeModifyEntry> FeatureAccessCode { get; set; }
 }
}
