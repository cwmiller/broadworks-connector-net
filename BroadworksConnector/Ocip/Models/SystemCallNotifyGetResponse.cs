using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallNotifyGetRequest.
    /// <see cref="SystemCallNotifyGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ec1be3ca6e990aac87b6fcf39d5e3445:112""}]")]
    public class SystemCallNotifyGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _defaultFromAddress;

        [XmlElement(ElementName = "defaultFromAddress", IsNullable = false, Namespace = "")]
        [Group(@"ec1be3ca6e990aac87b6fcf39d5e3445:112")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DefaultFromAddress
        {
            get => _defaultFromAddress;
            set
            {
                DefaultFromAddressSpecified = true;
                _defaultFromAddress = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultFromAddressSpecified { get; set; }

        protected bool _useShortSubjectLine;

        [XmlElement(ElementName = "useShortSubjectLine", IsNullable = false, Namespace = "")]
        [Group(@"ec1be3ca6e990aac87b6fcf39d5e3445:112")]
        public bool UseShortSubjectLine
        {
            get => _useShortSubjectLine;
            set
            {
                UseShortSubjectLineSpecified = true;
                _useShortSubjectLine = value;
            }
        }

        [XmlIgnore]
        protected bool UseShortSubjectLineSpecified { get; set; }

        protected bool _useDnInMailBody;

        [XmlElement(ElementName = "useDnInMailBody", IsNullable = false, Namespace = "")]
        [Group(@"ec1be3ca6e990aac87b6fcf39d5e3445:112")]
        public bool UseDnInMailBody
        {
            get => _useDnInMailBody;
            set
            {
                UseDnInMailBodySpecified = true;
                _useDnInMailBody = value;
            }
        }

        [XmlIgnore]
        protected bool UseDnInMailBodySpecified { get; set; }

    }
}
