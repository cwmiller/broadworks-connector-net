using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Replaced by: SystemRedundancyParametersGetResponse16sp2
    /// 
    /// Response to SystemRedundancyParametersGetRequest.
    /// Contains a list of system Redundancy parameters.
        /// <see cref="SystemRedundancyParametersGetResponse16sp2"/>
        /// <see cref="SystemRedundancyParametersGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemRedundancyParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private int _rollBackTimerMinutes;

        [XmlElement(ElementName = "rollBackTimerMinutes", IsNullable = false, Namespace = "")]
        public int RollBackTimerMinutes {
            get => _rollBackTimerMinutes;
            set {
                RollBackTimerMinutesSpecified = true;
                _rollBackTimerMinutes = value;
            }
        }

        [XmlIgnore]
        public bool RollBackTimerMinutesSpecified { get; set; }
        
    }
}
