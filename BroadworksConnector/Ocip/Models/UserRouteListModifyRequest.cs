using System;
using System.Xml.Serialization;
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
     
    public class UserRouteListModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
        private bool _treatOriginationsAndPBXRedirectionsAsScreened;

        [XmlElement(ElementName = "treatOriginationsAndPBXRedirectionsAsScreened", IsNullable = false, Namespace = "")]
        public bool TreatOriginationsAndPBXRedirectionsAsScreened {
            get => _treatOriginationsAndPBXRedirectionsAsScreened;
            set {
                TreatOriginationsAndPBXRedirectionsAsScreenedSpecified = true;
                _treatOriginationsAndPBXRedirectionsAsScreened = value;
            }
        }

        [XmlIgnore]
        public bool TreatOriginationsAndPBXRedirectionsAsScreenedSpecified { get; set; }
        
        private bool _useRouteListIdentityForNonEmergencyCalls;

        [XmlElement(ElementName = "useRouteListIdentityForNonEmergencyCalls", IsNullable = false, Namespace = "")]
        public bool UseRouteListIdentityForNonEmergencyCalls {
            get => _useRouteListIdentityForNonEmergencyCalls;
            set {
                UseRouteListIdentityForNonEmergencyCallsSpecified = true;
                _useRouteListIdentityForNonEmergencyCalls = value;
            }
        }

        [XmlIgnore]
        public bool UseRouteListIdentityForNonEmergencyCallsSpecified { get; set; }
        
        private bool _useRouteListIdentityForEmergencyCalls;

        [XmlElement(ElementName = "useRouteListIdentityForEmergencyCalls", IsNullable = false, Namespace = "")]
        public bool UseRouteListIdentityForEmergencyCalls {
            get => _useRouteListIdentityForEmergencyCalls;
            set {
                UseRouteListIdentityForEmergencyCallsSpecified = true;
                _useRouteListIdentityForEmergencyCalls = value;
            }
        }

        [XmlIgnore]
        public bool UseRouteListIdentityForEmergencyCallsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ReplacementDNList _assignedNumberRangeStartList;

        [XmlElement(ElementName = "assignedNumberRangeStartList", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ReplacementDNList AssignedNumberRangeStartList {
            get => _assignedNumberRangeStartList;
            set {
                AssignedNumberRangeStartListSpecified = true;
                _assignedNumberRangeStartList = value;
            }
        }

        [XmlIgnore]
        public bool AssignedNumberRangeStartListSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.EnterpriseTrunkReplacementNumberPrefixList _assignedNumberPrefixList;

        [XmlElement(ElementName = "assignedNumberPrefixList", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.EnterpriseTrunkReplacementNumberPrefixList AssignedNumberPrefixList {
            get => _assignedNumberPrefixList;
            set {
                AssignedNumberPrefixListSpecified = true;
                _assignedNumberPrefixList = value;
            }
        }

        [XmlIgnore]
        public bool AssignedNumberPrefixListSpecified { get; set; }
        
    }
}
