using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCountryCodeGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _defaultCountryCode;

    [XmlElement(ElementName = "defaultCountryCode", IsNullable = false, Namespace = "")]
    public string DefaultCountryCode {
        get => _defaultCountryCode;
        set {
            DefaultCountryCodeSpecified = true;
            _defaultCountryCode = value;
        }
    }

    [XmlIgnore]
    public bool DefaultCountryCodeSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _countryCodeTable;

    [XmlElement(ElementName = "countryCodeTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable CountryCodeTable {
        get => _countryCodeTable;
        set {
            CountryCodeTableSpecified = true;
            _countryCodeTable = value;
        }
    }

    [XmlIgnore]
    public bool CountryCodeTableSpecified { get; set; }
}
}
