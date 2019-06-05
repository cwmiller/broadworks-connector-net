using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDeviceTypeFileGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _serviceProviderDeviceTypeFilesTable;

    [XmlElement(ElementName = "serviceProviderDeviceTypeFilesTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ServiceProviderDeviceTypeFilesTable {
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
