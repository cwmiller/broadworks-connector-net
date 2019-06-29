using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify session admission control capacity for the service provider.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:5843""}]")]
    public class ServiceProviderSessionAdmissionControlModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5843")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private bool _restrictAggregateSessions;

        [XmlElement(ElementName = "restrictAggregateSessions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5843")]
        public bool RestrictAggregateSessions
        {
            get => _restrictAggregateSessions;
            set
            {
                RestrictAggregateSessionsSpecified = true;
                _restrictAggregateSessions = value;
            }
        }

        [XmlIgnore]
        protected bool RestrictAggregateSessionsSpecified { get; set; }

        private int? _maxSessions;

        [XmlElement(ElementName = "maxSessions", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5843")]
        [MinInclusive(0)]
        public int? MaxSessions
        {
            get => _maxSessions;
            set
            {
                MaxSessionsSpecified = true;
                _maxSessions = value;
            }
        }

        [XmlIgnore]
        protected bool MaxSessionsSpecified { get; set; }

        private int? _maxUserOriginatingSessions;

        [XmlElement(ElementName = "maxUserOriginatingSessions", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5843")]
        [MinInclusive(0)]
        public int? MaxUserOriginatingSessions
        {
            get => _maxUserOriginatingSessions;
            set
            {
                MaxUserOriginatingSessionsSpecified = true;
                _maxUserOriginatingSessions = value;
            }
        }

        [XmlIgnore]
        protected bool MaxUserOriginatingSessionsSpecified { get; set; }

        private int? _maxUserTerminatingSessions;

        [XmlElement(ElementName = "maxUserTerminatingSessions", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5843")]
        [MinInclusive(0)]
        public int? MaxUserTerminatingSessions
        {
            get => _maxUserTerminatingSessions;
            set
            {
                MaxUserTerminatingSessionsSpecified = true;
                _maxUserTerminatingSessions = value;
            }
        }

        [XmlIgnore]
        protected bool MaxUserTerminatingSessionsSpecified { get; set; }

        private bool _countIntraServiceProviderSessions;

        [XmlElement(ElementName = "countIntraServiceProviderSessions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5843")]
        public bool CountIntraServiceProviderSessions
        {
            get => _countIntraServiceProviderSessions;
            set
            {
                CountIntraServiceProviderSessionsSpecified = true;
                _countIntraServiceProviderSessions = value;
            }
        }

        [XmlIgnore]
        protected bool CountIntraServiceProviderSessionsSpecified { get; set; }

    }
}
