using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupMWIDeliveryToMobileEndpointGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useSettingLevel", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MWIDeliveryToMobileEndpointGroupSettingLevel UseSettingLevel { get; set; }
    [XmlElement(ElementName = "templateActivationTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable TemplateActivationTable { get; set; }
 }
}
