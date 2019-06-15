using System;
using System.Xml.Serialization;
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
        /// <see cref="SystemBusyLampFieldGetRequest23"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemBusyLampFieldGetResponse23 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _displayLocalUserIdentityLastNameFirst;

        [XmlElement(ElementName = "displayLocalUserIdentityLastNameFirst", IsNullable = false, Namespace = "")]
        public bool DisplayLocalUserIdentityLastNameFirst {
            get => _displayLocalUserIdentityLastNameFirst;
            set {
                DisplayLocalUserIdentityLastNameFirstSpecified = true;
                _displayLocalUserIdentityLastNameFirst = value;
            }
        }

        [XmlIgnore]
        public bool DisplayLocalUserIdentityLastNameFirstSpecified { get; set; }
        
        private bool _forceUseOfTCP;

        [XmlElement(ElementName = "forceUseOfTCP", IsNullable = false, Namespace = "")]
        public bool ForceUseOfTCP {
            get => _forceUseOfTCP;
            set {
                ForceUseOfTCPSpecified = true;
                _forceUseOfTCP = value;
            }
        }

        [XmlIgnore]
        public bool ForceUseOfTCPSpecified { get; set; }
        
        private bool _enableRedundancy;

        [XmlElement(ElementName = "enableRedundancy", IsNullable = false, Namespace = "")]
        public bool EnableRedundancy {
            get => _enableRedundancy;
            set {
                EnableRedundancySpecified = true;
                _enableRedundancy = value;
            }
        }

        [XmlIgnore]
        public bool EnableRedundancySpecified { get; set; }
        
        private int _redundancyTaskDelayMilliseconds;

        [XmlElement(ElementName = "redundancyTaskDelayMilliseconds", IsNullable = false, Namespace = "")]
        public int RedundancyTaskDelayMilliseconds {
            get => _redundancyTaskDelayMilliseconds;
            set {
                RedundancyTaskDelayMillisecondsSpecified = true;
                _redundancyTaskDelayMilliseconds = value;
            }
        }

        [XmlIgnore]
        public bool RedundancyTaskDelayMillisecondsSpecified { get; set; }
        
        private int _redundancyTaskIntervalMilliseconds;

        [XmlElement(ElementName = "redundancyTaskIntervalMilliseconds", IsNullable = false, Namespace = "")]
        public int RedundancyTaskIntervalMilliseconds {
            get => _redundancyTaskIntervalMilliseconds;
            set {
                RedundancyTaskIntervalMillisecondsSpecified = true;
                _redundancyTaskIntervalMilliseconds = value;
            }
        }

        [XmlIgnore]
        public bool RedundancyTaskIntervalMillisecondsSpecified { get; set; }
        
        private int _maxNumberOfSubscriptionsPerRedundancyTaskInterval;

        [XmlElement(ElementName = "maxNumberOfSubscriptionsPerRedundancyTaskInterval", IsNullable = false, Namespace = "")]
        public int MaxNumberOfSubscriptionsPerRedundancyTaskInterval {
            get => _maxNumberOfSubscriptionsPerRedundancyTaskInterval;
            set {
                MaxNumberOfSubscriptionsPerRedundancyTaskIntervalSpecified = true;
                _maxNumberOfSubscriptionsPerRedundancyTaskInterval = value;
            }
        }

        [XmlIgnore]
        public bool MaxNumberOfSubscriptionsPerRedundancyTaskIntervalSpecified { get; set; }
        
    }
}
