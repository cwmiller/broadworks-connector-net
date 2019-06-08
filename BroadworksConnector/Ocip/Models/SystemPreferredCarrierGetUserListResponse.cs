using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPreferredCarrierGetUserListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _usersUsingCarrierTable;

    [XmlElement(ElementName = "usersUsingCarrierTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable UsersUsingCarrierTable {
        get => _usersUsingCarrierTable;
        set {
            UsersUsingCarrierTableSpecified = true;
            _usersUsingCarrierTable = value;
        }
    }

    [XmlIgnore]
    public bool UsersUsingCarrierTableSpecified { get; set; }
}
}
