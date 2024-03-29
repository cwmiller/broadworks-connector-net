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
    /// The response is either a UserBasicCallLogsGetListResponse or an ErrorResponse.
    /// Replaced By: UserBasicCallLogsGetListRequest14sp4
    /// <see cref="UserBasicCallLogsGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserBasicCallLogsGetListRequest14sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:40283""}]")]
    public class UserBasicCallLogsGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserBasicCallLogsGetListResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:40283")]
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

        protected BroadWorksConnector.Ocip.Models.BasicCallLogsType _callLogType;

        [XmlElement(ElementName = "callLogType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:40283")]
        public BroadWorksConnector.Ocip.Models.BasicCallLogsType CallLogType
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

    }
}
