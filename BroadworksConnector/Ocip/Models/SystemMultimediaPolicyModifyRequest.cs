using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMultimediaPolicyModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "restrictNonAudioVideoMediaTypes", IsNullable = false)]
    public bool RestrictNonAudioVideoMediaTypes { get; set; }
 }
}
