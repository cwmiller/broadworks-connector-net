using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a Home Network.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemHomeNetworkDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _mscAddress;

        [XmlElement(ElementName = "mscAddress", IsNullable = false, Namespace = "")]
        public string MscAddress {
            get => _mscAddress;
            set {
                MscAddressSpecified = true;
                _mscAddress = value;
            }
        }

        [XmlIgnore]
        public bool MscAddressSpecified { get; set; }
        
    }
}
