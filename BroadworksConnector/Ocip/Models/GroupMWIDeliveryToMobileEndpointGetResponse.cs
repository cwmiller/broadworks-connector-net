using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupMWIDeliveryToMobileEndpointGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.MWIDeliveryToMobileEndpointGroupSettingLevel _useSettingLevel;

    [XmlElement(ElementName = "useSettingLevel", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MWIDeliveryToMobileEndpointGroupSettingLevel UseSettingLevel {
        get => _useSettingLevel;
        set {
            UseSettingLevelSpecified = true;
            _useSettingLevel = value;
        }
    }

    [XmlIgnore]
    public bool UseSettingLevelSpecified { get; set; }
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
