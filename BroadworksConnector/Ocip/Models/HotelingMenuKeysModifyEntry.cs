using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The voice portal hoteling menu keys modify entry.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:2676""}]")]
    public class HotelingMenuKeysModifyEntry
    {

        private string _checkHostStatus;

        [XmlElement(ElementName = "checkHostStatus", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2676")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string CheckHostStatus
        {
            get => _checkHostStatus;
            set
            {
                CheckHostStatusSpecified = true;
                _checkHostStatus = value;
            }
        }

        [XmlIgnore]
        protected bool CheckHostStatusSpecified { get; set; }

        private string _associateWithHost;

        [XmlElement(ElementName = "associateWithHost", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2676")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string AssociateWithHost
        {
            get => _associateWithHost;
            set
            {
                AssociateWithHostSpecified = true;
                _associateWithHost = value;
            }
        }

        [XmlIgnore]
        protected bool AssociateWithHostSpecified { get; set; }

        private string _disassociateFromHost;

        [XmlElement(ElementName = "disassociateFromHost", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2676")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string DisassociateFromHost
        {
            get => _disassociateFromHost;
            set
            {
                DisassociateFromHostSpecified = true;
                _disassociateFromHost = value;
            }
        }

        [XmlIgnore]
        protected bool DisassociateFromHostSpecified { get; set; }

        private string _disassociateFromRemoteHost;

        [XmlElement(ElementName = "disassociateFromRemoteHost", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2676")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string DisassociateFromRemoteHost
        {
            get => _disassociateFromRemoteHost;
            set
            {
                DisassociateFromRemoteHostSpecified = true;
                _disassociateFromRemoteHost = value;
            }
        }

        [XmlIgnore]
        protected bool DisassociateFromRemoteHostSpecified { get; set; }

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2676")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ReturnToPreviousMenu
        {
            get => _returnToPreviousMenu;
            set
            {
                ReturnToPreviousMenuSpecified = true;
                _returnToPreviousMenu = value;
            }
        }

        [XmlIgnore]
        protected bool ReturnToPreviousMenuSpecified { get; set; }

        private string _repeatMenu;

        [XmlElement(ElementName = "repeatMenu", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2676")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string RepeatMenu
        {
            get => _repeatMenu;
            set
            {
                RepeatMenuSpecified = true;
                _repeatMenu = value;
            }
        }

        [XmlIgnore]
        protected bool RepeatMenuSpecified { get; set; }

    }
}
