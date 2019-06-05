using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemApplicationControllerGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _applicationControllerTable;

    [XmlElement(ElementName = "applicationControllerTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ApplicationControllerTable {
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
