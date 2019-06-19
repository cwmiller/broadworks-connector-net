using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The response to a GroupBroadWorksMobilityGetRequest22V3.
    /// <see cref="GroupBroadWorksMobilityGetRequest22V3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:300""}]")]
    public class GroupBroadWorksMobilityGetResponse22V3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.BroadWorksMobilityGroupSettingLevel _useSettingLevel;

        [XmlElement(ElementName = "useSettingLevel", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:300")]
        public BroadWorksConnector.Ocip.Models.BroadWorksMobilityGroupSettingLevel UseSettingLevel
        {
            get => _useSettingLevel;
            set
            {
                UseSettingLevelSpecified = true;
                _useSettingLevel = value;
            }
        }

        [XmlIgnore]
        public bool UseSettingLevelSpecified { get; set; }

        private bool _enableLocationServices;

        [XmlElement(ElementName = "enableLocationServices", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:300")]
        public bool EnableLocationServices
        {
            get => _enableLocationServices;
            set
            {
                EnableLocationServicesSpecified = true;
                _enableLocationServices = value;
            }
        }

        [XmlIgnore]
        public bool EnableLocationServicesSpecified { get; set; }

        private bool _enableMSRNLookup;

        [XmlElement(ElementName = "enableMSRNLookup", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:300")]
        public bool EnableMSRNLookup
        {
            get => _enableMSRNLookup;
            set
            {
                EnableMSRNLookupSpecified = true;
                _enableMSRNLookup = value;
            }
        }

        [XmlIgnore]
        public bool EnableMSRNLookupSpecified { get; set; }

        private bool _enableMobileStateChecking;

        [XmlElement(ElementName = "enableMobileStateChecking", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:300")]
        public bool EnableMobileStateChecking
        {
            get => _enableMobileStateChecking;
            set
            {
                EnableMobileStateCheckingSpecified = true;
                _enableMobileStateChecking = value;
            }
        }

        [XmlIgnore]
        public bool EnableMobileStateCheckingSpecified { get; set; }

        private bool _denyCallOriginations;

        [XmlElement(ElementName = "denyCallOriginations", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:300")]
        public bool DenyCallOriginations
        {
            get => _denyCallOriginations;
            set
            {
                DenyCallOriginationsSpecified = true;
                _denyCallOriginations = value;
            }
        }

        [XmlIgnore]
        public bool DenyCallOriginationsSpecified { get; set; }

        private bool _denyCallTerminations;

        [XmlElement(ElementName = "denyCallTerminations", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:300")]
        public bool DenyCallTerminations
        {
            get => _denyCallTerminations;
            set
            {
                DenyCallTerminationsSpecified = true;
                _denyCallTerminations = value;
            }
        }

        [XmlIgnore]
        public bool DenyCallTerminationsSpecified { get; set; }

        private bool _enableAnnouncementSuppression;

        [XmlElement(ElementName = "enableAnnouncementSuppression", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:300")]
        public bool EnableAnnouncementSuppression
        {
            get => _enableAnnouncementSuppression;
            set
            {
                EnableAnnouncementSuppressionSpecified = true;
                _enableAnnouncementSuppression = value;
            }
        }

        [XmlIgnore]
        public bool EnableAnnouncementSuppressionSpecified { get; set; }

        private bool _enableInternalCLIDDelivery;

        [XmlElement(ElementName = "enableInternalCLIDDelivery", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:300")]
        public bool EnableInternalCLIDDelivery
        {
            get => _enableInternalCLIDDelivery;
            set
            {
                EnableInternalCLIDDeliverySpecified = true;
                _enableInternalCLIDDelivery = value;
            }
        }

        [XmlIgnore]
        public bool EnableInternalCLIDDeliverySpecified { get; set; }

        private bool _enableInternalCLIDDeliveryAccessLocations;

        [XmlElement(ElementName = "enableInternalCLIDDeliveryAccessLocations", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:300")]
        public bool EnableInternalCLIDDeliveryAccessLocations
        {
            get => _enableInternalCLIDDeliveryAccessLocations;
            set
            {
                EnableInternalCLIDDeliveryAccessLocationsSpecified = true;
                _enableInternalCLIDDeliveryAccessLocations = value;
            }
        }

        [XmlIgnore]
        public bool EnableInternalCLIDDeliveryAccessLocationsSpecified { get; set; }

        private bool _enableEnhancedUnreachableStateChecking;

        [XmlElement(ElementName = "enableEnhancedUnreachableStateChecking", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:300")]
        public bool EnableEnhancedUnreachableStateChecking
        {
            get => _enableEnhancedUnreachableStateChecking;
            set
            {
                EnableEnhancedUnreachableStateCheckingSpecified = true;
                _enableEnhancedUnreachableStateChecking = value;
            }
        }

        [XmlIgnore]
        public bool EnableEnhancedUnreachableStateCheckingSpecified { get; set; }

        private bool _enableNetworkCallBarringStatusCheck;

        [XmlElement(ElementName = "enableNetworkCallBarringStatusCheck", IsNullable = false, Namespace = "")]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:300")]
        public bool EnableNetworkCallBarringStatusCheck
        {
            get => _enableNetworkCallBarringStatusCheck;
            set
            {
                EnableNetworkCallBarringStatusCheckSpecified = true;
                _enableNetworkCallBarringStatusCheck = value;
            }
        }

        [XmlIgnore]
        public bool EnableNetworkCallBarringStatusCheckSpecified { get; set; }

        private string _networkTranslationIndex;

        [XmlElement(ElementName = "networkTranslationIndex", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:300")]
        [MinLength(1)]
        [MaxLength(128)]
        public string NetworkTranslationIndex
        {
            get => _networkTranslationIndex;
            set
            {
                NetworkTranslationIndexSpecified = true;
                _networkTranslationIndex = value;
            }
        }

        [XmlIgnore]
        public bool NetworkTranslationIndexSpecified { get; set; }

    }
}
