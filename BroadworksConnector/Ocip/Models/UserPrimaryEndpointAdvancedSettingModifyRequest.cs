using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPrimaryEndpointAdvancedSettingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private bool _allowOrigination;

    [XmlElement(ElementName = "allowOrigination", IsNullable = false, Namespace = "")]
    public bool AllowOrigination {
        get => _allowOrigination;
        set {
            AllowOriginationSpecified = true;
            _allowOrigination = value;
        }
    }

    [XmlIgnore]
    public bool AllowOriginationSpecified { get; set; }
    private bool _allowTermination;

    [XmlElement(ElementName = "allowTermination", IsNullable = false, Namespace = "")]
    public bool AllowTermination {
        get => _allowTermination;
        set {
            AllowTerminationSpecified = true;
            _allowTermination = value;
        }
    }

    [XmlIgnore]
    public bool AllowTerminationSpecified { get; set; }
    private bool _allowVideo;

    [XmlElement(ElementName = "allowVideo", IsNullable = false, Namespace = "")]
    public bool AllowVideo {
        get => _allowVideo;
        set {
            AllowVideoSpecified = true;
            _allowVideo = value;
        }
    }

    [XmlIgnore]
    public bool AllowVideoSpecified { get; set; }
}
}
