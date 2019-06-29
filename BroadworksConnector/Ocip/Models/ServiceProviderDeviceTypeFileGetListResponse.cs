using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:2595""}]")]
    public class ServiceProviderDeviceTypeFileGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _serviceProviderDeviceTypeFilesTable;

        [XmlElement(ElementName = "serviceProviderDeviceTypeFilesTable", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2595")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ServiceProviderDeviceTypeFilesTable
        {
            get => _serviceProviderDeviceTypeFilesTable;
            set
            {
                ServiceProviderDeviceTypeFilesTableSpecified = true;
                _serviceProviderDeviceTypeFilesTable = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderDeviceTypeFilesTableSpecified { get; set; }

        private bool _serviceProviderHasCustomizableDynamicFiles;

        [XmlElement(ElementName = "serviceProviderHasCustomizableDynamicFiles", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2595")]
        public bool ServiceProviderHasCustomizableDynamicFiles
        {
            get => _serviceProviderHasCustomizableDynamicFiles;
            set
            {
                ServiceProviderHasCustomizableDynamicFilesSpecified = true;
                _serviceProviderHasCustomizableDynamicFiles = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderHasCustomizableDynamicFilesSpecified { get; set; }

    }
}
