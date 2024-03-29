using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to import a Device Family Set Archive File (DFAF) as a new Device Family.  The URL supports the HTTP and the FILE protocols.
    /// When the optional element resellerId is specified, the device type created is at reseller level.
    /// When the optional element deviceFamilyOverride is set to true, an existing device family with the same name on the destination system will be overridden.
    /// When the optional element tagSetOverride is set to true, any existing tag set on the destination system will be overridden.
    /// When the optional element deviceTypeFileUpdate is set, on import, for any existing device type associated with the device family, the files that are matched based on the file format are updated with the ones from the DTAF. The file format and the file category are the only attributes that can't be updated.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following data elements are only used in AS data mode and ignored in XS data mode:
    /// resellerId
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:7686""}]")]
    public class SystemDeviceFamilyImportRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _file;

        [XmlElement(ElementName = "file", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7686")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:7686")]
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

        protected bool _deviceFamilyOverride;

        [XmlElement(ElementName = "deviceFamilyOverride", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:7686")]
        public bool DeviceFamilyOverride
        {
            get => _deviceFamilyOverride;
            set
            {
                DeviceFamilyOverrideSpecified = true;
                _deviceFamilyOverride = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceFamilyOverrideSpecified { get; set; }

        protected bool _tagSetOverride;

        [XmlElement(ElementName = "tagSetOverride", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:7686")]
        public bool TagSetOverride
        {
            get => _tagSetOverride;
            set
            {
                TagSetOverrideSpecified = true;
                _tagSetOverride = value;
            }
        }

        [XmlIgnore]
        protected bool TagSetOverrideSpecified { get; set; }

        protected bool _deviceTypeFileUpdate;

        [XmlElement(ElementName = "deviceTypeFileUpdate", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:7686")]
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
