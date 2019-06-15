using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Outgoing Calling Plan transfer numbers.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class OutgoingCallingPlanTransferNumbersModify 
    {

        
        private string _phoneNumber01;

        [XmlElement(ElementName = "phoneNumber01", IsNullable = true, Namespace = "")]
        public string PhoneNumber01 {
            get => _phoneNumber01;
            set {
                PhoneNumber01Specified = true;
                _phoneNumber01 = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumber01Specified { get; set; }
        
        private string _phoneNumber02;

        [XmlElement(ElementName = "phoneNumber02", IsNullable = true, Namespace = "")]
        public string PhoneNumber02 {
            get => _phoneNumber02;
            set {
                PhoneNumber02Specified = true;
                _phoneNumber02 = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumber02Specified { get; set; }
        
        private string _phoneNumber03;

        [XmlElement(ElementName = "phoneNumber03", IsNullable = true, Namespace = "")]
        public string PhoneNumber03 {
            get => _phoneNumber03;
            set {
                PhoneNumber03Specified = true;
                _phoneNumber03 = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumber03Specified { get; set; }
        
    }
}
