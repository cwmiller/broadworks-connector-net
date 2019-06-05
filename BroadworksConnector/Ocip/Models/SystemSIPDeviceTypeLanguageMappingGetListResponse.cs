using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDeviceTypeLanguageMappingGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _deviceTypeLanguagesTable;

    [XmlElement(ElementName = "deviceTypeLanguagesTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable DeviceTypeLanguagesTable {
        get => _deviceTypeLanguagesTable;
        set {
            DeviceTypeLanguagesTableSpecified = true;
            _deviceTypeLanguagesTable = value;
        }
    }

    [XmlIgnore]
    public bool DeviceTypeLanguagesTableSpecified { get; set; }
}
}
