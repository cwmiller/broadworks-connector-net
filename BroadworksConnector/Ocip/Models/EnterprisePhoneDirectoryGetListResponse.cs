using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterprisePhoneDirectoryGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _directoryTable;

    [XmlElement(ElementName = "directoryTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable DirectoryTable {
        get => _directoryTable;
        set {
            DirectoryTableSpecified = true;
            _directoryTable = value;
        }
    }

    [XmlIgnore]
    public bool DirectoryTableSpecified { get; set; }
}
}
