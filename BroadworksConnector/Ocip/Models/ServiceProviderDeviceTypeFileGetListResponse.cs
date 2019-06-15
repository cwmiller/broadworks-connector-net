using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderDeviceTypeFileGetListRequest.
    /// Contains a table of device type files managed by the Device Management System, on a per-service provider basis.
    /// The column headings are: "File Format", "Is Authenticated", "Access URL", "Repository URL", "Template URL".
        /// <see cref="ServiceProviderDeviceTypeFileGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderDeviceTypeFileGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
