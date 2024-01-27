using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Replace the Receptionist Small Business monitored user list.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c9d445cc2023c0bbcc8118fdbfdbb447:122""}]")]
    public class UserBroadWorksReceptionistSmallBusinessModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"c9d445cc2023c0bbcc8118fdbfdbb447:122")]
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

        protected BroadWorksConnector.Ocip.Models.ReplacementUserIdList _monitoredUserIdList;

        [XmlElement(ElementName = "monitoredUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c9d445cc2023c0bbcc8118fdbfdbb447:122")]
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
