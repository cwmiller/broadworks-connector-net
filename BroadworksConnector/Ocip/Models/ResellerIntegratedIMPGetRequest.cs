using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the Integrated IMP service attributes for the reseller.
    /// The response is either ResellerIntegratedIMPGetResponse or ErrorResponse.
    /// 
    /// Replaced by: ResellerIntegratedIMPGetRequest22 in AS data mode
        /// <see cref="ResellerIntegratedIMPGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="ResellerIntegratedIMPGetRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ResellerIntegratedIMPGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        public string ResellerId {
            get => _resellerId;
            set {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        public bool ResellerIdSpecified { get; set; }
        
    }
}
