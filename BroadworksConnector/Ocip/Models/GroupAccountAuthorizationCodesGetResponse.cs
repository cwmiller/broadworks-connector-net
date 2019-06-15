using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAccountAuthorizationCodesGetRequest.
    /// The tables has the following column headings:
    /// "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name",
    /// "Phone Number", "Extension", "Department", "Email Address".
        /// <see cref="GroupAccountAuthorizationCodesGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupAccountAuthorizationCodesGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.AccountAuthorizationCodeType _type;

        [XmlElement(ElementName = "type", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AccountAuthorizationCodeType Type {
            get => _type;
            set {
                TypeSpecified = true;
                _type = value;
            }
        }

        [XmlIgnore]
        public bool TypeSpecified { get; set; }
        
        private int _numberOfDigits;

        [XmlElement(ElementName = "numberOfDigits", IsNullable = false, Namespace = "")]
        public int NumberOfDigits {
            get => _numberOfDigits;
            set {
                NumberOfDigitsSpecified = true;
                _numberOfDigits = value;
            }
        }

        [XmlIgnore]
        public bool NumberOfDigitsSpecified { get; set; }
        
        private bool _allowLocalAndTollFreeCalls;

        [XmlElement(ElementName = "allowLocalAndTollFreeCalls", IsNullable = false, Namespace = "")]
        public bool AllowLocalAndTollFreeCalls {
            get => _allowLocalAndTollFreeCalls;
            set {
                AllowLocalAndTollFreeCallsSpecified = true;
                _allowLocalAndTollFreeCalls = value;
            }
        }

        [XmlIgnore]
        public bool AllowLocalAndTollFreeCallsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _mandatoryUsageUserTable;

        [XmlElement(ElementName = "mandatoryUsageUserTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable MandatoryUsageUserTable {
            get => _mandatoryUsageUserTable;
            set {
                MandatoryUsageUserTableSpecified = true;
                _mandatoryUsageUserTable = value;
            }
        }

        [XmlIgnore]
        public bool MandatoryUsageUserTableSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _optionalUsageUserTable;

        [XmlElement(ElementName = "optionalUsageUserTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable OptionalUsageUserTable {
            get => _optionalUsageUserTable;
            set {
                OptionalUsageUserTableSpecified = true;
                _optionalUsageUserTable = value;
            }
        }

        [XmlIgnore]
        public bool OptionalUsageUserTableSpecified { get; set; }
        
    }
}
