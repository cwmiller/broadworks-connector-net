using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The voice portal select distribution list menu keys modify entry.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SelectDistributionListMenuKeysModifyEntry 
    {

        
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
        
        private string _repeatMenuOrFinishEnteringDistributionListNumber;

        [XmlElement(ElementName = "repeatMenuOrFinishEnteringDistributionListNumber", IsNullable = true, Namespace = "")]
        public string RepeatMenuOrFinishEnteringDistributionListNumber {
            get => _repeatMenuOrFinishEnteringDistributionListNumber;
            set {
                RepeatMenuOrFinishEnteringDistributionListNumberSpecified = true;
                _repeatMenuOrFinishEnteringDistributionListNumber = value;
            }
        }

        [XmlIgnore]
        public bool RepeatMenuOrFinishEnteringDistributionListNumberSpecified { get; set; }
        
    }
}
