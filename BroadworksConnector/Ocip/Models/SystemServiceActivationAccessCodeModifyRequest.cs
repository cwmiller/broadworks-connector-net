using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServiceActivationAccessCodeModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private bool _isActive;

    [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
    public bool IsActive {
        get => _isActive;
        set {
            IsActiveSpecified = true;
            _isActive = value;
        }
    }

    [XmlIgnore]
    public bool IsActiveSpecified { get; set; }
    private string _terminatingAccessCode;

    [XmlElement(ElementName = "terminatingAccessCode", IsNullable = true, Namespace = "")]
    public string TerminatingAccessCode {
        get => _terminatingAccessCode;
        set {
            TerminatingAccessCodeSpecified = true;
            _terminatingAccessCode = value;
        }
    }

    [XmlIgnore]
    public bool TerminatingAccessCodeSpecified { get; set; }
    private string _redirectingAccessCode;

    [XmlElement(ElementName = "redirectingAccessCode", IsNullable = true, Namespace = "")]
    public string RedirectingAccessCode {
        get => _redirectingAccessCode;
        set {
            RedirectingAccessCodeSpecified = true;
            _redirectingAccessCode = value;
        }
    }

    [XmlIgnore]
    public bool RedirectingAccessCodeSpecified { get; set; }
    private string _clickToDialAccessCode;

    [XmlElement(ElementName = "clickToDialAccessCode", IsNullable = true, Namespace = "")]
    public string ClickToDialAccessCode {
        get => _clickToDialAccessCode;
        set {
            ClickToDialAccessCodeSpecified = true;
            _clickToDialAccessCode = value;
        }
    }

    [XmlIgnore]
    public bool ClickToDialAccessCodeSpecified { get; set; }
}
}
