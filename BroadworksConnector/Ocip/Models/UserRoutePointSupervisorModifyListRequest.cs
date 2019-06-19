using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the Route Point supervisor list for a user.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a27224a048c30ff69eab9209dec841cc:1332""}]")]
    public class UserRoutePointSupervisorModifyListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:1332")]
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
        public bool UserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _supervisorUserIdList;

        [XmlElement(ElementName = "supervisorUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:1332")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList SupervisorUserIdList
        {
            get => _supervisorUserIdList;
            set
            {
                SupervisorUserIdListSpecified = true;
                _supervisorUserIdList = value;
            }
        }

        [XmlIgnore]
        public bool SupervisorUserIdListSpecified { get; set; }

    }
}
