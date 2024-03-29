using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The call center enhanced reporting scheduled report modified inclusions related to the Service Level thresholds
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:7684""}]")]
    public class CallCenterScheduledReportServiceLevelInclusionsModify
    {

        protected bool _includeOverflowTimeTransferedInServiceLevel;

        [XmlElement(ElementName = "includeOverflowTimeTransferedInServiceLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7684")]
        public bool IncludeOverflowTimeTransferedInServiceLevel
        {
            get => _includeOverflowTimeTransferedInServiceLevel;
            set
            {
                IncludeOverflowTimeTransferedInServiceLevelSpecified = true;
                _includeOverflowTimeTransferedInServiceLevel = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeOverflowTimeTransferedInServiceLevelSpecified { get; set; }

        protected bool _includeOtherTransfersInServiceLevel;

        [XmlElement(ElementName = "includeOtherTransfersInServiceLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7684")]
        public bool IncludeOtherTransfersInServiceLevel
        {
            get => _includeOtherTransfersInServiceLevel;
            set
            {
                IncludeOtherTransfersInServiceLevelSpecified = true;
                _includeOtherTransfersInServiceLevel = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeOtherTransfersInServiceLevelSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterReportAbadonedCallsInServiceLevel _abandonedCallsInServiceLevel;

        [XmlElement(ElementName = "abandonedCallsInServiceLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7684")]
        public BroadWorksConnector.Ocip.Models.CallCenterReportAbadonedCallsInServiceLevel AbandonedCallsInServiceLevel
        {
            get => _abandonedCallsInServiceLevel;
            set
            {
                AbandonedCallsInServiceLevelSpecified = true;
                _abandonedCallsInServiceLevel = value;
            }
        }

        [XmlIgnore]
        protected bool AbandonedCallsInServiceLevelSpecified { get; set; }

        protected int? _abandonedCallIntervalSeconds;

        [XmlElement(ElementName = "abandonedCallIntervalSeconds", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:7684")]
        [MinInclusive(1)]
        [MaxInclusive(7200)]
        public int? AbandonedCallIntervalSeconds
        {
            get => _abandonedCallIntervalSeconds;
            set
            {
                AbandonedCallIntervalSecondsSpecified = true;
                _abandonedCallIntervalSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool AbandonedCallIntervalSecondsSpecified { get; set; }

    }
}
