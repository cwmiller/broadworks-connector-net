using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDigitCollectionModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "accessCode", IsNullable = true)]
    public string AccessCode { get; set; }
    [XmlElement(ElementName = "publicDigitMap", IsNullable = true)]
    public string PublicDigitMap { get; set; }
    [XmlElement(ElementName = "privateDigitMap", IsNullable = true)]
    public string PrivateDigitMap { get; set; }
 }
}
