using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPreferredCarrierGetUserListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _usersUsingCarrierTable;

    [XmlElement(ElementName = "usersUsingCarrierTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable UsersUsingCarrierTable {
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
