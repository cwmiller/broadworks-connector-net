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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:14843""}]")]
    public class SystemServiceActivationAccessCodeGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14843")]
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
        public bool IsActiveSpecified { get; set; }

        private string _terminatingAccessCode;

        [XmlElement(ElementName = "terminatingAccessCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14843")]
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
        public bool TerminatingAccessCodeSpecified { get; set; }

        private string _redirectingAccessCode;

        [XmlElement(ElementName = "redirectingAccessCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14843")]
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
        public bool RedirectingAccessCodeSpecified { get; set; }

        private string _clickToDialAccessCode;

        [XmlElement(ElementName = "clickToDialAccessCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:14843")]
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
        public bool ClickToDialAccessCodeSpecified { get; set; }

    }
}
