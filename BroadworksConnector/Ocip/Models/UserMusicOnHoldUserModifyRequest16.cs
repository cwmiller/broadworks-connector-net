using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMusicOnHoldUserModifyRequest16 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "source", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldUserSourceModify16 Source { get; set; }
    [XmlElement(ElementName = "useAlternateSourceForInternalCalls", IsNullable = false)]
    public bool UseAlternateSourceForInternalCalls { get; set; }
    [XmlElement(ElementName = "internalSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldUserSourceModify16 InternalSource { get; set; }
 }
}
