using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGroupPagingAddInstanceRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceAddProfile ServiceInstanceProfile { get; set; }
    [XmlElement(ElementName = "confirmationToneTimeoutSeconds", IsNullable = false)]
    public int ConfirmationToneTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "deliverOriginatorCLIDInstead", IsNullable = false)]
    public bool DeliverOriginatorCLIDInstead { get; set; }
    [XmlElement(ElementName = "originatorCLIDPrefix", IsNullable = false)]
    public string OriginatorCLIDPrefix { get; set; }
    [XmlElement(ElementName = "networkClassOfService", IsNullable = false)]
    public string NetworkClassOfService { get; set; }
 }
}
