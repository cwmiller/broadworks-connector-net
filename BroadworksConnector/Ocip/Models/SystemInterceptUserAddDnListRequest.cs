using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add an Intercept User number(s) to the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemInterceptUserAddDnListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private List<BroadWorksConnector.Ocip.Models.InterceptDNListEntry> _interceptDNList;

        [XmlElement(ElementName = "interceptDNList", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.InterceptDNListEntry> InterceptDNList {
            get => _interceptDNList;
            set {
                InterceptDNListSpecified = true;
                _interceptDNList = value;
            }
        }

        [XmlIgnore]
        public bool InterceptDNListSpecified { get; set; }
        
    }
}
