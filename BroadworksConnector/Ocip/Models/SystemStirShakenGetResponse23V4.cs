using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemStirShakenGetRequest23V4.
    /// Replaced by SystemStirShakenGetResponse23V5.
    /// <see cref="SystemStirShakenGetRequest23V4"/>
    /// <see cref="SystemStirShakenGetResponse23V5"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:39763""}]")]
    public class SystemStirShakenGetResponse23V4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.StirShakenSigningPolicy _signingPolicy;

        [XmlElement(ElementName = "signingPolicy", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public BroadWorksConnector.Ocip.Models.StirShakenSigningPolicy SigningPolicy
        {
            get => _signingPolicy;
            set
            {
                SigningPolicySpecified = true;
                _signingPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool SigningPolicySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenTaggingPolicy _taggingPolicy;

        [XmlElement(ElementName = "taggingPolicy", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public BroadWorksConnector.Ocip.Models.StirShakenTaggingPolicy TaggingPolicy
        {
            get => _taggingPolicy;
            set
            {
                TaggingPolicySpecified = true;
                _taggingPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool TaggingPolicySpecified { get; set; }

        protected bool _signEmergencyCalls;

        [XmlElement(ElementName = "signEmergencyCalls", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool SignEmergencyCalls
        {
            get => _signEmergencyCalls;
            set
            {
                SignEmergencyCallsSpecified = true;
                _signEmergencyCalls = value;
            }
        }

        [XmlIgnore]
        protected bool SignEmergencyCallsSpecified { get; set; }

        protected bool _tagEmergencyCalls;

        [XmlElement(ElementName = "tagEmergencyCalls", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool TagEmergencyCalls
        {
            get => _tagEmergencyCalls;
            set
            {
                TagEmergencyCallsSpecified = true;
                _tagEmergencyCalls = value;
            }
        }

        [XmlIgnore]
        protected bool TagEmergencyCallsSpecified { get; set; }

        protected string _signingServiceURL;

        [XmlElement(ElementName = "signingServiceURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        [MinLength(1)]
        [MaxLength(256)]
        public string SigningServiceURL
        {
            get => _signingServiceURL;
            set
            {
                SigningServiceURLSpecified = (value != null);
                _signingServiceURL = value;
            }
        }

        [XmlIgnore]
        protected bool SigningServiceURLSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenTagFromOrPAI _tagFromOrPAI;

        [XmlElement(ElementName = "tagFromOrPAI", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public BroadWorksConnector.Ocip.Models.StirShakenTagFromOrPAI TagFromOrPAI
        {
            get => _tagFromOrPAI;
            set
            {
                TagFromOrPAISpecified = true;
                _tagFromOrPAI = value;
            }
        }

        [XmlIgnore]
        protected bool TagFromOrPAISpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenVerstatTag _verstatTag;

        [XmlElement(ElementName = "verstatTag", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public BroadWorksConnector.Ocip.Models.StirShakenVerstatTag VerstatTag
        {
            get => _verstatTag;
            set
            {
                VerstatTagSpecified = true;
                _verstatTag = value;
            }
        }

        [XmlIgnore]
        protected bool VerstatTagSpecified { get; set; }

        protected bool _useOSValueForOrigId;

        [XmlElement(ElementName = "useOSValueForOrigId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool UseOSValueForOrigId
        {
            get => _useOSValueForOrigId;
            set
            {
                UseOSValueForOrigIdSpecified = true;
                _useOSValueForOrigId = value;
            }
        }

        [XmlIgnore]
        protected bool UseOSValueForOrigIdSpecified { get; set; }

        protected string _origUUID;

        [XmlElement(ElementName = "origUUID", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        [MaxLength(36)]
        public string OrigUUID
        {
            get => _origUUID;
            set
            {
                OrigUUIDSpecified = (value != null);
                _origUUID = value;
            }
        }

        [XmlIgnore]
        protected bool OrigUUIDSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenAttestationLevel _attestationLevel;

        [XmlElement(ElementName = "attestationLevel", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public BroadWorksConnector.Ocip.Models.StirShakenAttestationLevel AttestationLevel
        {
            get => _attestationLevel;
            set
            {
                AttestationLevelSpecified = true;
                _attestationLevel = value;
            }
        }

        [XmlIgnore]
        protected bool AttestationLevelSpecified { get; set; }

        protected bool _enableVerification;

        [XmlElement(ElementName = "enableVerification", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool EnableVerification
        {
            get => _enableVerification;
            set
            {
                EnableVerificationSpecified = true;
                _enableVerification = value;
            }
        }

        [XmlIgnore]
        protected bool EnableVerificationSpecified { get; set; }

        protected string _verificationServiceURL;

        [XmlElement(ElementName = "verificationServiceURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        [MinLength(1)]
        [MaxLength(256)]
        public string VerificationServiceURL
        {
            get => _verificationServiceURL;
            set
            {
                VerificationServiceURLSpecified = (value != null);
                _verificationServiceURL = value;
            }
        }

        [XmlIgnore]
        protected bool VerificationServiceURLSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenVerificationErrorHandling _verificationErrorHandling;

        [XmlElement(ElementName = "verificationErrorHandling", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public BroadWorksConnector.Ocip.Models.StirShakenVerificationErrorHandling VerificationErrorHandling
        {
            get => _verificationErrorHandling;
            set
            {
                VerificationErrorHandlingSpecified = true;
                _verificationErrorHandling = value;
            }
        }

        [XmlIgnore]
        protected bool VerificationErrorHandlingSpecified { get; set; }

        protected bool _proxyVerstatToCNAMSubscribe;

        [XmlElement(ElementName = "proxyVerstatToCNAMSubscribe", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool ProxyVerstatToCNAMSubscribe
        {
            get => _proxyVerstatToCNAMSubscribe;
            set
            {
                ProxyVerstatToCNAMSubscribeSpecified = true;
                _proxyVerstatToCNAMSubscribe = value;
            }
        }

        [XmlIgnore]
        protected bool ProxyVerstatToCNAMSubscribeSpecified { get; set; }

        protected bool _useUnknownHeadersFromCNAMNotify;

        [XmlElement(ElementName = "useUnknownHeadersFromCNAMNotify", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool UseUnknownHeadersFromCNAMNotify
        {
            get => _useUnknownHeadersFromCNAMNotify;
            set
            {
                UseUnknownHeadersFromCNAMNotifySpecified = true;
                _useUnknownHeadersFromCNAMNotify = value;
            }
        }

        [XmlIgnore]
        protected bool UseUnknownHeadersFromCNAMNotifySpecified { get; set; }

        protected bool _useTS24229Headers;

        [XmlElement(ElementName = "useTS24229Headers", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool UseTS24229Headers
        {
            get => _useTS24229Headers;
            set
            {
                UseTS24229HeadersSpecified = true;
                _useTS24229Headers = value;
            }
        }

        [XmlIgnore]
        protected bool UseTS24229HeadersSpecified { get; set; }

        protected bool _enableSigningForUnscreenedTrunkGroupOriginations;

        [XmlElement(ElementName = "enableSigningForUnscreenedTrunkGroupOriginations", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool EnableSigningForUnscreenedTrunkGroupOriginations
        {
            get => _enableSigningForUnscreenedTrunkGroupOriginations;
            set
            {
                EnableSigningForUnscreenedTrunkGroupOriginationsSpecified = true;
                _enableSigningForUnscreenedTrunkGroupOriginations = value;
            }
        }

        [XmlIgnore]
        protected bool EnableSigningForUnscreenedTrunkGroupOriginationsSpecified { get; set; }

        protected bool _enableTaggingForUnscreenedTrunkGroupOriginations;

        [XmlElement(ElementName = "enableTaggingForUnscreenedTrunkGroupOriginations", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool EnableTaggingForUnscreenedTrunkGroupOriginations
        {
            get => _enableTaggingForUnscreenedTrunkGroupOriginations;
            set
            {
                EnableTaggingForUnscreenedTrunkGroupOriginationsSpecified = true;
                _enableTaggingForUnscreenedTrunkGroupOriginations = value;
            }
        }

        [XmlIgnore]
        protected bool EnableTaggingForUnscreenedTrunkGroupOriginationsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenUnscreenedTrunkGroupOriginationAttestationLevel _unscreenedTrunkGroupOriginationAttestationLevel;

        [XmlElement(ElementName = "unscreenedTrunkGroupOriginationAttestationLevel", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public BroadWorksConnector.Ocip.Models.StirShakenUnscreenedTrunkGroupOriginationAttestationLevel UnscreenedTrunkGroupOriginationAttestationLevel
        {
            get => _unscreenedTrunkGroupOriginationAttestationLevel;
            set
            {
                UnscreenedTrunkGroupOriginationAttestationLevelSpecified = true;
                _unscreenedTrunkGroupOriginationAttestationLevel = value;
            }
        }

        [XmlIgnore]
        protected bool UnscreenedTrunkGroupOriginationAttestationLevelSpecified { get; set; }

        protected bool _verifyGETSCalls;

        [XmlElement(ElementName = "verifyGETSCalls", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool VerifyGETSCalls
        {
            get => _verifyGETSCalls;
            set
            {
                VerifyGETSCallsSpecified = true;
                _verifyGETSCalls = value;
            }
        }

        [XmlIgnore]
        protected bool VerifyGETSCallsSpecified { get; set; }

        protected bool _allowPartialIngressTagging;

        [XmlElement(ElementName = "allowPartialIngressTagging", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool AllowPartialIngressTagging
        {
            get => _allowPartialIngressTagging;
            set
            {
                AllowPartialIngressTaggingSpecified = true;
                _allowPartialIngressTagging = value;
            }
        }

        [XmlIgnore]
        protected bool AllowPartialIngressTaggingSpecified { get; set; }

        protected bool _includeVerstatToMobileNetworkLocations;

        [XmlElement(ElementName = "includeVerstatToMobileNetworkLocations", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool IncludeVerstatToMobileNetworkLocations
        {
            get => _includeVerstatToMobileNetworkLocations;
            set
            {
                IncludeVerstatToMobileNetworkLocationsSpecified = true;
                _includeVerstatToMobileNetworkLocations = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeVerstatToMobileNetworkLocationsSpecified { get; set; }

        protected bool _allowVerstatInSIPURIWithPhoneCorrection;

        [XmlElement(ElementName = "allowVerstatInSIPURIWithPhoneCorrection", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool AllowVerstatInSIPURIWithPhoneCorrection
        {
            get => _allowVerstatInSIPURIWithPhoneCorrection;
            set
            {
                AllowVerstatInSIPURIWithPhoneCorrectionSpecified = true;
                _allowVerstatInSIPURIWithPhoneCorrection = value;
            }
        }

        [XmlIgnore]
        protected bool AllowVerstatInSIPURIWithPhoneCorrectionSpecified { get; set; }

        protected bool _includeTaggedHeadersToAccessSide;

        [XmlElement(ElementName = "includeTaggedHeadersToAccessSide", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool IncludeTaggedHeadersToAccessSide
        {
            get => _includeTaggedHeadersToAccessSide;
            set
            {
                IncludeTaggedHeadersToAccessSideSpecified = true;
                _includeTaggedHeadersToAccessSide = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeTaggedHeadersToAccessSideSpecified { get; set; }

        protected bool _proxyIdentityHeaderToAccessSide;

        [XmlElement(ElementName = "proxyIdentityHeaderToAccessSide", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool ProxyIdentityHeaderToAccessSide
        {
            get => _proxyIdentityHeaderToAccessSide;
            set
            {
                ProxyIdentityHeaderToAccessSideSpecified = true;
                _proxyIdentityHeaderToAccessSide = value;
            }
        }

        [XmlIgnore]
        protected bool ProxyIdentityHeaderToAccessSideSpecified { get; set; }

        protected bool _checkDirectoryNumbersForAttestation;

        [XmlElement(ElementName = "checkDirectoryNumbersForAttestation", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool CheckDirectoryNumbersForAttestation
        {
            get => _checkDirectoryNumbersForAttestation;
            set
            {
                CheckDirectoryNumbersForAttestationSpecified = true;
                _checkDirectoryNumbersForAttestation = value;
            }
        }

        [XmlIgnore]
        protected bool CheckDirectoryNumbersForAttestationSpecified { get; set; }

        protected bool _matchUnassignedNumbersOnly;

        [XmlElement(ElementName = "matchUnassignedNumbersOnly", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool MatchUnassignedNumbersOnly
        {
            get => _matchUnassignedNumbersOnly;
            set
            {
                MatchUnassignedNumbersOnlySpecified = true;
                _matchUnassignedNumbersOnly = value;
            }
        }

        [XmlIgnore]
        protected bool MatchUnassignedNumbersOnlySpecified { get; set; }

        protected bool _enableTaggingForRedirectedCalls;

        [XmlElement(ElementName = "enableTaggingForRedirectedCalls", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool EnableTaggingForRedirectedCalls
        {
            get => _enableTaggingForRedirectedCalls;
            set
            {
                EnableTaggingForRedirectedCallsSpecified = true;
                _enableTaggingForRedirectedCalls = value;
            }
        }

        [XmlIgnore]
        protected bool EnableTaggingForRedirectedCallsSpecified { get; set; }

        protected bool _preferIngressTagging;

        [XmlElement(ElementName = "preferIngressTagging", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool PreferIngressTagging
        {
            get => _preferIngressTagging;
            set
            {
                PreferIngressTaggingSpecified = true;
                _preferIngressTagging = value;
            }
        }

        [XmlIgnore]
        protected bool PreferIngressTaggingSpecified { get; set; }

        protected bool _preferFromForAttestation;

        [XmlElement(ElementName = "preferFromForAttestation", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool PreferFromForAttestation
        {
            get => _preferFromForAttestation;
            set
            {
                PreferFromForAttestationSpecified = true;
                _preferFromForAttestation = value;
            }
        }

        [XmlIgnore]
        protected bool PreferFromForAttestationSpecified { get; set; }

        protected bool _preferFromForIdentityVerification;

        [XmlElement(ElementName = "preferFromForIdentityVerification", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool PreferFromForIdentityVerification
        {
            get => _preferFromForIdentityVerification;
            set
            {
                PreferFromForIdentityVerificationSpecified = true;
                _preferFromForIdentityVerification = value;
            }
        }

        [XmlIgnore]
        protected bool PreferFromForIdentityVerificationSpecified { get; set; }

        protected bool _includeVerstatInDiversionOrHistoryInfo;

        [XmlElement(ElementName = "includeVerstatInDiversionOrHistoryInfo", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool IncludeVerstatInDiversionOrHistoryInfo
        {
            get => _includeVerstatInDiversionOrHistoryInfo;
            set
            {
                IncludeVerstatInDiversionOrHistoryInfoSpecified = true;
                _includeVerstatInDiversionOrHistoryInfo = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeVerstatInDiversionOrHistoryInfoSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenSigningPolicy _accessSideIngressIdentityHeaderProxyPolicy;

        [XmlElement(ElementName = "accessSideIngressIdentityHeaderProxyPolicy", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public BroadWorksConnector.Ocip.Models.StirShakenSigningPolicy AccessSideIngressIdentityHeaderProxyPolicy
        {
            get => _accessSideIngressIdentityHeaderProxyPolicy;
            set
            {
                AccessSideIngressIdentityHeaderProxyPolicySpecified = true;
                _accessSideIngressIdentityHeaderProxyPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool AccessSideIngressIdentityHeaderProxyPolicySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.StirShakenTaggingPolicy _accessSideIngressTaggingProxyPolicy;

        [XmlElement(ElementName = "accessSideIngressTaggingProxyPolicy", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public BroadWorksConnector.Ocip.Models.StirShakenTaggingPolicy AccessSideIngressTaggingProxyPolicy
        {
            get => _accessSideIngressTaggingProxyPolicy;
            set
            {
                AccessSideIngressTaggingProxyPolicySpecified = true;
                _accessSideIngressTaggingProxyPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool AccessSideIngressTaggingProxyPolicySpecified { get; set; }

        protected bool _includeVerstatToInterNetworkCalls;

        [XmlElement(ElementName = "includeVerstatToInterNetworkCalls", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool IncludeVerstatToInterNetworkCalls
        {
            get => _includeVerstatToInterNetworkCalls;
            set
            {
                IncludeVerstatToInterNetworkCallsSpecified = true;
                _includeVerstatToInterNetworkCalls = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeVerstatToInterNetworkCallsSpecified { get; set; }

        protected bool _includeVerstatToIntraNetworkCalls;

        [XmlElement(ElementName = "includeVerstatToIntraNetworkCalls", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39763")]
        public bool IncludeVerstatToIntraNetworkCalls
        {
            get => _includeVerstatToIntraNetworkCalls;
            set
            {
                IncludeVerstatToIntraNetworkCallsSpecified = true;
                _includeVerstatToIntraNetworkCalls = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeVerstatToIntraNetworkCallsSpecified { get; set; }

    }
}
