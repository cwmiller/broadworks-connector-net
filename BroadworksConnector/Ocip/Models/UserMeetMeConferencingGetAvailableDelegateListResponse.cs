using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingGetAvailableDelegateListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _conferenceDelegateUserTable;

    [XmlElement(ElementName = "conferenceDelegateUserTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ConferenceDelegateUserTable {
        get => _conferenceDelegateUserTable;
        set {
            ConferenceDelegateUserTableSpecified = true;
            _conferenceDelegateUserTable = value;
        }
    }

    [XmlIgnore]
    public bool ConferenceDelegateUserTableSpecified { get; set; }
}
}
