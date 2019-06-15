using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemGroupNightForwardingGetRequest.
        /// <see cref="SystemGroupNightForwardingGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemGroupNightForwardingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _nightForwardInterGroupCallsWithinEnterprise;

        [XmlElement(ElementName = "nightForwardInterGroupCallsWithinEnterprise", IsNullable = false, Namespace = "")]
        public bool NightForwardInterGroupCallsWithinEnterprise {
            get => _nightForwardInterGroupCallsWithinEnterprise;
            set {
                NightForwardInterGroupCallsWithinEnterpriseSpecified = true;
                _nightForwardInterGroupCallsWithinEnterprise = value;
            }
        }

        [XmlIgnore]
        public bool NightForwardInterGroupCallsWithinEnterpriseSpecified { get; set; }
        
    }
}
