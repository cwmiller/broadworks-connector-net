using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDigitCollectionModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "useSetting", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupDigitCollectionSettingLevel UseSetting { get; set; }
    [XmlElement(ElementName = "accessCode", IsNullable = true)]
    public string AccessCode { get; set; }
    [XmlElement(ElementName = "publicDigitMap", IsNullable = true)]
    public string PublicDigitMap { get; set; }
    [XmlElement(ElementName = "privateDigitMap", IsNullable = true)]
    public string PrivateDigitMap { get; set; }
 }
}
