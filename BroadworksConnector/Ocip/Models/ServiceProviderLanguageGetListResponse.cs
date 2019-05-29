using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderLanguageGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "language", IsNullable = false)]
    public List<string> Language { get; set; }
    [XmlElement(ElementName = "defaultLanguage", IsNullable = false)]
    public string DefaultLanguage { get; set; }
 }
}
