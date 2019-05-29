using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementAlternateUserIdEntryList 
{
    [XmlElement(ElementName = "alternateUserId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.AlternateUserIdEntry> AlternateUserId { get; set; }
 }
}
