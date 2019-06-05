using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemLicensingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.LicenseStrictness _licenseStrictness;

    [XmlElement(ElementName = "licenseStrictness", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.LicenseStrictness LicenseStrictness {
        get => _licenseStrictness;
        set {
            LicenseStrictnessSpecified = true;
            _licenseStrictness = value;
        }
    }

    [XmlIgnore]
    public bool LicenseStrictnessSpecified { get; set; }
    private int _groupUserlimit;

    [XmlElement(ElementName = "groupUserlimit", IsNullable = false, Namespace = "")]
    public int GroupUserlimit {
        get => _groupUserlimit;
        set {
            GroupUserlimitSpecified = true;
            _groupUserlimit = value;
        }
    }

    [XmlIgnore]
    public bool GroupUserlimitSpecified { get; set; }
    private string _expirationDate;

    [XmlElement(ElementName = "expirationDate", IsNullable = false, Namespace = "")]
    public string ExpirationDate {
        get => _expirationDate;
        set {
            ExpirationDateSpecified = true;
            _expirationDate = value;
        }
    }

    [XmlIgnore]
    public bool ExpirationDateSpecified { get; set; }
    private List<string> _hostId;

    [XmlElement(ElementName = "hostId", IsNullable = false, Namespace = "")]
    public List<string> HostId {
        get => _hostId;
        set {
            HostIdSpecified = true;
            _hostId = value;
        }
    }

    [XmlIgnore]
    public bool HostIdSpecified { get; set; }
    private List<string> _licenseName;

    [XmlElement(ElementName = "licenseName", IsNullable = false, Namespace = "")]
    public List<string> LicenseName {
        get => _licenseName;
        set {
            LicenseNameSpecified = true;
            _licenseName = value;
        }
    }

    [XmlIgnore]
    public bool LicenseNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _licenseTable;

    [XmlElement(ElementName = "licenseTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable LicenseTable {
        get => _licenseTable;
        set {
            LicenseTableSpecified = true;
            _licenseTable = value;
        }
    }

    [XmlIgnore]
    public bool LicenseTableSpecified { get; set; }
}
}
