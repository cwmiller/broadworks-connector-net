using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the group level broadworks mobility service settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9ae9f7d53e566e21347e23e20e2a2a39:467""}]")]
    public class GroupBroadWorksMobilityModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:467")]
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

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:467")]
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

        protected BroadWorksConnector.Ocip.Models.BroadWorksMobilityGroupSettingLevel? _useSettingLevel;

        [XmlElement(ElementName = "useSettingLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:467")]
        public BroadWorksConnector.Ocip.Models.BroadWorksMobilityGroupSettingLevel? UseSettingLevel
        {
            get => _useSettingLevel;
            set
            {
                UseSettingLevelSpecified = (value != null);
                _useSettingLevel = value;
            }
        }

        [XmlIgnore]
        protected bool UseSettingLevelSpecified { get; set; }

        protected bool? _enableLocationServices;

        [XmlElement(ElementName = "enableLocationServices", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:467")]
        public bool? EnableLocationServices
        {
            get => _enableLocationServices;
            set
            {
                EnableLocationServicesSpecified = (value != null);
                _enableLocationServices = value;
            }
        }

        [XmlIgnore]
        protected bool EnableLocationServicesSpecified { get; set; }

        protected bool? _enableMSRNLookup;

        [XmlElement(ElementName = "enableMSRNLookup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:467")]
        public bool? EnableMSRNLookup
        {
            get => _enableMSRNLookup;
            set
            {
                EnableMSRNLookupSpecified = (value != null);
                _enableMSRNLookup = value;
            }
        }

        [XmlIgnore]
        protected bool EnableMSRNLookupSpecified { get; set; }

        protected bool? _enableMobileStateChecking;

        [XmlElement(ElementName = "enableMobileStateChecking", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:467")]
        public bool? EnableMobileStateChecking
        {
            get => _enableMobileStateChecking;
            set
            {
                EnableMobileStateCheckingSpecified = (value != null);
                _enableMobileStateChecking = value;
            }
        }

        [XmlIgnore]
        protected bool EnableMobileStateCheckingSpecified { get; set; }

        protected bool? _denyCallOriginations;

        [XmlElement(ElementName = "denyCallOriginations", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:467")]
        public bool? DenyCallOriginations
        {
            get => _denyCallOriginations;
            set
            {
                DenyCallOriginationsSpecified = (value != null);
                _denyCallOriginations = value;
            }
        }

        [XmlIgnore]
        protected bool DenyCallOriginationsSpecified { get; set; }

        protected bool? _denyCallTerminations;

        [XmlElement(ElementName = "denyCallTerminations", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:467")]
        public bool? DenyCallTerminations
        {
            get => _denyCallTerminations;
            set
            {
                DenyCallTerminationsSpecified = (value != null);
                _denyCallTerminations = value;
            }
        }

        [XmlIgnore]
        protected bool DenyCallTerminationsSpecified { get; set; }

        protected bool? _enableAnnouncementSuppression;

        [XmlElement(ElementName = "enableAnnouncementSuppression", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:467")]
        public bool? EnableAnnouncementSuppression
        {
            get => _enableAnnouncementSuppression;
            set
            {
                EnableAnnouncementSuppressionSpecified = (value != null);
                _enableAnnouncementSuppression = value;
            }
        }

        [XmlIgnore]
        protected bool EnableAnnouncementSuppressionSpecified { get; set; }

        protected bool? _enableInternalCLIDDelivery;

        [XmlElement(ElementName = "enableInternalCLIDDelivery", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:467")]
        public bool? EnableInternalCLIDDelivery
        {
            get => _enableInternalCLIDDelivery;
            set
            {
                EnableInternalCLIDDeliverySpecified = (value != null);
                _enableInternalCLIDDelivery = value;
            }
        }

        [XmlIgnore]
        protected bool EnableInternalCLIDDeliverySpecified { get; set; }

        protected bool? _enableInternalCLIDDeliveryAccessLocations;

        [XmlElement(ElementName = "enableInternalCLIDDeliveryAccessLocations", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:467")]
        public bool? EnableInternalCLIDDeliveryAccessLocations
        {
            get => _enableInternalCLIDDeliveryAccessLocations;
            set
            {
                EnableInternalCLIDDeliveryAccessLocationsSpecified = (value != null);
                _enableInternalCLIDDeliveryAccessLocations = value;
            }
        }

        [XmlIgnore]
        protected bool EnableInternalCLIDDeliveryAccessLocationsSpecified { get; set; }

        protected bool? _enableEnhancedUnreachableStateChecking;

        [XmlElement(ElementName = "enableEnhancedUnreachableStateChecking", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:467")]
        public bool? EnableEnhancedUnreachableStateChecking
        {
            get => _enableEnhancedUnreachableStateChecking;
            set
            {
                EnableEnhancedUnreachableStateCheckingSpecified = (value != null);
                _enableEnhancedUnreachableStateChecking = value;
            }
        }

        [XmlIgnore]
        protected bool EnableEnhancedUnreachableStateCheckingSpecified { get; set; }

        protected bool? _enableNetworkCallBarringStatusCheck;

        [XmlElement(ElementName = "enableNetworkCallBarringStatusCheck", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:467")]
        public bool? EnableNetworkCallBarringStatusCheck
        {
            get => _enableNetworkCallBarringStatusCheck;
            set
            {
                EnableNetworkCallBarringStatusCheckSpecified = (value != null);
                _enableNetworkCallBarringStatusCheck = value;
            }
        }

        [XmlIgnore]
        protected bool EnableNetworkCallBarringStatusCheckSpecified { get; set; }

        protected string _networkTranslationIndex;

        [XmlElement(ElementName = "networkTranslationIndex", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:467")]
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
        protected bool NetworkTranslationIndexSpecified { get; set; }

        protected bool? _enablePBXRoutePolicy;

        [XmlElement(ElementName = "enablePBXRoutePolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:467")]
        public bool? EnablePBXRoutePolicy
        {
            get => _enablePBXRoutePolicy;
            set
            {
                EnablePBXRoutePolicySpecified = (value != null);
                _enablePBXRoutePolicy = value;
            }
        }

        [XmlIgnore]
        protected bool EnablePBXRoutePolicySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.TrunkGroupKey _pbxRouteIdentity;

        [XmlElement(ElementName = "pbxRouteIdentity", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:467")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupKey PbxRouteIdentity
        {
            get => _pbxRouteIdentity;
            set
            {
                PbxRouteIdentitySpecified = true;
                _pbxRouteIdentity = value;
            }
        }

        [XmlIgnore]
        protected bool PbxRouteIdentitySpecified { get; set; }

    }
}
