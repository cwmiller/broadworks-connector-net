using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class PrimaryInfoGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
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
    private string _hostnameForPrimary;

    [XmlElement(ElementName = "hostnameForPrimary", IsNullable = false, Namespace = "")]
    public string HostnameForPrimary {
        get => _hostnameForPrimary;
        set {
            HostnameForPrimarySpecified = true;
            _hostnameForPrimary = value;
        }
    }

    [XmlIgnore]
    public bool HostnameForPrimarySpecified { get; set; }
    private List<string> _addressForPrimary;

    [XmlElement(ElementName = "addressForPrimary", IsNullable = false, Namespace = "")]
    public List<string> AddressForPrimary {
        get => _addressForPrimary;
        set {
            AddressForPrimarySpecified = true;
            _addressForPrimary = value;
        }
    }

    [XmlIgnore]
    public bool AddressForPrimarySpecified { get; set; }
    private List<string> _privateAddressForPrimary;

    [XmlElement(ElementName = "privateAddressForPrimary", IsNullable = false, Namespace = "")]
    public List<string> PrivateAddressForPrimary {
        get => _privateAddressForPrimary;
        set {
            PrivateAddressForPrimarySpecified = true;
            _privateAddressForPrimary = value;
        }
    }

    [XmlIgnore]
    public bool PrivateAddressForPrimarySpecified { get; set; }
}
}
