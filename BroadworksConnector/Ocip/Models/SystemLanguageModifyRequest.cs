using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemLanguageModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "language", IsNullable = false)]
    public string Language { get; set; }
    [XmlElement(ElementName = "becomeDefaultLanguage", IsNullable = false)]
    public bool BecomeDefaultLanguage { get; set; }
    [XmlElement(ElementName = "locale", IsNullable = false)]
    public string Locale { get; set; }
    [XmlElement(ElementName = "encoding", IsNullable = false)]
    public string Encoding { get; set; }
 }
}
