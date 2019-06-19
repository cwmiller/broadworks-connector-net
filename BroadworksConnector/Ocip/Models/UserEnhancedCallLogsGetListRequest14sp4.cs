using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request user's call logs. It is possible to get a subset of the total list of calls
    /// by specifying a starting offset and the number of calls to get.
    /// If the callLogType is not specified, all types of calls are returned.
    /// The response is either a UserEnhancedCallLogsGetListResponse14sp4 or an ErrorResponse.
    /// Replaced by:
    /// UserEnhancedCallLogsGetListRequest16
    /// <see cref="UserEnhancedCallLogsGetListResponse14sp4"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserEnhancedCallLogsGetListRequest16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:11307""}]")]
    public class UserEnhancedCallLogsGetListRequest14sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:11307")]
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

        private BroadWorksConnector.Ocip.Models.CallLogsType _callLogType;

        [XmlElement(ElementName = "callLogType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:11307")]
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
        public bool CallLogTypeSpecified { get; set; }

        private int _startingOffset;

        [XmlElement(ElementName = "startingOffset", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:11307")]
        [MinInclusive(0)]
        [MaxInclusive(9999)]
        public int StartingOffset
        {
            get => _startingOffset;
            set
            {
                StartingOffsetSpecified = true;
                _startingOffset = value;
            }
        }

        [XmlIgnore]
        public bool StartingOffsetSpecified { get; set; }

        private int _numCalls;

        [XmlElement(ElementName = "numCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:11307")]
        [MinInclusive(1)]
        [MaxInclusive(10000)]
        public int NumCalls
        {
            get => _numCalls;
            set
            {
                NumCallsSpecified = true;
                _numCalls = value;
            }
        }

        [XmlIgnore]
        public bool NumCallsSpecified { get; set; }

    }
}
