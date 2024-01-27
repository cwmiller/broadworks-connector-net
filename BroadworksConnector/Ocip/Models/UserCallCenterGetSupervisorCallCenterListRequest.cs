using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of call centers the user is assigned to as a supervisor.
    /// The response is either a UserCallCenterGetSupervisorCallCenterListResponse or an
    /// ErrorResponse.
    /// <see cref="UserCallCenterGetSupervisorCallCenterListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:7177""}]")]
    public class UserCallCenterGetSupervisorCallCenterListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserCallCenterGetSupervisorCallCenterListResponse>
    {

        protected string _supervisorUserId;

        [XmlElement(ElementName = "supervisorUserId", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7177")]
        [MinLength(1)]
        [MaxLength(161)]
        public string SupervisorUserId
        {
            get => _supervisorUserId;
            set
            {
                SupervisorUserIdSpecified = true;
                _supervisorUserId = value;
            }
        }

        [XmlIgnore]
        protected bool SupervisorUserIdSpecified { get; set; }

    }
}
