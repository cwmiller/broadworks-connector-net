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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""be7f3162f133f8d7fcc75e712b0258e6:190""}]")]
    public class UserMaliciousCallTraceModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"be7f3162f133f8d7fcc75e712b0258e6:190")]
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

        protected bool? _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"be7f3162f133f8d7fcc75e712b0258e6:190")]
        public bool? IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = (value != null);
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MaliciousCallTraceCallTypeSelection? _traceTypeSelection;

        [XmlElement(ElementName = "traceTypeSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"be7f3162f133f8d7fcc75e712b0258e6:190")]
        public BroadWorksConnector.Ocip.Models.MaliciousCallTraceCallTypeSelection? TraceTypeSelection
        {
            get => _traceTypeSelection;
            set
            {
                TraceTypeSelectionSpecified = (value != null);
                _traceTypeSelection = value;
            }
        }

        [XmlIgnore]
        protected bool TraceTypeSelectionSpecified { get; set; }

        protected bool? _traceForTimePeriod;

        [XmlElement(ElementName = "traceForTimePeriod", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"be7f3162f133f8d7fcc75e712b0258e6:190")]
        public bool? TraceForTimePeriod
        {
            get => _traceForTimePeriod;
            set
            {
                TraceForTimePeriodSpecified = (value != null);
                _traceForTimePeriod = value;
            }
        }

        [XmlIgnore]
        protected bool TraceForTimePeriodSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MaliciousCallTraceTimePeriod _traceTimePeriod;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "traceTimePeriod", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"be7f3162f133f8d7fcc75e712b0258e6:190")]
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
