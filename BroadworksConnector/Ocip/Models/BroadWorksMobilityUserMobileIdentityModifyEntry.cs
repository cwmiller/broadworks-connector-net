using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class BroadWorksMobilityUserMobileIdentityModifyEntry 
{
    private string _mobileNumber;

    [XmlElement(ElementName = "mobileNumber", IsNullable = false, Namespace = "")]
    public string MobileNumber {
        get => _mobileNumber;
        set {
            MobileNumberSpecified = true;
            _mobileNumber = value;
        }
    }

    [XmlIgnore]
    public bool MobileNumberSpecified { get; set; }
    private string _description;

    [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
    public string Description {
        get => _description;
        set {
            DescriptionSpecified = true;
            _description = value;
        }
    }

    [XmlIgnore]
    public bool DescriptionSpecified { get; set; }
    private bool _isPrimary;

    [XmlElement(ElementName = "isPrimary", IsNullable = false, Namespace = "")]
    public bool IsPrimary {
        get => _isPrimary;
        set {
            IsPrimarySpecified = true;
            _isPrimary = value;
        }
    }

    [XmlIgnore]
    public bool IsPrimarySpecified { get; set; }
    private bool _enableAlerting;

    [XmlElement(ElementName = "enableAlerting", IsNullable = false, Namespace = "")]
    public bool EnableAlerting {
        get => _enableAlerting;
        set {
            EnableAlertingSpecified = true;
            _enableAlerting = value;
        }
    }

    [XmlIgnore]
    public bool EnableAlertingSpecified { get; set; }
}
}
