using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupExtensionLengthGetRequest22.
    /// 
    /// The following elements are only used in AS data mode and not returned in XS data mode:
    /// useExterpriseExtensionLengthSetting
    /// <see cref="GroupExtensionLengthGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:5495""}]")]
    public class GroupExtensionLengthGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _minExtensionLength;

        [XmlElement(ElementName = "minExtensionLength", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:5495")]
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

        protected int _maxExtensionLength;

        [XmlElement(ElementName = "maxExtensionLength", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:5495")]
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

        protected int _defaultExtensionLength;

        [XmlElement(ElementName = "defaultExtensionLength", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:5495")]
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

        protected bool _useEnterpriseExtensionLengthSetting;

        [XmlElement(ElementName = "useEnterpriseExtensionLengthSetting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:5495")]
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
