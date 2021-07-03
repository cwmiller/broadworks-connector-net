using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the group level data associated with Call Processing Policy.
    /// The response is either a GroupCallProcessingGetPolicyResponse17sp4 or an
    /// ErrorResponse.
    /// The useGroupCLIDSetting attribute controls the CLID settings
    /// (clidPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName, allowConfigurableCLIDForRedirectingIdentity)
    /// The useGroupMediaSetting attribute controls the Media settings
    /// (medisPolicySelection, supportedMediaSetName)
    /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
    /// (useMaxSimultaneousCalls, maxSimultaneousCalls,
    /// useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls, maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls, maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth, maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations)
    /// The useGroupTranslationRoutingSetting attribute controls the routing and translation settings
    /// (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
    /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan, overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing)
    /// The following elements are only used in AS data mode:
    /// useGroupDCLIDSetting
    /// enableDialableCallerID
    /// 
    /// Replaced by GroupCallProcessingGetPolicyRequest18
    /// <see cref="GroupCallProcessingGetPolicyResponse17sp4"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupCallProcessingGetPolicyRequest18"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:7741""}]")]
    public class GroupCallProcessingGetPolicyRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7741")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:7741")]
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

    }
}
