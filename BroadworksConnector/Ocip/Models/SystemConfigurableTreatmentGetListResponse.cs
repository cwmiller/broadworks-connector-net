using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemConfigurableTreatmentGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _treatmentTable;

    [XmlElement(ElementName = "treatmentTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable TreatmentTable {
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
