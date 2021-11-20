using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user level data associated with Malicious Call Trace.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0da7c658f240cdc10c3f9cb328db57d8:187""}]")]
    public class UserMaliciousCallTraceModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"0da7c658f240cdc10c3f9cb328db57d8:187")]
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

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0da7c658f240cdc10c3f9cb328db57d8:187")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MaliciousCallTraceCallTypeSelection _traceTypeSelection;

        [XmlElement(ElementName = "traceTypeSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0da7c658f240cdc10c3f9cb328db57d8:187")]
        public BroadWorksConnector.Ocip.Models.MaliciousCallTraceCallTypeSelection TraceTypeSelection
        {
            get => _traceTypeSelection;
            set
            {
                TraceTypeSelectionSpecified = true;
                _traceTypeSelection = value;
            }
        }

        [XmlIgnore]
        protected bool TraceTypeSelectionSpecified { get; set; }

        private bool _traceForTimePeriod;

        [XmlElement(ElementName = "traceForTimePeriod", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"0da7c658f240cdc10c3f9cb328db57d8:187")]
        public bool TraceForTimePeriod
        {
            get => _traceForTimePeriod;
            set
            {
                TraceForTimePeriodSpecified = true;
                _traceForTimePeriod = value;
            }
        }

        [XmlIgnore]
        protected bool TraceForTimePeriodSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MaliciousCallTraceTimePeriod _traceTimePeriod;

        [XmlElement(ElementName = "traceTimePeriod", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"0da7c658f240cdc10c3f9cb328db57d8:187")]
        public BroadWorksConnector.Ocip.Models.MaliciousCallTraceTimePeriod TraceTimePeriod
        {
            get => _traceTimePeriod;
            set
            {
                TraceTimePeriodSpecified = true;
                _traceTimePeriod = value;
            }
        }

        [XmlIgnore]
        protected bool TraceTimePeriodSpecified { get; set; }

    }
}
