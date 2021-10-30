using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the group's extension length range.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// useExterpriseExtensionLengthSetting
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:5781""}]")]
    public class GroupExtensionLengthModifyRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5781")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5781")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        private int _minExtensionLength;

        [XmlElement(ElementName = "minExtensionLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5781")]
        [MinInclusive(2)]
        [MaxInclusive(20)]
        public int MinExtensionLength
        {
            get => _minExtensionLength;
            set
            {
                MinExtensionLengthSpecified = true;
                _minExtensionLength = value;
            }
        }

        [XmlIgnore]
        protected bool MinExtensionLengthSpecified { get; set; }

        private int _maxExtensionLength;

        [XmlElement(ElementName = "maxExtensionLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5781")]
        [MinInclusive(2)]
        [MaxInclusive(20)]
        public int MaxExtensionLength
        {
            get => _maxExtensionLength;
            set
            {
                MaxExtensionLengthSpecified = true;
                _maxExtensionLength = value;
            }
        }

        [XmlIgnore]
        protected bool MaxExtensionLengthSpecified { get; set; }

        private int _defaultExtensionLength;

        [XmlElement(ElementName = "defaultExtensionLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5781")]
        [MinInclusive(2)]
        [MaxInclusive(20)]
        public int DefaultExtensionLength
        {
            get => _defaultExtensionLength;
            set
            {
                DefaultExtensionLengthSpecified = true;
                _defaultExtensionLength = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultExtensionLengthSpecified { get; set; }

        private bool _useEnterpriseExtensionLengthSetting;

        [XmlElement(ElementName = "useEnterpriseExtensionLengthSetting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5781")]
        public bool UseEnterpriseExtensionLengthSetting
        {
            get => _useEnterpriseExtensionLengthSetting;
            set
            {
                UseEnterpriseExtensionLengthSettingSpecified = true;
                _useEnterpriseExtensionLengthSetting = value;
            }
        }

        [XmlIgnore]
        protected bool UseEnterpriseExtensionLengthSettingSpecified { get; set; }

    }
}
