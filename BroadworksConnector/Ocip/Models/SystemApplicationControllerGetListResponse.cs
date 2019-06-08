using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemApplicationControllerGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _applicationControllerTable;

    [XmlElement(ElementName = "applicationControllerTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ApplicationControllerTable {
        get => _applicationControllerTable;
        set {
            ApplicationControllerTableSpecified = true;
            _applicationControllerTable = value;
        }
    }

    [XmlIgnore]
    public bool ApplicationControllerTableSpecified { get; set; }
}
}
