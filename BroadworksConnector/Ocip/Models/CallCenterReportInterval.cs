using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Report interval for call center enhanced reporting scheduled reports.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:7452""}]")]
    public class CallCenterReportInterval
    {

        protected BroadWorksConnector.Ocip.Models.CallCenterReportIntervalDates _dates;

        [XmlElement(ElementName = "dates", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7452")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportIntervalDates Dates
        {
            get => _dates;
            set
            {
                DatesSpecified = true;
                _dates = value;
            }
        }

        [XmlIgnore]
        protected bool DatesSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterReportCurrentInterval _current;

        [XmlElement(ElementName = "current", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7452")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportCurrentInterval Current
        {
            get => _current;
            set
            {
                CurrentSpecified = true;
                _current = value;
            }
        }

        [XmlIgnore]
        protected bool CurrentSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterReportPastInterval _past;

        [XmlElement(ElementName = "past", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7452")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportPastInterval Past
        {
            get => _past;
            set
            {
                PastSpecified = true;
                _past = value;
            }
        }

        [XmlIgnore]
        protected bool PastSpecified { get; set; }

    }
}
