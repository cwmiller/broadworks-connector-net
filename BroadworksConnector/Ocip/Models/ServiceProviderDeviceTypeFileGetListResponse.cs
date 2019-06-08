using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDeviceTypeFileGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _serviceProviderDeviceTypeFilesTable;

    [XmlElement(ElementName = "serviceProviderDeviceTypeFilesTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ServiceProviderDeviceTypeFilesTable {
        get => _serviceProviderDeviceTypeFilesTable;
        set {
            ServiceProviderDeviceTypeFilesTableSpecified = true;
            _serviceProviderDeviceTypeFilesTable = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderDeviceTypeFilesTableSpecified { get; set; }
    private bool _serviceProviderHasCustomizableDynamicFiles;

    [XmlElement(ElementName = "serviceProviderHasCustomizableDynamicFiles", IsNullable = false, Namespace = "")]
    public bool ServiceProviderHasCustomizableDynamicFiles {
        get => _serviceProviderHasCustomizableDynamicFiles;
        set {
            ServiceProviderHasCustomizableDynamicFilesSpecified = true;
            _serviceProviderHasCustomizableDynamicFiles = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderHasCustomizableDynamicFilesSpecified { get; set; }
}
}
