using System;
using System.Xml.Serialization;
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
    /// The response is either a UserEnhancedCallLogsGetListResponse22 or an ErrorResponse.
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// callAuthorizationCodeFilter
        /// <see cref="maxNonPagedResponseS"/>
        /// <see cref="UserEnhancedCallLogsGetListResponse22"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserEnhancedCallLogsGetListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.EnhancedCallLogsCallLogsRequestType _callLogType;

        [XmlElement(ElementName = "callLogType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.EnhancedCallLogsCallLogsRequestType CallLogType {
            get => _callLogType;
            set {
                CallLogTypeSpecified = true;
                _callLogType = value;
            }
        }

        [XmlIgnore]
        public bool CallLogTypeSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.EnhancedCallLogsTimeRange _dateTimeRange;

        [XmlElement(ElementName = "dateTimeRange", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.EnhancedCallLogsTimeRange DateTimeRange {
            get => _dateTimeRange;
            set {
                DateTimeRangeSpecified = true;
                _dateTimeRange = value;
            }
        }

        [XmlIgnore]
        public bool DateTimeRangeSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.EnhancedCallLogsNumberFilter _numberFilter;

        [XmlElement(ElementName = "numberFilter", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.EnhancedCallLogsNumberFilter NumberFilter {
            get => _numberFilter;
            set {
                NumberFilterSpecified = true;
                _numberFilter = value;
            }
        }

        [XmlIgnore]
        public bool NumberFilterSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.EnhancedCallLogsRedirectedNumberFilter21sp1 _redirectedNumberFilter;

        [XmlElement(ElementName = "redirectedNumberFilter", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.EnhancedCallLogsRedirectedNumberFilter21sp1 RedirectedNumberFilter {
            get => _redirectedNumberFilter;
            set {
                RedirectedNumberFilterSpecified = true;
                _redirectedNumberFilter = value;
            }
        }

        [XmlIgnore]
        public bool RedirectedNumberFilterSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.EnhancedCallLogsAccountAuthorizationCodeFilter _accountAuthorizationCodeFilter;

        [XmlElement(ElementName = "accountAuthorizationCodeFilter", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.EnhancedCallLogsAccountAuthorizationCodeFilter AccountAuthorizationCodeFilter {
            get => _accountAuthorizationCodeFilter;
            set {
                AccountAuthorizationCodeFilterSpecified = true;
                _accountAuthorizationCodeFilter = value;
            }
        }

        [XmlIgnore]
        public bool AccountAuthorizationCodeFilterSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.EnhancedCallLogsCallAuthorizationCodeFilter _callAuthorizationCodeFilter;

        [XmlElement(ElementName = "callAuthorizationCodeFilter", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.EnhancedCallLogsCallAuthorizationCodeFilter CallAuthorizationCodeFilter {
            get => _callAuthorizationCodeFilter;
            set {
                CallAuthorizationCodeFilterSpecified = true;
                _callAuthorizationCodeFilter = value;
            }
        }

        [XmlIgnore]
        public bool CallAuthorizationCodeFilterSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.EnhancedCallLogsSubscriberType20 _subscriberType;

        [XmlElement(ElementName = "subscriberType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.EnhancedCallLogsSubscriberType20 SubscriberType {
            get => _subscriberType;
            set {
                SubscriberTypeSpecified = true;
                _subscriberType = value;
            }
        }

        [XmlIgnore]
        public bool SubscriberTypeSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl {
            get => _responsePagingControl;
            set {
                ResponsePagingControlSpecified = true;
                _responsePagingControl = value;
            }
        }

        [XmlIgnore]
        public bool ResponsePagingControlSpecified { get; set; }
        
    }
}
