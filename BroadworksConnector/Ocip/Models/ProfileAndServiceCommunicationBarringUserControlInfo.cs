using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ProfileAndServiceCommunicationBarringUserControlInfo 
{
    private bool _lockoutStatus;

    [XmlElement(ElementName = "lockoutStatus", IsNullable = false, Namespace = "")]
    public bool LockoutStatus {
        get => _lockoutStatus;
        set {
            LockoutStatusSpecified = true;
            _lockoutStatus = value;
        }
    }

    [XmlIgnore]
    public bool LockoutStatusSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.C.OCITable _profileTable;

    [XmlElement(ElementName = "profileTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ProfileTable {
        get => _profileTable;
        set {
            ProfileTableSpecified = true;
            _profileTable = value;
        }
    }

    [XmlIgnore]
    public bool ProfileTableSpecified { get; set; }
}
}
