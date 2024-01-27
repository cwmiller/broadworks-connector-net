using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemLocationBasedCallingRestrictionsGetRequest24.
    /// <see cref="SystemLocationBasedCallingRestrictionsGetRequest24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4489f4baeefa41b8df0a86def4c05cd8:59""}]")]
    public class SystemLocationBasedCallingRestrictionsGetResponse24 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.PhysicalLocationIndicator _physicalLocationIndicator;

        [XmlElement(ElementName = "physicalLocationIndicator", IsNullable = false, Namespace = "")]
        [Group(@"4489f4baeefa41b8df0a86def4c05cd8:59")]
        public BroadWorksConnector.Ocip.Models.PhysicalLocationIndicator PhysicalLocationIndicator
        {
            get => _physicalLocationIndicator;
            set
            {
                PhysicalLocationIndicatorSpecified = true;
                _physicalLocationIndicator = value;
            }
        }

        [XmlIgnore]
        protected bool PhysicalLocationIndicatorSpecified { get; set; }

        protected bool _enforceMscValidation;

        [XmlElement(ElementName = "enforceMscValidation", IsNullable = false, Namespace = "")]
        [Group(@"4489f4baeefa41b8df0a86def4c05cd8:59")]
        public bool EnforceMscValidation
        {
            get => _enforceMscValidation;
            set
            {
                EnforceMscValidationSpecified = true;
                _enforceMscValidation = value;
            }
        }

        [XmlIgnore]
        protected bool EnforceMscValidationSpecified { get; set; }

        protected bool _enableOfficeZoneAnnouncement;

        [XmlElement(ElementName = "enableOfficeZoneAnnouncement", IsNullable = false, Namespace = "")]
        [Group(@"4489f4baeefa41b8df0a86def4c05cd8:59")]
        public bool EnableOfficeZoneAnnouncement
        {
            get => _enableOfficeZoneAnnouncement;
            set
            {
                EnableOfficeZoneAnnouncementSpecified = true;
                _enableOfficeZoneAnnouncement = value;
            }
        }

        [XmlIgnore]
        protected bool EnableOfficeZoneAnnouncementSpecified { get; set; }

        protected bool _enhanceOfficeZone;

        [XmlElement(ElementName = "enhanceOfficeZone", IsNullable = false, Namespace = "")]
        [Group(@"4489f4baeefa41b8df0a86def4c05cd8:59")]
        public bool EnhanceOfficeZone
        {
            get => _enhanceOfficeZone;
            set
            {
                EnhanceOfficeZoneSpecified = true;
                _enhanceOfficeZone = value;
            }
        }

        [XmlIgnore]
        protected bool EnhanceOfficeZoneSpecified { get; set; }

        protected bool _enableMccMncBasedLocation;

        [XmlElement(ElementName = "enableMccMncBasedLocation", IsNullable = false, Namespace = "")]
        [Group(@"4489f4baeefa41b8df0a86def4c05cd8:59")]
        public bool EnableMccMncBasedLocation
        {
            get => _enableMccMncBasedLocation;
            set
            {
                EnableMccMncBasedLocationSpecified = true;
                _enableMccMncBasedLocation = value;
            }
        }

        [XmlIgnore]
        protected bool EnableMccMncBasedLocationSpecified { get; set; }

        protected string _mccMncRoamingNetworkTranslationIndex;

        [XmlElement(ElementName = "mccMncRoamingNetworkTranslationIndex", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4489f4baeefa41b8df0a86def4c05cd8:59")]
        [MinLength(1)]
        [MaxLength(128)]
        public string MccMncRoamingNetworkTranslationIndex
        {
            get => _mccMncRoamingNetworkTranslationIndex;
            set
            {
                MccMncRoamingNetworkTranslationIndexSpecified = true;
                _mccMncRoamingNetworkTranslationIndex = value;
            }
        }

        [XmlIgnore]
        protected bool MccMncRoamingNetworkTranslationIndexSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DefaultMccMncBasedLocation _defaultMccMncBasedLocation;

        [XmlElement(ElementName = "defaultMccMncBasedLocation", IsNullable = false, Namespace = "")]
        [Group(@"4489f4baeefa41b8df0a86def4c05cd8:59")]
        public BroadWorksConnector.Ocip.Models.DefaultMccMncBasedLocation DefaultMccMncBasedLocation
        {
            get => _defaultMccMncBasedLocation;
            set
            {
                DefaultMccMncBasedLocationSpecified = true;
                _defaultMccMncBasedLocation = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultMccMncBasedLocationSpecified { get; set; }

    }
}
