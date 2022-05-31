using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemBusyLampFieldGetRequest23.
    /// 
    /// The following elements are only used in AS data mode:
    /// forceUseOfTCP
    /// enableRedundancy, value "false" is returned in XS data mode
    /// redundancyTaskDelayMilliseconds, value "10000" is returned in Amplify and XS data mode
    /// redundancyTaskIntervalMilliseconds, value of "1000" is returned in Amplify and XS data mode
    /// maxNumberOfSubscriptionsPerRedundancyTaskInterval, value of "50" is returned in Amplify and XS data mode
    /// Replaced by: SystemBusyLampFieldGetResponse23V2 in AS data mode.
    /// <see cref="SystemBusyLampFieldGetRequest23"/>
    /// <see cref="SystemBusyLampFieldGetResponse23V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:7030""}]")]
    public class SystemBusyLampFieldGetResponse23 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _displayLocalUserIdentityLastNameFirst;

        [XmlElement(ElementName = "displayLocalUserIdentityLastNameFirst", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:7030")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7030")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7030")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7030")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7030")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:7030")]
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

    }
}
