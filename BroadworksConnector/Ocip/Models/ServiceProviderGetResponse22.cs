using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderGetResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isEnterprise", IsNullable = false)]
    public bool IsEnterprise { get; set; }
    [XmlElement(ElementName = "useCustomRoutingProfile", IsNullable = false)]
    public bool UseCustomRoutingProfile { get; set; }
    [XmlElement(ElementName = "defaultDomain", IsNullable = false)]
    public string DefaultDomain { get; set; }
    [XmlElement(ElementName = "serviceProviderName", IsNullable = false)]
    public string ServiceProviderName { get; set; }
    [XmlElement(ElementName = "supportEmail", IsNullable = false)]
    public string SupportEmail { get; set; }
    [XmlElement(ElementName = "contact", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.Contact Contact { get; set; }
    [XmlElement(ElementName = "address", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.StreetAddress Address { get; set; }
    [XmlElement(ElementName = "useServiceProviderLanguages", IsNullable = false)]
    public bool UseServiceProviderLanguages { get; set; }
    [XmlElement(ElementName = "servicePolicy", IsNullable = false)]
    public string ServicePolicy { get; set; }
    [XmlElement(ElementName = "callProcessingSliceId", IsNullable = false)]
    public string CallProcessingSliceId { get; set; }
    [XmlElement(ElementName = "provisioningSliceId", IsNullable = false)]
    public string ProvisioningSliceId { get; set; }
    [XmlElement(ElementName = "subscriberPartition", IsNullable = false)]
    public string SubscriberPartition { get; set; }
    [XmlElement(ElementName = "preferredDataCenter", IsNullable = false)]
    public string PreferredDataCenter { get; set; }
 }
}
