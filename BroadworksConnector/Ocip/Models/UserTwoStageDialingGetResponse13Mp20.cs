using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserTwoStageDialingGetRequest13Mp20.
        /// <see cref="UserTwoStageDialingGetRequest13Mp20"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserTwoStageDialingGetResponse13Mp20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
        
        private bool _allowActivationWithUserAddresses;

        [XmlElement(ElementName = "allowActivationWithUserAddresses", IsNullable = false, Namespace = "")]
        public bool AllowActivationWithUserAddresses {
            get => _allowActivationWithUserAddresses;
            set {
                AllowActivationWithUserAddressesSpecified = true;
                _allowActivationWithUserAddresses = value;
            }
        }

        [XmlIgnore]
        public bool AllowActivationWithUserAddressesSpecified { get; set; }
        
    }
}
