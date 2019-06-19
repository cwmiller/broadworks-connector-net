using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Redirected call selection.
    /// When " redirectedCall " is set to true, all call logs with redirected call are returned. When it
    /// set to false, all call logs without redirected call are returned.
    /// The redirected call can be defined by including a subset of Service Invocation Disposition here.
    /// If none included, any call has a ServiceInvocationDisposition value defined in ServiceInvocationDisposition21sp1
    /// is considered as a redirected call.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f6b3702edb5f67fa12c2c426d98657db:363""}]")]
    public class EnhancedCallLogsRedirectedCallSelection21sp1
    {

        private bool _redirectedCall;

        [XmlElement(ElementName = "redirectedCall", IsNullable = false, Namespace = "")]
        [Group(@"f6b3702edb5f67fa12c2c426d98657db:363")]
        public bool RedirectedCall
        {
            get => _redirectedCall;
            set
            {
                RedirectedCallSpecified = true;
                _redirectedCall = value;
            }
        }

        [XmlIgnore]
        public bool RedirectedCallSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.ServiceInvocationDisposition21sp1> _redirectType = new List<BroadWorksConnector.Ocip.Models.ServiceInvocationDisposition21sp1>();

        [XmlElement(ElementName = "redirectType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f6b3702edb5f67fa12c2c426d98657db:363")]
        public List<BroadWorksConnector.Ocip.Models.ServiceInvocationDisposition21sp1> RedirectType
        {
            get => _redirectType;
            set
            {
                RedirectTypeSpecified = true;
                _redirectType = value;
            }
        }

        [XmlIgnore]
        public bool RedirectTypeSpecified { get; set; }

    }
}
