using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOCICallControlApplicationGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _appTable;

    [XmlElement(ElementName = "appTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable AppTable {
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
