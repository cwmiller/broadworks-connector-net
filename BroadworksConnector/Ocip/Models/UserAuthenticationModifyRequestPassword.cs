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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9db4d5fa1bbf70f2626f52a5d6e3420e:80""}]")]
    public class UserAuthenticationModifyRequestPassword
    {

        protected string _old;

        [XmlElement(ElementName = "old", IsNullable = false, Namespace = "")]
        [Group(@"9db4d5fa1bbf70f2626f52a5d6e3420e:80")]
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
        [Group(@"9db4d5fa1bbf70f2626f52a5d6e3420e:80")]
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
