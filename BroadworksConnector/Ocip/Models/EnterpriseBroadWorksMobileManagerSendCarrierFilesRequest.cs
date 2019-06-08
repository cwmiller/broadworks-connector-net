using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseBroadWorksMobileManagerSendCarrierFilesRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private string _emailTo;

    [XmlElement(ElementName = "emailTo", IsNullable = false, Namespace = "")]
    public string EmailTo {
        get => _emailTo;
        set {
            EmailToSpecified = true;
            _emailTo = value;
        }
    }

    [XmlIgnore]
    public bool EmailToSpecified { get; set; }
}
}
