using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberPortabilityQueryStatusAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _status;

    [XmlElement(ElementName = "status", IsNullable = false, Namespace = "")]
    public string Status {
        get => _status;
        set {
            StatusSpecified = true;
            _status = value;
        }
    }

    [XmlIgnore]
    public bool StatusSpecified { get; set; }
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
