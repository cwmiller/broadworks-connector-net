using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request user's call logs.
    /// If the callLogType is not specified, all types of calls logs (placed, received, missed) are returned.
    /// The filters "dateTimeRange", "numberFilter", "redirectedNumberFilter", "accountAuthorizationCodeFilter"
    /// "callAuthorizationCodeFilter" and "subscriberType" are ignored if call logs are stored in CDS. When
    /// "ReceivedOrMissed" is specified as "callLogType" and call logs are stored in CDS, all call logs including
    /// placed will be returned.
    /// It is possible to restrict the number of rows returned using responsePagingControl. If responsePagingControl
    /// is not specified, the value of Enhanced Call Logs system parameter maxNonPagedResponseSize will control
    /// the maximum number of call logs can be returned.
    /// The response is either a UserEnhancedCallLogsGetListResponse23 or an ErrorResponse.
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// callAuthorizationCodeFilter
    /// <see cref="maxNonPagedResponseS"/>
    /// <see cref="UserEnhancedCallLogsGetListResponse23"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1b5ee40628a3f2b1bcab94a53dec91e7:330""}]")]
    public class UserEnhancedCallLogsGetListRequest23 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse23>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"1b5ee40628a3f2b1bcab94a53dec91e7:330")]
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

        protected BroadWorksConnector.Ocip.Models.EnhancedCallLogsCallLogsRequestType _callLogType;

        [XmlElement(ElementName = "callLogType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1b5ee40628a3f2b1bcab94a53dec91e7:330")]
        public BroadWorksConnector.Ocip.Models.EnhancedCallLogsCallLogsRequestType CallLogType
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

        protected BroadWorksConnector.Ocip.Models.EnhancedCallLogsTimeRange _dateTimeRange;

        [XmlElement(ElementName = "dateTimeRange", IsNullable = false, Namespace = "")]
        [Group(@"1b5ee40628a3f2b1bcab94a53dec91e7:330")]
        public BroadWorksConnector.Ocip.Models.EnhancedCallLogsTimeRange DateTimeRange
        {
            get => _dateTimeRange;
            set
            {
                DateTimeRangeSpecified = true;
                _dateTimeRange = value;
            }
        }

        [XmlIgnore]
        protected bool DateTimeRangeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EnhancedCallLogsNumberFilter _numberFilter;

        [XmlElement(ElementName = "numberFilter", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1b5ee40628a3f2b1bcab94a53dec91e7:330")]
        public BroadWorksConnector.Ocip.Models.EnhancedCallLogsNumberFilter NumberFilter
        {
            get => _numberFilter;
            set
            {
                NumberFilterSpecified = true;
                _numberFilter = value;
            }
        }

        [XmlIgnore]
        protected bool NumberFilterSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EnhancedCallLogsRedirectedNumberFilter23 _redirectedNumberFilter;

        [XmlElement(ElementName = "redirectedNumberFilter", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1b5ee40628a3f2b1bcab94a53dec91e7:330")]
        public BroadWorksConnector.Ocip.Models.EnhancedCallLogsRedirectedNumberFilter23 RedirectedNumberFilter
        {
            get => _redirectedNumberFilter;
            set
            {
                RedirectedNumberFilterSpecified = true;
                _redirectedNumberFilter = value;
            }
        }

        [XmlIgnore]
        protected bool RedirectedNumberFilterSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EnhancedCallLogsAccountAuthorizationCodeFilter _accountAuthorizationCodeFilter;

        [XmlElement(ElementName = "accountAuthorizationCodeFilter", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1b5ee40628a3f2b1bcab94a53dec91e7:330")]
        public BroadWorksConnector.Ocip.Models.EnhancedCallLogsAccountAuthorizationCodeFilter AccountAuthorizationCodeFilter
        {
            get => _accountAuthorizationCodeFilter;
            set
            {
                AccountAuthorizationCodeFilterSpecified = true;
                _accountAuthorizationCodeFilter = value;
            }
        }

        [XmlIgnore]
        protected bool AccountAuthorizationCodeFilterSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EnhancedCallLogsCallAuthorizationCodeFilter _callAuthorizationCodeFilter;

        [XmlElement(ElementName = "callAuthorizationCodeFilter", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1b5ee40628a3f2b1bcab94a53dec91e7:330")]
        public BroadWorksConnector.Ocip.Models.EnhancedCallLogsCallAuthorizationCodeFilter CallAuthorizationCodeFilter
        {
            get => _callAuthorizationCodeFilter;
            set
            {
                CallAuthorizationCodeFilterSpecified = true;
                _callAuthorizationCodeFilter = value;
            }
        }

        [XmlIgnore]
        protected bool CallAuthorizationCodeFilterSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EnhancedCallLogsSubscriberType20 _subscriberType;

        [XmlElement(ElementName = "subscriberType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1b5ee40628a3f2b1bcab94a53dec91e7:330")]
        public BroadWorksConnector.Ocip.Models.EnhancedCallLogsSubscriberType20 SubscriberType
        {
            get => _subscriberType;
            set
            {
                SubscriberTypeSpecified = true;
                _subscriberType = value;
            }
        }

        [XmlIgnore]
        protected bool SubscriberTypeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1b5ee40628a3f2b1bcab94a53dec91e7:330")]
        public BroadWorksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl
        {
            get => _responsePagingControl;
            set
            {
                ResponsePagingControlSpecified = true;
                _responsePagingControl = value;
            }
        }

        [XmlIgnore]
        protected bool ResponsePagingControlSpecified { get; set; }

    }
}
