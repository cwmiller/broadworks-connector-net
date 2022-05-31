using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Clear a user's call logs associated with Basic Call Logs and Enhanced
    /// Call Logs features. The calls logs are deleted from both Basic Call Logs
    /// and Enhanced Call Logs if both features are assigned.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:863"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:865""}]}]")]
    public class UserCallLogsClearRequest14sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:863")]
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

        protected bool _deleteAllCallLogs;

        [XmlElement(ElementName = "deleteAllCallLogs", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:865")]
        public bool DeleteAllCallLogs
        {
            get => _deleteAllCallLogs;
            set
            {
                DeleteAllCallLogsSpecified = true;
                _deleteAllCallLogs = value;
            }
        }

        [XmlIgnore]
        protected bool DeleteAllCallLogsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.UserCallLogsClearRequest14sp4DeleteSpecifiedCallLogs _deleteSpecifiedCallLogs;

        [XmlElement(ElementName = "deleteSpecifiedCallLogs", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:865")]
        public BroadWorksConnector.Ocip.Models.UserCallLogsClearRequest14sp4DeleteSpecifiedCallLogs DeleteSpecifiedCallLogs
        {
            get => _deleteSpecifiedCallLogs;
            set
            {
                DeleteSpecifiedCallLogsSpecified = true;
                _deleteSpecifiedCallLogs = value;
            }
        }

        [XmlIgnore]
        protected bool DeleteSpecifiedCallLogsSpecified { get; set; }

    }
}
