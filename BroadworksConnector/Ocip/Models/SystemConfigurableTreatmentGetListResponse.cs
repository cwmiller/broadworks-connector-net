using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemConfigurableTreatmentGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _treatmentTable;

    [XmlElement(ElementName = "treatmentTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable TreatmentTable {
        get => _treatmentTable;
        set {
            TreatmentTableSpecified = true;
            _treatmentTable = value;
        }
    }

    [XmlIgnore]
    public bool TreatmentTableSpecified { get; set; }
}
}
