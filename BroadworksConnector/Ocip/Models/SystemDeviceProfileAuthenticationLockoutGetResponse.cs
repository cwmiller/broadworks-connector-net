using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceProfileAuthenticationLockoutGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _lockoutTable;

    [XmlElement(ElementName = "lockoutTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable LockoutTable {
        get => _lockoutTable;
        set {
            LockoutTableSpecified = true;
            _lockoutTable = value;
        }
    }

    [XmlIgnore]
    public bool LockoutTableSpecified { get; set; }
}
}
