using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify group trunk group Stir Shaken service settings. The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:8550""}]")]
    public class GroupTrunkGroupStirShakenModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.TrunkGroupKey _trunkGroupKey;

        [XmlElement(ElementName = "trunkGroupKey", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8550")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupKey TrunkGroupKey
        {
            get => _trunkGroupKey;
            set
            {
                TrunkGroupKeySpecified = true;
                _trunkGroupKey = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupKeySpecified { get; set; }

        private bool _useParentLevelSettings;

        [XmlElement(ElementName = "useParentLevelSettings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8550")]
        public bool UseParentLevelSettings
        {
            get => _useParentLevelSettings;
            set
            {
                UseParentLevelSettingsSpecified = true;
                _useParentLevelSettings = value;
            }
        }

        [XmlIgnore]
        protected bool UseParentLevelSettingsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.StirShakenSigningPolicy _signingPolicy;

        [XmlElement(ElementName = "signingPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8550")]
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

        private BroadWorksConnector.Ocip.Models.StirShakenTaggingPolicy _taggingPolicy;

        [XmlElement(ElementName = "taggingPolicy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8550")]
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

        private string _signingServiceURL;

        [XmlElement(ElementName = "signingServiceURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8550")]
        [MinLength(1)]
        [MaxLength(256)]
        public string SigningServiceURL
        {
            get => _signingServiceURL;
            set
            {
                SigningServiceURLSpecified = true;
                _signingServiceURL = value;
            }
        }

        [XmlIgnore]
        protected bool SigningServiceURLSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.StirShakenTagFromOrPAI _tagFromOrPAI;

        [XmlElement(ElementName = "tagFromOrPAI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8550")]
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

        private BroadWorksConnector.Ocip.Models.StirShakenVerstatTag _verstatTag;

        [XmlElement(ElementName = "verstatTag", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8550")]
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

        private bool _useOSValueForOrigId;

        [XmlElement(ElementName = "useOSValueForOrigId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8550")]
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

        private string _origUUID;

        [XmlElement(ElementName = "origUUID", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8550")]
        [MaxLength(36)]
        public string OrigUUID
        {
            get => _origUUID;
            set
            {
                OrigUUIDSpecified = true;
                _origUUID = value;
            }
        }

        [XmlIgnore]
        protected bool OrigUUIDSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.StirShakenAttestationLevel _attestationLevel;

        [XmlElement(ElementName = "attestationLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8550")]
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

        private bool _enableSigningForUnscreenedTrunkGroupOriginations;

        [XmlElement(ElementName = "enableSigningForUnscreenedTrunkGroupOriginations", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8550")]
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

        private bool _enableTaggingForUnscreenedTrunkGroupOriginations;

        [XmlElement(ElementName = "enableTaggingForUnscreenedTrunkGroupOriginations", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8550")]
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

        private BroadWorksConnector.Ocip.Models.StirShakenUnscreenedTrunkGroupOriginationAttestationLevel _unscreenedTrunkGroupOriginationAttestationLevel;

        [XmlElement(ElementName = "unscreenedTrunkGroupOriginationAttestationLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:8550")]
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

    }
}
