using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemExpensiveCallTypeAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "alternateCallIndicator", IsNullable = false)]
    public string AlternateCallIndicator { get; set; }
    [XmlElement(ElementName = "treatmentAudioFile", IsNullable = false)]
    public string TreatmentAudioFile { get; set; }
 }
}
