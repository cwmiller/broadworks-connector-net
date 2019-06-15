using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add one or more prefixes to the list of prefixes to be matched.
    /// Matched prefixes will result in CLID delivery for Korea.
    /// Prefix 00X must be sent using uppercase X.
    /// 
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCLIDDeliveryPrefixAddListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private List<BroadWorksConnector.Ocip.Models.CLIDDeliveryPrefix> _prefix;

        [XmlElement(ElementName = "prefix", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.CLIDDeliveryPrefix> Prefix {
            get => _prefix;
            set {
                PrefixSpecified = true;
                _prefix = value;
            }
        }

        [XmlIgnore]
        public bool PrefixSpecified { get; set; }
        
    }
}
