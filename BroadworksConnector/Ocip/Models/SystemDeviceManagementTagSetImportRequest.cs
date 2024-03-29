using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to import a Tag Set Archive File (TSAF) as a new Tag Set.  The URL supports the HTTP and the FILE protocols.
    /// When the optional element resellerId is specified, the device type created is at reseller level.
    /// When the optional element tagSetOverride is set to true, an existing tag set on the destination system will be overridden.
    /// When the optional element tagSetRename is set, on import the tag set name part of the TSAF will be changed to the desired name on the destination system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following data elements are only used in AS data mode and ignored in XS data mode:
    /// resellerId
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:8416""}]")]
    public class SystemDeviceManagementTagSetImportRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _file;

        [XmlElement(ElementName = "file", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:8416")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:8416")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:8416")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:8416")]
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
