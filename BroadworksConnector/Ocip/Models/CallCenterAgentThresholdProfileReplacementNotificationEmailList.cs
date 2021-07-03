using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// List of email addresses to which the Agent Threshold Profile email is sent. The list replaces a previously configured list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:7344""}]")]
    public class CallCenterAgentThresholdProfileReplacementNotificationEmailList
    {

        private List<string> _emailAddress = new List<string>();

        [XmlElement(ElementName = "emailAddress", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7344")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> EmailAddress
        {
            get => _emailAddress;
            set
            {
                EmailAddressSpecified = true;
                _emailAddress = value;
            }
        }

        [XmlIgnore]
        protected bool EmailAddressSpecified { get; set; }

    }
}
