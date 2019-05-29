using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupMWIDeliveryToMobileEndpointCustomTemplateModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "language", IsNullable = false)]
    public string Language { get; set; }
    [XmlElement(ElementName = "type", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateType Type { get; set; }
    [XmlElement(ElementName = "isEnabled", IsNullable = false)]
    public bool IsEnabled { get; set; }
    [XmlElement(ElementName = "templateBody", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateBody TemplateBody { get; set; }
 }
}
