using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6e41c53467939072d1190f1f854fdccd:80""}]")]
    public class UserAuthenticationModifyRequestPassword
    {

        protected string _old;

        [XmlElement(ElementName = "old", IsNullable = false, Namespace = "")]
        [Group(@"6e41c53467939072d1190f1f854fdccd:80")]
        [MinLength(1)]
        [MaxLength(60)]
        public string Old
        {
            get => _old;
            set
            {
                OldSpecified = true;
                _old = value;
            }
        }

        [XmlIgnore]
        protected bool OldSpecified { get; set; }

        protected string _new;

        [XmlElement(ElementName = "new", IsNullable = false, Namespace = "")]
        [Group(@"6e41c53467939072d1190f1f854fdccd:80")]
        [MinLength(1)]
        [MaxLength(60)]
        public string New
        {
            get => _new;
            set
            {
                NewSpecified = true;
                _new = value;
            }
        }

        [XmlIgnore]
        protected bool NewSpecified { get; set; }

    }
}
