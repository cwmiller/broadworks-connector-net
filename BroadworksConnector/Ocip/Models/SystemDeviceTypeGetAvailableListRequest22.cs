using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceTypeGetAvailableListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private bool _allowConference;

    [XmlElement(ElementName = "allowConference", IsNullable = false, Namespace = "")]
    public bool AllowConference {
        get => _allowConference;
        set {
            AllowConferenceSpecified = true;
            _allowConference = value;
        }
    }

    [XmlIgnore]
    public bool AllowConferenceSpecified { get; set; }
    private bool _allowMusicOnHold;

    [XmlElement(ElementName = "allowMusicOnHold", IsNullable = false, Namespace = "")]
    public bool AllowMusicOnHold {
        get => _allowMusicOnHold;
        set {
            AllowMusicOnHoldSpecified = true;
            _allowMusicOnHold = value;
        }
    }

    [XmlIgnore]
    public bool AllowMusicOnHoldSpecified { get; set; }
    private bool _onlyConference;

    [XmlElement(ElementName = "onlyConference", IsNullable = false, Namespace = "")]
    public bool OnlyConference {
        get => _onlyConference;
        set {
            OnlyConferenceSpecified = true;
            _onlyConference = value;
        }
    }

    [XmlIgnore]
    public bool OnlyConferenceSpecified { get; set; }
    private bool _onlyVideoCapable;

    [XmlElement(ElementName = "onlyVideoCapable", IsNullable = false, Namespace = "")]
    public bool OnlyVideoCapable {
        get => _onlyVideoCapable;
        set {
            OnlyVideoCapableSpecified = true;
            _onlyVideoCapable = value;
        }
    }

    [XmlIgnore]
    public bool OnlyVideoCapableSpecified { get; set; }
    private bool _onlyOptionalIpAddress;

    [XmlElement(ElementName = "onlyOptionalIpAddress", IsNullable = false, Namespace = "")]
    public bool OnlyOptionalIpAddress {
        get => _onlyOptionalIpAddress;
        set {
            OnlyOptionalIpAddressSpecified = true;
            _onlyOptionalIpAddress = value;
        }
    }

    [XmlIgnore]
    public bool OnlyOptionalIpAddressSpecified { get; set; }
    private bool _excludeReseller;

    [XmlElement(ElementName = "excludeReseller", IsNullable = false, Namespace = "")]
    public bool ExcludeReseller {
        get => _excludeReseller;
        set {
            ExcludeResellerSpecified = true;
            _excludeReseller = value;
        }
    }

    [XmlIgnore]
    public bool ExcludeResellerSpecified { get; set; }
    private string _resellerId;

    [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
    public string ResellerId {
        get => _resellerId;
        set {
            ResellerIdSpecified = true;
            _resellerId = value;
        }
    }

    [XmlIgnore]
    public bool ResellerIdSpecified { get; set; }
}
}
