using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTreatmentMappingCallBlockingServiceGetListResponse23 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _treatmentMappingTable;

    [XmlElement(ElementName = "treatmentMappingTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable TreatmentMappingTable {
        get => _treatmentMappingTable;
        set {
            TreatmentMappingTableSpecified = true;
            _treatmentMappingTable = value;
        }
    }

    [XmlIgnore]
    public bool TreatmentMappingTableSpecified { get; set; }
}
}
