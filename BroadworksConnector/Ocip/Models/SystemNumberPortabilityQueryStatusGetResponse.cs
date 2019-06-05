using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberPortabilityQueryStatusGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _treatmentFileName;

    [XmlElement(ElementName = "treatmentFileName", IsNullable = false, Namespace = "")]
    public string TreatmentFileName {
        get => _treatmentFileName;
        set {
            TreatmentFileNameSpecified = true;
            _treatmentFileName = value;
        }
    }

    [XmlIgnore]
    public bool TreatmentFileNameSpecified { get; set; }
}
}
