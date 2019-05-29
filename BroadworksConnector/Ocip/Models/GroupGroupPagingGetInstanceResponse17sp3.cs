using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGroupPagingGetInstanceResponse17sp3 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceReadProfile17 ServiceInstanceProfile { get; set; }
    [XmlElement(ElementName = "confirmationToneTimeoutSeconds", IsNullable = false)]
    public int ConfirmationToneTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "deliverOriginatorCLIDInstead", IsNullable = false)]
    public bool DeliverOriginatorCLIDInstead { get; set; }
    [XmlElement(ElementName = "originatorCLIDPrefix", IsNullable = false)]
    public string OriginatorCLIDPrefix { get; set; }
 }
}
