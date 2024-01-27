using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to perform a dry run for the import of a Device Type Archive File (DTAF) as a new Device Type.  The URL supports the HTTP and the FILE protocols.
    /// When the optional element resellerId is specified, the device type created is at reseller level.
    /// When the optional element deviceTypeRename is set, on import, the device type name part of the DTAF will be changed to the desired name on the destination system.
    /// When the optional element deviceTypeFileUpdate is set, on import, the files that are matched based on the file format are updated with the ones from the DTAF. The file format and the file category are the only attributes that can't be updated.
    /// The response is either a SystemDeviceTypeImportDryRunResponse or an ErrorResponse.
    /// 
    /// The following data elements are only used in AS data mode and ignored in XS data mode:
    /// deviceTypeFileUpdate
    /// deviceTypeRename
    /// resellerId
    /// <see cref="SystemDeviceTypeImportDryRunResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:8938""}]")]
    public class SystemDeviceTypeImportDryRunRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemDeviceTypeImportDryRunResponse>
    {

        protected string _file;

        [XmlElement(ElementName = "file", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:8938")]
        [MinLength(1)]
        [MaxLength(256)]
        public string File
        {
            get => _file;
            set
            {
                FileSpecified = true;
                _file = value;
            }
        }

        [XmlIgnore]
        protected bool FileSpecified { get; set; }

        protected string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:8938")]
        [MinLength(1)]
        [MaxLength(36)]
        public string ResellerId
        {
            get => _resellerId;
            set
            {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AccessDeviceTypeRename _deviceTypeRename;

        [XmlElement(ElementName = "deviceTypeRename", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:8938")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceTypeRename DeviceTypeRename
        {
            get => _deviceTypeRename;
            set
            {
                DeviceTypeRenameSpecified = true;
                _deviceTypeRename = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceTypeRenameSpecified { get; set; }

        protected bool _deviceTypeFileUpdate;

        [XmlElement(ElementName = "deviceTypeFileUpdate", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:8938")]
        public bool DeviceTypeFileUpdate
        {
            get => _deviceTypeFileUpdate;
            set
            {
                DeviceTypeFileUpdateSpecified = true;
                _deviceTypeFileUpdate = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceTypeFileUpdateSpecified { get; set; }

    }
}
