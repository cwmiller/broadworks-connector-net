using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the ServiceProviderSessionAdmissionControlGetRequest.
    /// The response contains the session admission control capacity allocated for the service provider.
    /// <see cref="ServiceProviderSessionAdmissionControlGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:5823""}]")]
    public class ServiceProviderSessionAdmissionControlGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _restrictAggregateSessions;

        [XmlElement(ElementName = "restrictAggregateSessions", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5823")]
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
        public bool RestrictAggregateSessionsSpecified { get; set; }

        private int _maxSessions;

        [XmlElement(ElementName = "maxSessions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5823")]
        [MinInclusive(0)]
        public int MaxSessions
        {
            get => _maxSessions;
            set
            {
                MaxSessionsSpecified = true;
                _maxSessions = value;
            }
        }

        [XmlIgnore]
        public bool MaxSessionsSpecified { get; set; }

        private int _maxUserOriginatingSessions;

        [XmlElement(ElementName = "maxUserOriginatingSessions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5823")]
        [MinInclusive(0)]
        public int MaxUserOriginatingSessions
        {
            get => _maxUserOriginatingSessions;
            set
            {
                MaxUserOriginatingSessionsSpecified = true;
                _maxUserOriginatingSessions = value;
            }
        }

        [XmlIgnore]
        public bool MaxUserOriginatingSessionsSpecified { get; set; }

        private int _maxUserTerminatingSessions;

        [XmlElement(ElementName = "maxUserTerminatingSessions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5823")]
        [MinInclusive(0)]
        public int MaxUserTerminatingSessions
        {
            get => _maxUserTerminatingSessions;
            set
            {
                MaxUserTerminatingSessionsSpecified = true;
                _maxUserTerminatingSessions = value;
            }
        }

        [XmlIgnore]
        public bool MaxUserTerminatingSessionsSpecified { get; set; }

        private bool _countIntraServiceProviderSessions;

        [XmlElement(ElementName = "countIntraServiceProviderSessions", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:5823")]
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
        public bool CountIntraServiceProviderSessionsSpecified { get; set; }

    }
}
