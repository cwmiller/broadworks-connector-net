using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFeatureAccessCodeGetResponse20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useFeatureAccessCodeLevel", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupFeatureAccessCodeLevel UseFeatureAccessCodeLevel { get; set; }
    [XmlElement(ElementName = "featureAccessCode", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.FeatureAccessCodeEntry> FeatureAccessCode { get; set; }
 }
}
