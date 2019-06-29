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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3f28429898a57a7f7846d3877b22df9f:813""}]")]
    public class UserRouteListModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"3f28429898a57a7f7846d3877b22df9f:813")]
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

        private bool _treatOriginationsAndPBXRedirectionsAsScreened;

        [XmlElement(ElementName = "treatOriginationsAndPBXRedirectionsAsScreened", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3f28429898a57a7f7846d3877b22df9f:813")]
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

        private bool _useRouteListIdentityForNonEmergencyCalls;

        [XmlElement(ElementName = "useRouteListIdentityForNonEmergencyCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3f28429898a57a7f7846d3877b22df9f:813")]
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

        private bool _useRouteListIdentityForEmergencyCalls;

        [XmlElement(ElementName = "useRouteListIdentityForEmergencyCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3f28429898a57a7f7846d3877b22df9f:813")]
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

        private BroadWorksConnector.Ocip.Models.ReplacementDNList _assignedNumberRangeStartList;

        [XmlElement(ElementName = "assignedNumberRangeStartList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3f28429898a57a7f7846d3877b22df9f:813")]
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

        private BroadWorksConnector.Ocip.Models.EnterpriseTrunkReplacementNumberPrefixList _assignedNumberPrefixList;

        [XmlElement(ElementName = "assignedNumberPrefixList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3f28429898a57a7f7846d3877b22df9f:813")]
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
