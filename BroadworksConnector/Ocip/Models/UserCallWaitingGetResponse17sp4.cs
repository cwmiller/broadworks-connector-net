using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallWaitingGetRequest17sp4.
    /// 
    /// The following elements are only used in AS data mode:
    /// disableCallingLineIdDelivery
        /// <see cref="UserCallWaitingGetRequest17sp4"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallWaitingGetResponse17sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        public bool IsActive {
            get => _isActive;
            set {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }
        
        private bool _disableCallingLineIdDelivery;

        [XmlElement(ElementName = "disableCallingLineIdDelivery", IsNullable = false, Namespace = "")]
        public bool DisableCallingLineIdDelivery {
            get => _disableCallingLineIdDelivery;
            set {
                DisableCallingLineIdDeliverySpecified = true;
                _disableCallingLineIdDelivery = value;
            }
        }

        [XmlIgnore]
        public bool DisableCallingLineIdDeliverySpecified { get; set; }
        
    }
}
