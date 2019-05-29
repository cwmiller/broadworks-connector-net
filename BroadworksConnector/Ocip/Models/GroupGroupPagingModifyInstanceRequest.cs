using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGroupPagingModifyInstanceRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceModifyProfile ServiceInstanceProfile { get; set; }
    [XmlElement(ElementName = "confirmationToneTimeoutSeconds", IsNullable = false)]
    public int ConfirmationToneTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "deliverOriginatorCLIDInstead", IsNullable = false)]
    public bool DeliverOriginatorCLIDInstead { get; set; }
    [XmlElement(ElementName = "originatorCLIDPrefix", IsNullable = true)]
    public string OriginatorCLIDPrefix { get; set; }
    [XmlElement(ElementName = "networkClassOfService", IsNullable = false)]
    public string NetworkClassOfService { get; set; }
 }
}
