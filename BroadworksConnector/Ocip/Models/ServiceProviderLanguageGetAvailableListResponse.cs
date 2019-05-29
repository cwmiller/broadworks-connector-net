using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderLanguageGetAvailableListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "defaultLanguage", IsNullable = false)]
    public string DefaultLanguage { get; set; }
    [XmlElement(ElementName = "languageTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable LanguageTable { get; set; }
 }
}
