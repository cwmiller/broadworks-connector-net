using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupServiceGetAuthorizationListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _servicePacksAuthorizationTable;

    [XmlElement(ElementName = "servicePacksAuthorizationTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ServicePacksAuthorizationTable {
        get => _servicePacksAuthorizationTable;
        set {
            ServicePacksAuthorizationTableSpecified = true;
            _servicePacksAuthorizationTable = value;
        }
    }

    [XmlIgnore]
    public bool ServicePacksAuthorizationTableSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _groupServicesAuthorizationTable;

    [XmlElement(ElementName = "groupServicesAuthorizationTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable GroupServicesAuthorizationTable {
        get => _groupServicesAuthorizationTable;
        set {
            GroupServicesAuthorizationTableSpecified = true;
            _groupServicesAuthorizationTable = value;
        }
    }

    [XmlIgnore]
    public bool GroupServicesAuthorizationTableSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _userServicesAuthorizationTable;

    [XmlElement(ElementName = "userServicesAuthorizationTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable UserServicesAuthorizationTable {
        get => _userServicesAuthorizationTable;
        set {
            UserServicesAuthorizationTableSpecified = true;
            _userServicesAuthorizationTable = value;
        }
    }

    [XmlIgnore]
    public bool UserServicesAuthorizationTableSpecified { get; set; }
}
}
