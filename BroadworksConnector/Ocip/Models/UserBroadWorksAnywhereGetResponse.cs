using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksAnywhereGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
    private BroadworksConnector.Ocip.Models.C.OCITable _phoneNumberTable;

    [XmlElement(ElementName = "phoneNumberTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable PhoneNumberTable {
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
