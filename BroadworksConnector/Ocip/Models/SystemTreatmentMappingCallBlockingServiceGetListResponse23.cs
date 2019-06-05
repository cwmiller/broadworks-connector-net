using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTreatmentMappingCallBlockingServiceGetListResponse23 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _treatmentMappingTable;

    [XmlElement(ElementName = "treatmentMappingTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable TreatmentMappingTable {
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
