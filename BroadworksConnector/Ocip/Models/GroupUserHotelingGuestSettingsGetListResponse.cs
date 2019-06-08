using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupUserHotelingGuestSettingsGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _userHotelingGuestTable;

    [XmlElement(ElementName = "userHotelingGuestTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable UserHotelingGuestTable {
        get => _userHotelingGuestTable;
        set {
            UserHotelingGuestTableSpecified = true;
            _userHotelingGuestTable = value;
        }
    }

    [XmlIgnore]
    public bool UserHotelingGuestTableSpecified { get; set; }
}
}
