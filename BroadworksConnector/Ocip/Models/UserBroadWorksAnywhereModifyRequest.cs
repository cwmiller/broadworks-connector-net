using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the user-level settings for the BroadWorks Anywhere service for a specified user.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f39163d0e42e05c4a1692a62f625df9f:584""}]")]
    public class UserBroadWorksAnywhereModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"f39163d0e42e05c4a1692a62f625df9f:584")]
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

        protected bool _alertAllLocationsForClickToDialCalls;

        [XmlElement(ElementName = "alertAllLocationsForClickToDialCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f39163d0e42e05c4a1692a62f625df9f:584")]
        public bool AlertAllLocationsForClickToDialCalls
        {
            get => _alertAllLocationsForClickToDialCalls;
            set
            {
                AlertAllLocationsForClickToDialCallsSpecified = true;
                _alertAllLocationsForClickToDialCalls = value;
            }
        }

        [XmlIgnore]
        protected bool AlertAllLocationsForClickToDialCallsSpecified { get; set; }

        protected bool _alertAllLocationsForGroupPagingCalls;

        [XmlElement(ElementName = "alertAllLocationsForGroupPagingCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f39163d0e42e05c4a1692a62f625df9f:584")]
        public bool AlertAllLocationsForGroupPagingCalls
        {
            get => _alertAllLocationsForGroupPagingCalls;
            set
            {
                AlertAllLocationsForGroupPagingCallsSpecified = true;
                _alertAllLocationsForGroupPagingCalls = value;
            }
        }

        [XmlIgnore]
        protected bool AlertAllLocationsForGroupPagingCallsSpecified { get; set; }

    }
}
