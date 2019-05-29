using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "defaultDomain", IsNullable = false)]
    public string DefaultDomain { get; set; }
    [XmlElement(ElementName = "userLimit", IsNullable = false)]
    public int UserLimit { get; set; }
    [XmlElement(ElementName = "groupName", IsNullable = true)]
    public string GroupName { get; set; }
    [XmlElement(ElementName = "callingLineIdName", IsNullable = true)]
    public string CallingLineIdName { get; set; }
    [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = true)]
    public string CallingLineIdPhoneNumber { get; set; }
    [XmlElement(ElementName = "timeZone", IsNullable = false)]
    public string TimeZone { get; set; }
    [XmlElement(ElementName = "locationDialingCode", IsNullable = true)]
    public string LocationDialingCode { get; set; }
    [XmlElement(ElementName = "contact", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.Contact Contact { get; set; }
    [XmlElement(ElementName = "address", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.StreetAddress Address { get; set; }
    [XmlElement(ElementName = "servicePolicy", IsNullable = true)]
    public string ServicePolicy { get; set; }
    [XmlElement(ElementName = "callProcessingSliceId", IsNullable = true)]
    public string CallProcessingSliceId { get; set; }
    [XmlElement(ElementName = "provisioningSliceId", IsNullable = true)]
    public string ProvisioningSliceId { get; set; }
    [XmlElement(ElementName = "subscriberPartition", IsNullable = true)]
    public string SubscriberPartition { get; set; }
    [XmlElement(ElementName = "preferredDataCenter", IsNullable = true)]
    public string PreferredDataCenter { get; set; }
    [XmlElement(ElementName = "defaultUserCallingLineIdPhoneNumber", IsNullable = true)]
    public string DefaultUserCallingLineIdPhoneNumber { get; set; }
 }
}
