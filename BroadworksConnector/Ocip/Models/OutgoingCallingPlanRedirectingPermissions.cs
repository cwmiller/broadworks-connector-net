using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingCallingPlanRedirectingPermissions 
{
    private bool _group;

    [XmlElement(ElementName = "group", IsNullable = false, Namespace = "")]
    public bool Group {
        get => _group;
        set {
            GroupSpecified = true;
            _group = value;
        }
    }

    [XmlIgnore]
    public bool GroupSpecified { get; set; }
    private bool _local;

    [XmlElement(ElementName = "local", IsNullable = false, Namespace = "")]
    public bool Local {
        get => _local;
        set {
            LocalSpecified = true;
            _local = value;
        }
    }

    [XmlIgnore]
    public bool LocalSpecified { get; set; }
    private bool _tollFree;

    [XmlElement(ElementName = "tollFree", IsNullable = false, Namespace = "")]
    public bool TollFree {
        get => _tollFree;
        set {
            TollFreeSpecified = true;
            _tollFree = value;
        }
    }

    [XmlIgnore]
    public bool TollFreeSpecified { get; set; }
    private bool _toll;

    [XmlElement(ElementName = "toll", IsNullable = false, Namespace = "")]
    public bool Toll {
        get => _toll;
        set {
            TollSpecified = true;
            _toll = value;
        }
    }

    [XmlIgnore]
    public bool TollSpecified { get; set; }
    private bool _international;

    [XmlElement(ElementName = "international", IsNullable = false, Namespace = "")]
    public bool International {
        get => _international;
        set {
            InternationalSpecified = true;
            _international = value;
        }
    }

    [XmlIgnore]
    public bool InternationalSpecified { get; set; }
    private bool _operatorAssisted;

    [XmlElement(ElementName = "operatorAssisted", IsNullable = false, Namespace = "")]
    public bool OperatorAssisted {
        get => _operatorAssisted;
        set {
            OperatorAssistedSpecified = true;
            _operatorAssisted = value;
        }
    }

    [XmlIgnore]
    public bool OperatorAssistedSpecified { get; set; }
    private bool _chargeableDirectoryAssisted;

    [XmlElement(ElementName = "chargeableDirectoryAssisted", IsNullable = false, Namespace = "")]
    public bool ChargeableDirectoryAssisted {
        get => _chargeableDirectoryAssisted;
        set {
            ChargeableDirectoryAssistedSpecified = true;
            _chargeableDirectoryAssisted = value;
        }
    }

    [XmlIgnore]
    public bool ChargeableDirectoryAssistedSpecified { get; set; }
    private bool _specialServicesI;

    [XmlElement(ElementName = "specialServicesI", IsNullable = false, Namespace = "")]
    public bool SpecialServicesI {
        get => _specialServicesI;
        set {
            SpecialServicesISpecified = true;
            _specialServicesI = value;
        }
    }

    [XmlIgnore]
    public bool SpecialServicesISpecified { get; set; }
    private bool _specialServicesII;

    [XmlElement(ElementName = "specialServicesII", IsNullable = false, Namespace = "")]
    public bool SpecialServicesII {
        get => _specialServicesII;
        set {
            SpecialServicesIISpecified = true;
            _specialServicesII = value;
        }
    }

    [XmlIgnore]
    public bool SpecialServicesIISpecified { get; set; }
    private bool _premiumServicesI;

    [XmlElement(ElementName = "premiumServicesI", IsNullable = false, Namespace = "")]
    public bool PremiumServicesI {
        get => _premiumServicesI;
        set {
            PremiumServicesISpecified = true;
            _premiumServicesI = value;
        }
    }

    [XmlIgnore]
    public bool PremiumServicesISpecified { get; set; }
    private bool _premiumServicesII;

    [XmlElement(ElementName = "premiumServicesII", IsNullable = false, Namespace = "")]
    public bool PremiumServicesII {
        get => _premiumServicesII;
        set {
            PremiumServicesIISpecified = true;
            _premiumServicesII = value;
        }
    }

    [XmlIgnore]
    public bool PremiumServicesIISpecified { get; set; }
    private bool _casual;

    [XmlElement(ElementName = "casual", IsNullable = false, Namespace = "")]
    public bool Casual {
        get => _casual;
        set {
            CasualSpecified = true;
            _casual = value;
        }
    }

    [XmlIgnore]
    public bool CasualSpecified { get; set; }
    private bool _urlDialing;

    [XmlElement(ElementName = "urlDialing", IsNullable = false, Namespace = "")]
    public bool UrlDialing {
        get => _urlDialing;
        set {
            UrlDialingSpecified = true;
            _urlDialing = value;
        }
    }

    [XmlIgnore]
    public bool UrlDialingSpecified { get; set; }
    private bool _unknown;

    [XmlElement(ElementName = "unknown", IsNullable = false, Namespace = "")]
    public bool Unknown {
        get => _unknown;
        set {
            UnknownSpecified = true;
            _unknown = value;
        }
    }

    [XmlIgnore]
    public bool UnknownSpecified { get; set; }
}
}
