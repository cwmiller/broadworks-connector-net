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
    /// If none included, any call has a ServiceInvocationDisposition value defined in ServiceInvocationDisposition21
    /// is considered as a redirected call.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:48459""}]")]
    public class EnhancedCallLogsRedirectedCallSelection21
    {

        protected bool _redirectedCall;

        [XmlElement(ElementName = "redirectedCall", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48459")]
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
        protected bool RedirectedCallSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.ServiceInvocationDisposition21> _redirectType = new List<BroadWorksConnector.Ocip.Models.ServiceInvocationDisposition21>();

        [XmlElement(ElementName = "redirectType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:48459")]
        public List<BroadWorksConnector.Ocip.Models.ServiceInvocationDisposition21> RedirectType
        {
            get => _redirectType;
            set
            {
                RedirectTypeSpecified = true;
                _redirectType = value;
            }
        }

        [XmlIgnore]
        protected bool RedirectTypeSpecified { get; set; }

    }
}
