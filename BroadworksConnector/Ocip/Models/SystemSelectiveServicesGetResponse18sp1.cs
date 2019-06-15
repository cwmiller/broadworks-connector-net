using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSelectiveServicesGetRequest18sp1.
        /// <see cref="SystemSelectiveServicesGetRequest18sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSelectiveServicesGetResponse18sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.ScheduleCombinationType _scheduleCombination;

        [XmlElement(ElementName = "scheduleCombination", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ScheduleCombinationType ScheduleCombination {
            get => _scheduleCombination;
            set {
                ScheduleCombinationSpecified = true;
                _scheduleCombination = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleCombinationSpecified { get; set; }
        
        private bool _screenPrivateNumber;

        [XmlElement(ElementName = "screenPrivateNumber", IsNullable = false, Namespace = "")]
        public bool ScreenPrivateNumber {
            get => _screenPrivateNumber;
            set {
                ScreenPrivateNumberSpecified = true;
                _screenPrivateNumber = value;
            }
        }

        [XmlIgnore]
        public bool ScreenPrivateNumberSpecified { get; set; }
        
    }
}
