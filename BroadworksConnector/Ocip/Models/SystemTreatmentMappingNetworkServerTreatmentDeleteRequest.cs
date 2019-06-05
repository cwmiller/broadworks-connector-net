using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTreatmentMappingNetworkServerTreatmentDeleteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _nsTreatment;

    [XmlElement(ElementName = "nsTreatment", IsNullable = false, Namespace = "")]
    public string NsTreatment {
        get => _nsTreatment;
        set {
            NsTreatmentSpecified = true;
            _nsTreatment = value;
        }
    }

    [XmlIgnore]
    public bool NsTreatmentSpecified { get; set; }
}
}
