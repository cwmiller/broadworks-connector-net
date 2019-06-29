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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:7162""}]")]
    public class UserCallCenterGetSupervisorCallCenterListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _supervisorUserId;

        [XmlElement(ElementName = "supervisorUserId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7162")]
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
