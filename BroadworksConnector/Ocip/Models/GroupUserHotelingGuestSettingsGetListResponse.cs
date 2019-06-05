using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupUserHotelingGuestSettingsGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _userHotelingGuestTable;

    [XmlElement(ElementName = "userHotelingGuestTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable UserHotelingGuestTable {
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
