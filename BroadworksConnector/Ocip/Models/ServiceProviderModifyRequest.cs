using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "defaultDomain", IsNullable = false)]
    public string DefaultDomain { get; set; }
    [XmlElement(ElementName = "serviceProviderName", IsNullable = true)]
    public string ServiceProviderName { get; set; }
    [XmlElement(ElementName = "supportEmail", IsNullable = true)]
    public string SupportEmail { get; set; }
    [XmlElement(ElementName = "contact", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.Contact Contact { get; set; }
    [XmlElement(ElementName = "address", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.StreetAddress Address { get; set; }
    [XmlElement(ElementName = "useServiceProviderLanguages", IsNullable = false)]
    public bool UseServiceProviderLanguages { get; set; }
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
 }
}
