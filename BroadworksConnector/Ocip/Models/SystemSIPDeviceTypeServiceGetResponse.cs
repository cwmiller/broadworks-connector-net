using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDeviceTypeServiceGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _supportsPolycomPhoneServices;

    [XmlElement(ElementName = "supportsPolycomPhoneServices", IsNullable = false, Namespace = "")]
    public bool SupportsPolycomPhoneServices {
        get => _supportsPolycomPhoneServices;
        set {
            SupportsPolycomPhoneServicesSpecified = true;
            _supportsPolycomPhoneServices = value;
        }
    }

    [XmlIgnore]
    public bool SupportsPolycomPhoneServicesSpecified { get; set; }
}
}
