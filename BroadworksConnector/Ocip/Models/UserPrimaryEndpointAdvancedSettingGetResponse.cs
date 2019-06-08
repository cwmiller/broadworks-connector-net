using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPrimaryEndpointAdvancedSettingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
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
}
}
