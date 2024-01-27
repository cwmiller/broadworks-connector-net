using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// CommPilot Express Email Notify configuration used in the context of a modify.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de7795e1833d459a7eb89116d772fd78:189""}]")]
    public class CommPilotExpressEmailNotifyModify
    {

        protected bool _sendEmail;

        [XmlElement(ElementName = "sendEmail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de7795e1833d459a7eb89116d772fd78:189")]
        public bool SendEmail
        {
            get => _sendEmail;
            set
            {
                SendEmailSpecified = true;
                _sendEmail = value;
            }
        }

        [XmlIgnore]
        protected bool SendEmailSpecified { get; set; }

        protected string _emailAddress;

        [XmlElement(ElementName = "emailAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"de7795e1833d459a7eb89116d772fd78:189")]
        [MinLength(1)]
        [MaxLength(80)]
        public string EmailAddress
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
