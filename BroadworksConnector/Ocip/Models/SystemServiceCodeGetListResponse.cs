using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServiceCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _serviceCodeTable;

    [XmlElement(ElementName = "serviceCodeTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ServiceCodeTable {
        get => _serviceCodeTable;
        set {
            ServiceCodeTableSpecified = true;
            _serviceCodeTable = value;
        }
    }

    [XmlIgnore]
    public bool ServiceCodeTableSpecified { get; set; }
}
}
