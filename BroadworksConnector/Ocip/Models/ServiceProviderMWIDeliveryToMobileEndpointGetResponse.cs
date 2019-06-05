using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderMWIDeliveryToMobileEndpointGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _templateActivationTable;

    [XmlElement(ElementName = "templateActivationTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable TemplateActivationTable {
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
