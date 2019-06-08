using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberPortabilityQueryStatusModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _statusName;

    [XmlElement(ElementName = "statusName", IsNullable = false, Namespace = "")]
    public string StatusName {
        get => _statusName;
        set {
            StatusNameSpecified = true;
            _statusName = value;
        }
    }

    [XmlIgnore]
    public bool StatusNameSpecified { get; set; }
    private string _newStatusName;

    [XmlElement(ElementName = "newStatusName", IsNullable = false, Namespace = "")]
    public string NewStatusName {
        get => _newStatusName;
        set {
            NewStatusNameSpecified = true;
            _newStatusName = value;
        }
    }

    [XmlIgnore]
    public bool NewStatusNameSpecified { get; set; }
    private string _treatmentFileName;

    [XmlElement(ElementName = "treatmentFileName", IsNullable = true, Namespace = "")]
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
