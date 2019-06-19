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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0da7c658f240cdc10c3f9cb328db57d8:213""}]")]
    public class MaliciousCallTraceTimePeriod
    {

        private string _startDateTime;

        [XmlElement(ElementName = "startDateTime", IsNullable = false, Namespace = "")]
        [Group(@"0da7c658f240cdc10c3f9cb328db57d8:213")]
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
        public bool StartDateTimeSpecified { get; set; }

        private string _stopDateTime;

        [XmlElement(ElementName = "stopDateTime", IsNullable = false, Namespace = "")]
        [Group(@"0da7c658f240cdc10c3f9cb328db57d8:213")]
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
        public bool StopDateTimeSpecified { get; set; }

    }
}
