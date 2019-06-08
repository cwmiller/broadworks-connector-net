using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksAnywhereGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _alertAllLocationsForClickToDialCalls;

    [XmlElement(ElementName = "alertAllLocationsForClickToDialCalls", IsNullable = false, Namespace = "")]
    public bool AlertAllLocationsForClickToDialCalls {
        get => _alertAllLocationsForClickToDialCalls;
        set {
            AlertAllLocationsForClickToDialCallsSpecified = true;
            _alertAllLocationsForClickToDialCalls = value;
        }
    }

    [XmlIgnore]
    public bool AlertAllLocationsForClickToDialCallsSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.C.OCITable _phoneNumberTable;

    [XmlElement(ElementName = "phoneNumberTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable PhoneNumberTable {
        get => _phoneNumberTable;
        set {
            PhoneNumberTableSpecified = true;
            _phoneNumberTable = value;
        }
    }

    [XmlIgnore]
    public bool PhoneNumberTableSpecified { get; set; }
}
}
