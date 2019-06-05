using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTreatmentMappingAccessSIPStatusModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private int _sipStatusCode;

    [XmlElement(ElementName = "sipStatusCode", IsNullable = false, Namespace = "")]
    public int SipStatusCode {
        get => _sipStatusCode;
        set {
            SipStatusCodeSpecified = true;
            _sipStatusCode = value;
        }
    }

    [XmlIgnore]
    public bool SipStatusCodeSpecified { get; set; }
    private string _treatmentId;

    [XmlElement(ElementName = "treatmentId", IsNullable = false, Namespace = "")]
    public string TreatmentId {
        get => _treatmentId;
        set {
            TreatmentIdSpecified = true;
            _treatmentId = value;
        }
    }

    [XmlIgnore]
    public bool TreatmentIdSpecified { get; set; }
}
}
