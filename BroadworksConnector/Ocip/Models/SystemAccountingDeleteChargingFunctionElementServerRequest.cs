using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to delete a ChargingFunctionElementServer from the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAccountingDeleteChargingFunctionElementServerRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _address;

        [XmlElement(ElementName = "address", IsNullable = false, Namespace = "")]
        public string Address {
            get => _address;
            set {
                AddressSpecified = true;
                _address = value;
            }
        }

        [XmlIgnore]
        public bool AddressSpecified { get; set; }
        
    }
}
