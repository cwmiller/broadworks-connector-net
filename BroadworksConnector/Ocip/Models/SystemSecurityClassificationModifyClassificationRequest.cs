using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSecurityClassificationModifyClassificationRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "securityClassificationName", IsNullable = false)]
    public string SecurityClassificationName { get; set; }
    [XmlElement(ElementName = "newSecurityClassificationName", IsNullable = false)]
    public string NewSecurityClassificationName { get; set; }
    [XmlElement(ElementName = "audioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource AudioFile { get; set; }
 }
}
