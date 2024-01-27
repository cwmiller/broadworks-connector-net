using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Executive assistant Opt-in status with executive.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d531efc7ebfdf83cc344962728505dd5:104""}]")]
    public class ExecutiveAssistantOptInStatus
    {

        protected string _executiveUserId;

        [XmlElement(ElementName = "executiveUserId", IsNullable = false, Namespace = "")]
        [Group(@"d531efc7ebfdf83cc344962728505dd5:104")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ExecutiveUserId
        {
            get => _executiveUserId;
            set
            {
                ExecutiveUserIdSpecified = true;
                _executiveUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ExecutiveUserIdSpecified { get; set; }

        protected bool _optIn;

        [XmlElement(ElementName = "optIn", IsNullable = false, Namespace = "")]
        [Group(@"d531efc7ebfdf83cc344962728505dd5:104")]
        public bool OptIn
        {
            get => _optIn;
            set
            {
                OptInSpecified = true;
                _optIn = value;
            }
        }

        [XmlIgnore]
        protected bool OptInSpecified { get; set; }

    }
}
