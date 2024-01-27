using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemServiceActivationAccessCodeGetRequest.
    /// Contains Service Activation Access Code system parameters.
    /// <see cref="SystemServiceActivationAccessCodeGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:16201""}]")]
    public class SystemServiceActivationAccessCodeGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:16201")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        protected string _terminatingAccessCode;

        [XmlElement(ElementName = "terminatingAccessCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:16201")]
        [MinLength(1)]
        [MaxLength(80)]
        public string TerminatingAccessCode
        {
            get => _terminatingAccessCode;
            set
            {
                TerminatingAccessCodeSpecified = true;
                _terminatingAccessCode = value;
            }
        }

        [XmlIgnore]
        protected bool TerminatingAccessCodeSpecified { get; set; }

        protected string _redirectingAccessCode;

        [XmlElement(ElementName = "redirectingAccessCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:16201")]
        [MinLength(1)]
        [MaxLength(80)]
        public string RedirectingAccessCode
        {
            get => _redirectingAccessCode;
            set
            {
                RedirectingAccessCodeSpecified = true;
                _redirectingAccessCode = value;
            }
        }

        [XmlIgnore]
        protected bool RedirectingAccessCodeSpecified { get; set; }

        protected string _clickToDialAccessCode;

        [XmlElement(ElementName = "clickToDialAccessCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:16201")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ClickToDialAccessCode
        {
            get => _clickToDialAccessCode;
            set
            {
                ClickToDialAccessCodeSpecified = true;
                _clickToDialAccessCode = value;
            }
        }

        [XmlIgnore]
        protected bool ClickToDialAccessCodeSpecified { get; set; }

    }
}
