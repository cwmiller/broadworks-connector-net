using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a Calling Party Category in system.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallingPartyCategoryModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _category;

        [XmlElement(ElementName = "category", IsNullable = false, Namespace = "")]
        public string Category {
            get => _category;
            set {
                CategorySpecified = true;
                _category = value;
            }
        }

        [XmlIgnore]
        public bool CategorySpecified { get; set; }
        
        private string _cpcValue;

        [XmlElement(ElementName = "cpcValue", IsNullable = true, Namespace = "")]
        public string CpcValue {
            get => _cpcValue;
            set {
                CpcValueSpecified = true;
                _cpcValue = value;
            }
        }

        [XmlIgnore]
        public bool CpcValueSpecified { get; set; }
        
        private int? _isupOliValue;

        [XmlElement(ElementName = "isupOliValue", IsNullable = true, Namespace = "")]
        public int? IsupOliValue {
            get => _isupOliValue;
            set {
                IsupOliValueSpecified = true;
                _isupOliValue = value;
            }
        }

        [XmlIgnore]
        public bool IsupOliValueSpecified { get; set; }
        
        private string _gtdOliValue;

        [XmlElement(ElementName = "gtdOliValue", IsNullable = true, Namespace = "")]
        public string GtdOliValue {
            get => _gtdOliValue;
            set {
                GtdOliValueSpecified = true;
                _gtdOliValue = value;
            }
        }

        [XmlIgnore]
        public bool GtdOliValueSpecified { get; set; }
        
        private bool _userCategory;

        [XmlElement(ElementName = "userCategory", IsNullable = false, Namespace = "")]
        public bool UserCategory {
            get => _userCategory;
            set {
                UserCategorySpecified = true;
                _userCategory = value;
            }
        }

        [XmlIgnore]
        public bool UserCategorySpecified { get; set; }
        
        private bool _payPhone;

        [XmlElement(ElementName = "payPhone", IsNullable = false, Namespace = "")]
        public bool PayPhone {
            get => _payPhone;
            set {
                PayPhoneSpecified = true;
                _payPhone = value;
            }
        }

        [XmlIgnore]
        public bool PayPhoneSpecified { get; set; }
        
        private bool _operator;

        [XmlElement(ElementName = "operator", IsNullable = false, Namespace = "")]
        public bool Operator {
            get => _operator;
            set {
                OperatorSpecified = true;
                _operator = value;
            }
        }

        [XmlIgnore]
        public bool OperatorSpecified { get; set; }
        
        private bool _becomeDefault;

        [XmlElement(ElementName = "becomeDefault", IsNullable = false, Namespace = "")]
        public bool BecomeDefault {
            get => _becomeDefault;
            set {
                BecomeDefaultSpecified = true;
                _becomeDefault = value;
            }
        }

        [XmlIgnore]
        public bool BecomeDefaultSpecified { get; set; }
        
        private bool _collectCall;

        [XmlElement(ElementName = "collectCall", IsNullable = false, Namespace = "")]
        public bool CollectCall {
            get => _collectCall;
            set {
                CollectCallSpecified = true;
                _collectCall = value;
            }
        }

        [XmlIgnore]
        public bool CollectCallSpecified { get; set; }
        
        private string _webDisplayKey;

        [XmlElement(ElementName = "webDisplayKey", IsNullable = true, Namespace = "")]
        public string WebDisplayKey {
            get => _webDisplayKey;
            set {
                WebDisplayKeySpecified = true;
                _webDisplayKey = value;
            }
        }

        [XmlIgnore]
        public bool WebDisplayKeySpecified { get; set; }
        
    }
}
