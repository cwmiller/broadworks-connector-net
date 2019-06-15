using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The voice portal hoteling menu keys modify entry.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class HotelingMenuKeysModifyEntry 
    {

        
        private string _checkHostStatus;

        [XmlElement(ElementName = "checkHostStatus", IsNullable = true, Namespace = "")]
        public string CheckHostStatus {
            get => _checkHostStatus;
            set {
                CheckHostStatusSpecified = true;
                _checkHostStatus = value;
            }
        }

        [XmlIgnore]
        public bool CheckHostStatusSpecified { get; set; }
        
        private string _associateWithHost;

        [XmlElement(ElementName = "associateWithHost", IsNullable = true, Namespace = "")]
        public string AssociateWithHost {
            get => _associateWithHost;
            set {
                AssociateWithHostSpecified = true;
                _associateWithHost = value;
            }
        }

        [XmlIgnore]
        public bool AssociateWithHostSpecified { get; set; }
        
        private string _disassociateFromHost;

        [XmlElement(ElementName = "disassociateFromHost", IsNullable = true, Namespace = "")]
        public string DisassociateFromHost {
            get => _disassociateFromHost;
            set {
                DisassociateFromHostSpecified = true;
                _disassociateFromHost = value;
            }
        }

        [XmlIgnore]
        public bool DisassociateFromHostSpecified { get; set; }
        
        private string _disassociateFromRemoteHost;

        [XmlElement(ElementName = "disassociateFromRemoteHost", IsNullable = true, Namespace = "")]
        public string DisassociateFromRemoteHost {
            get => _disassociateFromRemoteHost;
            set {
                DisassociateFromRemoteHostSpecified = true;
                _disassociateFromRemoteHost = value;
            }
        }

        [XmlIgnore]
        public bool DisassociateFromRemoteHostSpecified { get; set; }
        
        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        public string ReturnToPreviousMenu {
            get => _returnToPreviousMenu;
            set {
                ReturnToPreviousMenuSpecified = true;
                _returnToPreviousMenu = value;
            }
        }

        [XmlIgnore]
        public bool ReturnToPreviousMenuSpecified { get; set; }
        
        private string _repeatMenu;

        [XmlElement(ElementName = "repeatMenu", IsNullable = true, Namespace = "")]
        public string RepeatMenu {
            get => _repeatMenu;
            set {
                RepeatMenuSpecified = true;
                _repeatMenu = value;
            }
        }

        [XmlIgnore]
        public bool RepeatMenuSpecified { get; set; }
        
    }
}
