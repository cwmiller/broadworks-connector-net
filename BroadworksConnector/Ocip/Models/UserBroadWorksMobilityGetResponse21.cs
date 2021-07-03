using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a UserBroadWorksMobilityGetRequest21.
    /// <see cref="UserBroadWorksMobilityGetRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:39762""}]")]
    public class UserBroadWorksMobilityGetResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:39762")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        private bool _useMobileIdentityCallAnchoring;

        [XmlElement(ElementName = "useMobileIdentityCallAnchoring", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:39762")]
        public bool UseMobileIdentityCallAnchoring
        {
            get => _useMobileIdentityCallAnchoring;
            set
            {
                UseMobileIdentityCallAnchoringSpecified = true;
                _useMobileIdentityCallAnchoring = value;
            }
        }

        [XmlIgnore]
        protected bool UseMobileIdentityCallAnchoringSpecified { get; set; }

        private bool _preventCallsToOwnMobiles;

        [XmlElement(ElementName = "preventCallsToOwnMobiles", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:39762")]
        public bool PreventCallsToOwnMobiles
        {
            get => _preventCallsToOwnMobiles;
            set
            {
                PreventCallsToOwnMobilesSpecified = true;
                _preventCallsToOwnMobiles = value;
            }
        }

        [XmlIgnore]
        protected bool PreventCallsToOwnMobilesSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.BroadWorksMobilityUserMobileIdentityEntry> _mobileIdentity = new List<BroadWorksConnector.Ocip.Models.BroadWorksMobilityUserMobileIdentityEntry>();

        [XmlElement(ElementName = "mobileIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:39762")]
        public List<BroadWorksConnector.Ocip.Models.BroadWorksMobilityUserMobileIdentityEntry> MobileIdentity
        {
            get => _mobileIdentity;
            set
            {
                MobileIdentitySpecified = true;
                _mobileIdentity = value;
            }
        }

        [XmlIgnore]
        protected bool MobileIdentitySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.BroadWorksMobilityPhoneToRing _profileIdentityDevicesToRing;

        [XmlElement(ElementName = "profileIdentityDevicesToRing", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:39762")]
        public BroadWorksConnector.Ocip.Models.BroadWorksMobilityPhoneToRing ProfileIdentityDevicesToRing
        {
            get => _profileIdentityDevicesToRing;
            set
            {
                ProfileIdentityDevicesToRingSpecified = true;
                _profileIdentityDevicesToRing = value;
            }
        }

        [XmlIgnore]
        protected bool ProfileIdentityDevicesToRingSpecified { get; set; }

        private bool _profileIdentityIncludeSharedCallAppearance;

        [XmlElement(ElementName = "profileIdentityIncludeSharedCallAppearance", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:39762")]
        public bool ProfileIdentityIncludeSharedCallAppearance
        {
            get => _profileIdentityIncludeSharedCallAppearance;
            set
            {
                ProfileIdentityIncludeSharedCallAppearanceSpecified = true;
                _profileIdentityIncludeSharedCallAppearance = value;
            }
        }

        [XmlIgnore]
        protected bool ProfileIdentityIncludeSharedCallAppearanceSpecified { get; set; }

        private bool _profileIdentityIncludeBroadworksAnywhere;

        [XmlElement(ElementName = "profileIdentityIncludeBroadworksAnywhere", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:39762")]
        public bool ProfileIdentityIncludeBroadworksAnywhere
        {
            get => _profileIdentityIncludeBroadworksAnywhere;
            set
            {
                ProfileIdentityIncludeBroadworksAnywhereSpecified = true;
                _profileIdentityIncludeBroadworksAnywhere = value;
            }
        }

        [XmlIgnore]
        protected bool ProfileIdentityIncludeBroadworksAnywhereSpecified { get; set; }

        private bool _profileIdentityIncludeExecutiveAssistant;

        [XmlElement(ElementName = "profileIdentityIncludeExecutiveAssistant", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:39762")]
        public bool ProfileIdentityIncludeExecutiveAssistant
        {
            get => _profileIdentityIncludeExecutiveAssistant;
            set
            {
                ProfileIdentityIncludeExecutiveAssistantSpecified = true;
                _profileIdentityIncludeExecutiveAssistant = value;
            }
        }

        [XmlIgnore]
        protected bool ProfileIdentityIncludeExecutiveAssistantSpecified { get; set; }

        private List<string> _profileIdentityMobileNumberAlerted = new List<string>();

        [XmlElement(ElementName = "profileIdentityMobileNumberAlerted", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:39762")]
        [MinLength(1)]
        [MaxLength(23)]
        public List<string> ProfileIdentityMobileNumberAlerted
        {
            get => _profileIdentityMobileNumberAlerted;
            set
            {
                ProfileIdentityMobileNumberAlertedSpecified = true;
                _profileIdentityMobileNumberAlerted = value;
            }
        }

        [XmlIgnore]
        protected bool ProfileIdentityMobileNumberAlertedSpecified { get; set; }

    }
}
