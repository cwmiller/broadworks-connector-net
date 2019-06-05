using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSeriesCompletionGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _name;

    [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
    public string Name {
        get => _name;
        set {
            NameSpecified = true;
            _name = value;
        }
    }

    [XmlIgnore]
    public bool NameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _userTable;

    [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable UserTable {
        get => _userTable;
        set {
            UserTableSpecified = true;
            _userTable = value;
        }
    }

    [XmlIgnore]
    public bool UserTableSpecified { get; set; }
}
}
