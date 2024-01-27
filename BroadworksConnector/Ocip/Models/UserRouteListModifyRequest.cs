using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the route list setting and the list of number ranges and number prefixes assigned to a user.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""500f9871ed90b8ab3fbd262883ab503b:858""}]")]
    public class UserRouteListModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:858")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        protected bool _treatOriginationsAndPBXRedirectionsAsScreened;

        [XmlElement(ElementName = "treatOriginationsAndPBXRedirectionsAsScreened", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:858")]
        public bool TreatOriginationsAndPBXRedirectionsAsScreened
        {
            get => _treatOriginationsAndPBXRedirectionsAsScreened;
            set
            {
                TreatOriginationsAndPBXRedirectionsAsScreenedSpecified = true;
                _treatOriginationsAndPBXRedirectionsAsScreened = value;
            }
        }

        [XmlIgnore]
        protected bool TreatOriginationsAndPBXRedirectionsAsScreenedSpecified { get; set; }

        protected bool _useRouteListIdentityForNonEmergencyCalls;

        [XmlElement(ElementName = "useRouteListIdentityForNonEmergencyCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:858")]
        public bool UseRouteListIdentityForNonEmergencyCalls
        {
            get => _useRouteListIdentityForNonEmergencyCalls;
            set
            {
                UseRouteListIdentityForNonEmergencyCallsSpecified = true;
                _useRouteListIdentityForNonEmergencyCalls = value;
            }
        }

        [XmlIgnore]
        protected bool UseRouteListIdentityForNonEmergencyCallsSpecified { get; set; }

        protected bool _useRouteListIdentityForEmergencyCalls;

        [XmlElement(ElementName = "useRouteListIdentityForEmergencyCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:858")]
        public bool UseRouteListIdentityForEmergencyCalls
        {
            get => _useRouteListIdentityForEmergencyCalls;
            set
            {
                UseRouteListIdentityForEmergencyCallsSpecified = true;
                _useRouteListIdentityForEmergencyCalls = value;
            }
        }

        [XmlIgnore]
        protected bool UseRouteListIdentityForEmergencyCallsSpecified { get; set; }

        protected bool _ignoreCallingNameForCallProcessing;

        [XmlElement(ElementName = "ignoreCallingNameForCallProcessing", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:858")]
        public bool IgnoreCallingNameForCallProcessing
        {
            get => _ignoreCallingNameForCallProcessing;
            set
            {
                IgnoreCallingNameForCallProcessingSpecified = true;
                _ignoreCallingNameForCallProcessing = value;
            }
        }

        [XmlIgnore]
        protected bool IgnoreCallingNameForCallProcessingSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementDNList _assignedNumberRangeStartList;

        [XmlElement(ElementName = "assignedNumberRangeStartList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:858")]
        public BroadWorksConnector.Ocip.Models.ReplacementDNList AssignedNumberRangeStartList
        {
            get => _assignedNumberRangeStartList;
            set
            {
                AssignedNumberRangeStartListSpecified = true;
                _assignedNumberRangeStartList = value;
            }
        }

        [XmlIgnore]
        protected bool AssignedNumberRangeStartListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EnterpriseTrunkReplacementNumberPrefixList _assignedNumberPrefixList;

        [XmlElement(ElementName = "assignedNumberPrefixList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"500f9871ed90b8ab3fbd262883ab503b:858")]
        public BroadWorksConnector.Ocip.Models.EnterpriseTrunkReplacementNumberPrefixList AssignedNumberPrefixList
        {
            get => _assignedNumberPrefixList;
            set
            {
                AssignedNumberPrefixListSpecified = true;
                _assignedNumberPrefixList = value;
            }
        }

        [XmlIgnore]
        protected bool AssignedNumberPrefixListSpecified { get; set; }

    }
}
