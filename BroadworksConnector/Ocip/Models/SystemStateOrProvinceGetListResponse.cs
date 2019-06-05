using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemStateOrProvinceGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _stateOrProvinceTable;

    [XmlElement(ElementName = "stateOrProvinceTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable StateOrProvinceTable {
        get => _stateOrProvinceTable;
        set {
            StateOrProvinceTableSpecified = true;
            _stateOrProvinceTable = value;
        }
    }

    [XmlIgnore]
    public bool StateOrProvinceTableSpecified { get; set; }
}
}
