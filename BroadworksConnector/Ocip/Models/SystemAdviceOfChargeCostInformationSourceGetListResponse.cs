using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAdviceOfChargeCostInformationSourceGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _costInformationSourceTable;

    [XmlElement(ElementName = "costInformationSourceTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable CostInformationSourceTable {
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
