using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallingPartyCategoryGetRequest.
    /// Contains information of a Calling Party Category defined in system.
    /// <see cref="SystemCallingPartyCategoryGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""89aa8c9a341a3cccb2453b1ee467bf94:136""}]")]
    public class SystemCallingPartyCategoryGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _cpcValue;

        [XmlElement(ElementName = "cpcValue", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"89aa8c9a341a3cccb2453b1ee467bf94:136")]
        [MinLength(1)]
        [MaxLength(20)]
        public string CpcValue
        {
            get => _cpcValue;
            set
            {
                CpcValueSpecified = true;
                _cpcValue = value;
            }
        }

        [XmlIgnore]
        protected bool CpcValueSpecified { get; set; }

        protected int _isupOliValue;

        [XmlElement(ElementName = "isupOliValue", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"89aa8c9a341a3cccb2453b1ee467bf94:136")]
        [MinInclusive(0)]
        [MaxInclusive(255)]
        public int IsupOliValue
        {
            get => _isupOliValue;
            set
            {
                IsupOliValueSpecified = true;
                _isupOliValue = value;
            }
        }

        [XmlIgnore]
        protected bool IsupOliValueSpecified { get; set; }

        protected string _gtdOliValue;

        [XmlElement(ElementName = "gtdOliValue", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"89aa8c9a341a3cccb2453b1ee467bf94:136")]
        [MinLength(1)]
        [MaxLength(3)]
        public string GtdOliValue
        {
            get => _gtdOliValue;
            set
            {
                GtdOliValueSpecified = true;
                _gtdOliValue = value;
            }
        }

        [XmlIgnore]
        protected bool GtdOliValueSpecified { get; set; }

        protected bool _userCategory;

        [XmlElement(ElementName = "userCategory", IsNullable = false, Namespace = "")]
        [Group(@"89aa8c9a341a3cccb2453b1ee467bf94:136")]
        public bool UserCategory
        {
            get => _userCategory;
            set
            {
                UserCategorySpecified = true;
                _userCategory = value;
            }
        }

        [XmlIgnore]
        protected bool UserCategorySpecified { get; set; }

        protected bool _payPhone;

        [XmlElement(ElementName = "payPhone", IsNullable = false, Namespace = "")]
        [Group(@"89aa8c9a341a3cccb2453b1ee467bf94:136")]
        public bool PayPhone
        {
            get => _payPhone;
            set
            {
                PayPhoneSpecified = true;
                _payPhone = value;
            }
        }

        [XmlIgnore]
        protected bool PayPhoneSpecified { get; set; }

        protected bool _operator;

        [XmlElement(ElementName = "operator", IsNullable = false, Namespace = "")]
        [Group(@"89aa8c9a341a3cccb2453b1ee467bf94:136")]
        public bool Operator
        {
            get => _operator;
            set
            {
                OperatorSpecified = true;
                _operator = value;
            }
        }

        [XmlIgnore]
        protected bool OperatorSpecified { get; set; }

        protected bool _default;

        [XmlElement(ElementName = "default", IsNullable = false, Namespace = "")]
        [Group(@"89aa8c9a341a3cccb2453b1ee467bf94:136")]
        public bool Default
        {
            get => _default;
            set
            {
                DefaultSpecified = true;
                _default = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultSpecified { get; set; }

        protected bool _collectCall;

        [XmlElement(ElementName = "collectCall", IsNullable = false, Namespace = "")]
        [Group(@"89aa8c9a341a3cccb2453b1ee467bf94:136")]
        public bool CollectCall
        {
            get => _collectCall;
            set
            {
                CollectCallSpecified = true;
                _collectCall = value;
            }
        }

        [XmlIgnore]
        protected bool CollectCallSpecified { get; set; }

        protected string _webDisplayKey;

        [XmlElement(ElementName = "webDisplayKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"89aa8c9a341a3cccb2453b1ee467bf94:136")]
        [MinLength(1)]
        [MaxLength(40)]
        public string WebDisplayKey
        {
            get => _webDisplayKey;
            set
            {
                WebDisplayKeySpecified = true;
                _webDisplayKey = value;
            }
        }

        [XmlIgnore]
        protected bool WebDisplayKeySpecified { get; set; }

    }
}
