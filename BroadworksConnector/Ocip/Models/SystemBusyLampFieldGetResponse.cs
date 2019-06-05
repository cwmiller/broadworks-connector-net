using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBusyLampFieldGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _displayLocalUserIdentityLastNameFirst;

    [XmlElement(ElementName = "displayLocalUserIdentityLastNameFirst", IsNullable = false, Namespace = "")]
    public bool DisplayLocalUserIdentityLastNameFirst {
        get => _displayLocalUserIdentityLastNameFirst;
        set {
            DisplayLocalUserIdentityLastNameFirstSpecified = true;
            _displayLocalUserIdentityLastNameFirst = value;
        }
    }

    [XmlIgnore]
    public bool DisplayLocalUserIdentityLastNameFirstSpecified { get; set; }
}
}
