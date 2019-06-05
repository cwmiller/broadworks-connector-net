using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOCICallControlApplicationGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _appTable;

    [XmlElement(ElementName = "appTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable AppTable {
        get => _appTable;
        set {
            AppTableSpecified = true;
            _appTable = value;
        }
    }

    [XmlIgnore]
    public bool AppTableSpecified { get; set; }
}
}
