using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _mobileSubscriberDirectoryNumber;

    [XmlElement(ElementName = "mobileSubscriberDirectoryNumber", IsNullable = false, Namespace = "")]
    public List<string> MobileSubscriberDirectoryNumber {
        get => _mobileSubscriberDirectoryNumber;
        set {
            MobileSubscriberDirectoryNumberSpecified = true;
            _mobileSubscriberDirectoryNumber = value;
        }
    }

    [XmlIgnore]
    public bool MobileSubscriberDirectoryNumberSpecified { get; set; }
}
}
