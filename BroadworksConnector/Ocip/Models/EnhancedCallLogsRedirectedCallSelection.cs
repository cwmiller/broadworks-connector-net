using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Redirected call selection.
    /// When " redirectedCall " is set to true, all call logs with redirected call are returned. When it
    /// set to false, all call logs without redirected call are returned.
    /// The redirected call can be defined by including a subset of Service Invocation Disposition here.
    /// If none included, any call has a ServiceInvocationDisposition value defined in
    /// ServiceInvocationDisposition
    /// is considered as a redirected call.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnhancedCallLogsRedirectedCallSelection 
    {

        
        private bool _redirectedCall;

        [XmlElement(ElementName = "redirectedCall", IsNullable = false, Namespace = "")]
        public bool RedirectedCall {
            get => _redirectedCall;
            set {
                RedirectedCallSpecified = true;
                _redirectedCall = value;
            }
        }

        [XmlIgnore]
        public bool RedirectedCallSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.ServiceInvocationDisposition> _redirectType;

        [XmlElement(ElementName = "redirectType", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.ServiceInvocationDisposition> RedirectType {
            get => _redirectType;
            set {
                RedirectTypeSpecified = true;
                _redirectType = value;
            }
        }

        [XmlIgnore]
        public bool RedirectTypeSpecified { get; set; }
        
    }
}
