using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserFeatureAccessCodeGetListResponse21 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "featureAccessCode", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.FeatureAccessCodeReadEntry> FeatureAccessCode { get; set; }
 }
}
