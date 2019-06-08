using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDeviceTypeLanguageMappingGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _deviceTypeLanguagesTable;

    [XmlElement(ElementName = "deviceTypeLanguagesTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable DeviceTypeLanguagesTable {
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
