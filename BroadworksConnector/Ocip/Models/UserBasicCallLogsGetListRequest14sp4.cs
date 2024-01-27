using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request user's call logs.
    /// If the callLogType is not specified, all types of calls are returned.
    /// The response is either a UserBasicCallLogsGetListResponse14sp4 or an ErrorResponse.
    /// <see cref="UserBasicCallLogsGetListResponse14sp4"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""cc2c4e50d2e0f1ccbe7f5a9642204822:41""}]")]
    public class UserBasicCallLogsGetListRequest14sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserBasicCallLogsGetListResponse14sp4>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"cc2c4e50d2e0f1ccbe7f5a9642204822:41")]
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

        protected BroadWorksConnector.Ocip.Models.CallLogsType _callLogType;

        [XmlElement(ElementName = "callLogType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"cc2c4e50d2e0f1ccbe7f5a9642204822:41")]
        public BroadWorksConnector.Ocip.Models.CallLogsType CallLogType
        {
            get => _callLogType;
            set
            {
                CallLogTypeSpecified = true;
                _callLogType = value;
            }
        }

        [XmlIgnore]
        protected bool CallLogTypeSpecified { get; set; }

        protected bool _formatNameAndNumber;

        [XmlElement(ElementName = "formatNameAndNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"cc2c4e50d2e0f1ccbe7f5a9642204822:41")]
        public bool FormatNameAndNumber
        {
            get => _formatNameAndNumber;
            set
            {
                FormatNameAndNumberSpecified = true;
                _formatNameAndNumber = value;
            }
        }

        [XmlIgnore]
        protected bool FormatNameAndNumberSpecified { get; set; }

    }
}
