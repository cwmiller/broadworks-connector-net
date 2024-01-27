using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a UserBroadWorksMobilityGetRequest21sp1.
    /// Columns for the profileIdentityMobileNumberAlerted table are as follows: "Mobile Number", "Country Code", "National Prefix".
    /// Columns for the mobileIdentity table are as follows: "Mobile Number", "Description", "Country Code", "National Prefix", "Is Primary", "Enable Alerting".
    /// <see cref="UserBroadWorksMobilityGetRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9ae9f7d53e566e21347e23e20e2a2a39:1543""}]")]
    public class UserBroadWorksMobilityGetResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1543")]
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

        protected bool _useMobileIdentityCallAnchoring;

        [XmlElement(ElementName = "useMobileIdentityCallAnchoring", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1543")]
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

        protected bool _preventCallsToOwnMobiles;

        [XmlElement(ElementName = "preventCallsToOwnMobiles", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1543")]
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

        protected BroadWorksConnector.Ocip.Models.BroadWorksMobilityPhoneToRing _profileIdentityDevicesToRing;

        [XmlElement(ElementName = "profileIdentityDevicesToRing", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1543")]
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

        protected bool _profileIdentityIncludeSharedCallAppearance;

        [XmlElement(ElementName = "profileIdentityIncludeSharedCallAppearance", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1543")]
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

        protected bool _profileIdentityIncludeBroadworksAnywhere;

        [XmlElement(ElementName = "profileIdentityIncludeBroadworksAnywhere", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1543")]
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

        protected bool _profileIdentityIncludeExecutiveAssistant;

        [XmlElement(ElementName = "profileIdentityIncludeExecutiveAssistant", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1543")]
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

        protected BroadWorksConnector.Ocip.Models.C.OCITable _profileIdentityMobileNumberAlertedTable;

        [XmlElement(ElementName = "profileIdentityMobileNumberAlertedTable", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1543")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ProfileIdentityMobileNumberAlertedTable
        {
            get => _profileIdentityMobileNumberAlertedTable;
            set
            {
                ProfileIdentityMobileNumberAlertedTableSpecified = true;
                _profileIdentityMobileNumberAlertedTable = value;
            }
        }

        [XmlIgnore]
        protected bool ProfileIdentityMobileNumberAlertedTableSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _mobileIdentityTable;

        [XmlElement(ElementName = "mobileIdentityTable", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:1543")]
        public BroadWorksConnector.Ocip.Models.C.OCITable MobileIdentityTable
        {
            get => _mobileIdentityTable;
            set
            {
                MobileIdentityTableSpecified = true;
                _mobileIdentityTable = value;
            }
        }

        [XmlIgnore]
        protected bool MobileIdentityTableSpecified { get; set; }

    }
}
