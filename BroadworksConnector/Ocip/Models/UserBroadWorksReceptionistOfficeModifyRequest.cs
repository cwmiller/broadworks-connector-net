using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Replace the Receptionist Office monitored user list.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4085b673b5035cde8e8ce380d60d6aed:119""}]")]
    public class UserBroadWorksReceptionistOfficeModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"4085b673b5035cde8e8ce380d60d6aed:119")]
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

        private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _monitoredUserIdList;

        [XmlElement(ElementName = "monitoredUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4085b673b5035cde8e8ce380d60d6aed:119")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList MonitoredUserIdList
        {
            get => _monitoredUserIdList;
            set
            {
                MonitoredUserIdListSpecified = true;
                _monitoredUserIdList = value;
            }
        }

        [XmlIgnore]
        protected bool MonitoredUserIdListSpecified { get; set; }

    }
}
