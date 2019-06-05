using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServiceCodeGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _serviceCodeTable;

    [XmlElement(ElementName = "serviceCodeTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ServiceCodeTable {
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
