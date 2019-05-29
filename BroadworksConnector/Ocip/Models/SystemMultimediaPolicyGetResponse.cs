using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMultimediaPolicyGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "restrictNonAudioVideoMediaTypes", IsNullable = false)]
    public bool RestrictNonAudioVideoMediaTypes { get; set; }
 }
}
