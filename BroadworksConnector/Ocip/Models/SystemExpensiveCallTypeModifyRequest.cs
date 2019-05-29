using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemExpensiveCallTypeModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "alternateCallIndicator", IsNullable = false)]
    public string AlternateCallIndicator { get; set; }
    [XmlElement(ElementName = "treatmentAudioFile", IsNullable = true)]
    public string TreatmentAudioFile { get; set; }
 }
}
