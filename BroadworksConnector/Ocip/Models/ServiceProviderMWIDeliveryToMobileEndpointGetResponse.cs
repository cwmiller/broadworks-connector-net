using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderMWIDeliveryToMobileEndpointGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _templateActivationTable;

    [XmlElement(ElementName = "templateActivationTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable TemplateActivationTable {
        get => _templateActivationTable;
        set {
            TemplateActivationTableSpecified = true;
            _templateActivationTable = value;
        }
    }

    [XmlIgnore]
    public bool TemplateActivationTableSpecified { get; set; }
}
}
