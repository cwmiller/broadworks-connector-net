using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to perform a dry run for the import of a Tag Set Archive File (TSAF) as a new Tag Set.  The URL supports the HTTP and the FILE protocols.
    /// When the optional element resellerId is specified, the device type created is at reseller level.
    /// When the optional element tagSetOverride is set to true, an existing tag set on the destination system will be overridden.
    /// When the optional element tagSetRename is set, on import the tag set name part of the TSAF will be changed to the desired name on the destination system.
    /// The response is either a SystemDeviceManagementTagSetImportDryRunResponse or an ErrorResponse.
    /// 
    /// The following data elements are only used in AS data mode and ignored in XS data mode:
    /// resellerId
    /// <see cref="SystemDeviceManagementTagSetImportDryRunResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:8256""}]")]
    public class SystemDeviceManagementTagSetImportDryRunRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemDeviceManagementTagSetImportDryRunResponse>
    {

        protected string _file;

        [XmlElement(ElementName = "file", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8256")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8256")]
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

        protected bool _tagSetOverride;

        [XmlElement(ElementName = "tagSetOverride", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8256")]
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

        protected BroadWorksConnector.Ocip.Models.DeviceManagementTagSetRename _tagSetRename;

        [XmlElement(ElementName = "tagSetRename", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8256")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementTagSetRename TagSetRename
        {
            get => _tagSetRename;
            set
            {
                TagSetRenameSpecified = true;
                _tagSetRename = value;
            }
        }

        [XmlIgnore]
        protected bool TagSetRenameSpecified { get; set; }

    }
}
