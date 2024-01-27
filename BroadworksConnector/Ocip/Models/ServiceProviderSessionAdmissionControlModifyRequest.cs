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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:6741""}]")]
    public class ServiceProviderSessionAdmissionControlModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6741")]
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

        protected bool _restrictAggregateSessions;

        [XmlElement(ElementName = "restrictAggregateSessions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6741")]
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

        protected int? _maxSessions;

        [XmlElement(ElementName = "maxSessions", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6741")]
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

        protected int? _maxUserOriginatingSessions;

        [XmlElement(ElementName = "maxUserOriginatingSessions", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6741")]
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

        protected int? _maxUserTerminatingSessions;

        [XmlElement(ElementName = "maxUserTerminatingSessions", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6741")]
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

        protected bool _countIntraServiceProviderSessions;

        [XmlElement(ElementName = "countIntraServiceProviderSessions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:6741")]
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
