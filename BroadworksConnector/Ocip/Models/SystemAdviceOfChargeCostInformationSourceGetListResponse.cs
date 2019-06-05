using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAdviceOfChargeCostInformationSourceGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _costInformationSourceTable;

    [XmlElement(ElementName = "costInformationSourceTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable CostInformationSourceTable {
        get => _costInformationSourceTable;
        set {
            CostInformationSourceTableSpecified = true;
            _costInformationSourceTable = value;
        }
    }

    [XmlIgnore]
    public bool CostInformationSourceTableSpecified { get; set; }
}
}
