using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceProfileAuthenticationLockoutGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _lockoutTable;

    [XmlElement(ElementName = "lockoutTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable LockoutTable {
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
