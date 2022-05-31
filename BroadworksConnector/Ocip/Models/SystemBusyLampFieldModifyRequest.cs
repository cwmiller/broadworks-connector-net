using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with the Busy Lamp Field
    /// Service. The response is either a SuccessResponse or an
    /// ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode:
    /// forceUseOfTCP
    /// 
    /// The following elements are only used in AS data mode and ignored in Amplify and XS data mode:
    /// enableRedundancy
    /// redundancyTaskDelayMilliseconds
    /// redundancyTaskIntervalMilliseconds
    /// maxNumberOfSubscriptionsPerRedundancyTaskInterval
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// ignoreUnansweredTerminatingCalls
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4faeca417998d23ce2ff6b0b43212aa6:102""}]")]
    public class SystemBusyLampFieldModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _displayLocalUserIdentityLastNameFirst;

        [XmlElement(ElementName = "displayLocalUserIdentityLastNameFirst", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4faeca417998d23ce2ff6b0b43212aa6:102")]
        public bool DisplayLocalUserIdentityLastNameFirst
        {
            get => _displayLocalUserIdentityLastNameFirst;
            set
            {
                DisplayLocalUserIdentityLastNameFirstSpecified = true;
                _displayLocalUserIdentityLastNameFirst = value;
            }
        }

        [XmlIgnore]
        protected bool DisplayLocalUserIdentityLastNameFirstSpecified { get; set; }

        protected bool _forceUseOfTCP;

        [XmlElement(ElementName = "forceUseOfTCP", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4faeca417998d23ce2ff6b0b43212aa6:102")]
        public bool ForceUseOfTCP
        {
            get => _forceUseOfTCP;
            set
            {
                ForceUseOfTCPSpecified = true;
                _forceUseOfTCP = value;
            }
        }

        [XmlIgnore]
        protected bool ForceUseOfTCPSpecified { get; set; }

        protected bool _enableRedundancy;

        [XmlElement(ElementName = "enableRedundancy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4faeca417998d23ce2ff6b0b43212aa6:102")]
        public bool EnableRedundancy
        {
            get => _enableRedundancy;
            set
            {
                EnableRedundancySpecified = true;
                _enableRedundancy = value;
            }
        }

        [XmlIgnore]
        protected bool EnableRedundancySpecified { get; set; }

        protected int _redundancyTaskDelayMilliseconds;

        [XmlElement(ElementName = "redundancyTaskDelayMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4faeca417998d23ce2ff6b0b43212aa6:102")]
        [MinInclusive(10000)]
        [MaxInclusive(180000)]
        public int RedundancyTaskDelayMilliseconds
        {
            get => _redundancyTaskDelayMilliseconds;
            set
            {
                RedundancyTaskDelayMillisecondsSpecified = true;
                _redundancyTaskDelayMilliseconds = value;
            }
        }

        [XmlIgnore]
        protected bool RedundancyTaskDelayMillisecondsSpecified { get; set; }

        protected int _redundancyTaskIntervalMilliseconds;

        [XmlElement(ElementName = "redundancyTaskIntervalMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4faeca417998d23ce2ff6b0b43212aa6:102")]
        [MinInclusive(50)]
        [MaxInclusive(20000)]
        public int RedundancyTaskIntervalMilliseconds
        {
            get => _redundancyTaskIntervalMilliseconds;
            set
            {
                RedundancyTaskIntervalMillisecondsSpecified = true;
                _redundancyTaskIntervalMilliseconds = value;
            }
        }

        [XmlIgnore]
        protected bool RedundancyTaskIntervalMillisecondsSpecified { get; set; }

        protected int _maxNumberOfSubscriptionsPerRedundancyTaskInterval;

        [XmlElement(ElementName = "maxNumberOfSubscriptionsPerRedundancyTaskInterval", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4faeca417998d23ce2ff6b0b43212aa6:102")]
        [MinInclusive(1)]
        [MaxInclusive(50000)]
        public int MaxNumberOfSubscriptionsPerRedundancyTaskInterval
        {
            get => _maxNumberOfSubscriptionsPerRedundancyTaskInterval;
            set
            {
                MaxNumberOfSubscriptionsPerRedundancyTaskIntervalSpecified = true;
                _maxNumberOfSubscriptionsPerRedundancyTaskInterval = value;
            }
        }

        [XmlIgnore]
        protected bool MaxNumberOfSubscriptionsPerRedundancyTaskIntervalSpecified { get; set; }

        protected bool _ignoreUnansweredTerminatingCalls;

        [XmlElement(ElementName = "ignoreUnansweredTerminatingCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4faeca417998d23ce2ff6b0b43212aa6:102")]
        public bool IgnoreUnansweredTerminatingCalls
        {
            get => _ignoreUnansweredTerminatingCalls;
            set
            {
                IgnoreUnansweredTerminatingCallsSpecified = true;
                _ignoreUnansweredTerminatingCalls = value;
            }
        }

        [XmlIgnore]
        protected bool IgnoreUnansweredTerminatingCallsSpecified { get; set; }

    }
}
