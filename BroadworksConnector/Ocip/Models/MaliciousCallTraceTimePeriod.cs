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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""be7f3162f133f8d7fcc75e712b0258e6:213""}]")]
    public class MaliciousCallTraceTimePeriod
    {

        protected string _startDateTime;

        [XmlElement(ElementName = "startDateTime", IsNullable = false, Namespace = "")]
        [Group(@"be7f3162f133f8d7fcc75e712b0258e6:213")]
        public string StartDateTime
        {
            get => _startDateTime;
            set
            {
                StartDateTimeSpecified = true;
                _startDateTime = value;
            }
        }

        [XmlIgnore]
        protected bool StartDateTimeSpecified { get; set; }

        protected string _stopDateTime;

        [XmlElement(ElementName = "stopDateTime", IsNullable = false, Namespace = "")]
        [Group(@"be7f3162f133f8d7fcc75e712b0258e6:213")]
        public string StopDateTime
        {
            get => _stopDateTime;
            set
            {
                StopDateTimeSpecified = true;
                _stopDateTime = value;
            }
        }

        [XmlIgnore]
        protected bool StopDateTimeSpecified { get; set; }

    }
}
