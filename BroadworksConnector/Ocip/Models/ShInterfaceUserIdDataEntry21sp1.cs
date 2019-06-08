using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ShInterfaceUserIdDataEntry21sp1 
{
    private BroadWorksConnector.Ocip.Models.UserType _userType;

    [XmlElement(ElementName = "userType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.UserType UserType {
        get => _userType;
        set {
            UserTypeSpecified = true;
            _userType = value;
        }
    }

    [XmlIgnore]
    public bool UserTypeSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.PublicUserIdentity _publicUserIdentity;

    [XmlElement(ElementName = "publicUserIdentity", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.PublicUserIdentity PublicUserIdentity {
        get => _publicUserIdentity;
        set {
            PublicUserIdentitySpecified = true;
            _publicUserIdentity = value;
        }
    }

    [XmlIgnore]
    public bool PublicUserIdentitySpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.EndpointType21sp1 _endpointType;

    [XmlElement(ElementName = "endpointType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.EndpointType21sp1 EndpointType {
        get => _endpointType;
        set {
            EndpointTypeSpecified = true;
            _endpointType = value;
        }
    }

    [XmlIgnore]
    public bool EndpointTypeSpecified { get; set; }
    private string _sCSCFName;

    [XmlElement(ElementName = "SCSCFName", IsNullable = false, Namespace = "")]
    public string SCSCFName {
        get => _sCSCFName;
        set {
            SCSCFNameSpecified = true;
            _sCSCFName = value;
        }
    }

    [XmlIgnore]
    public bool SCSCFNameSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.IMSUserState _iMSUserState;

    [XmlElement(ElementName = "IMSUserState", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.IMSUserState IMSUserState {
        get => _iMSUserState;
        set {
            IMSUserStateSpecified = true;
            _iMSUserState = value;
        }
    }

    [XmlIgnore]
    public bool IMSUserStateSpecified { get; set; }
}
}
