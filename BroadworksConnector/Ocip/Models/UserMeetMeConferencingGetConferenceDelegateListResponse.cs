using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingGetConferenceDelegateListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _conferenceDelegateUserTable;

    [XmlElement(ElementName = "conferenceDelegateUserTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ConferenceDelegateUserTable {
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
