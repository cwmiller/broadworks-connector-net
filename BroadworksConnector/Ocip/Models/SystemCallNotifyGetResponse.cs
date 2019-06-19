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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""26f62134ab1693f4bdddc7c70b20d2eb:112""}]")]
    public class SystemCallNotifyGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _defaultFromAddress;

        [XmlElement(ElementName = "defaultFromAddress", IsNullable = false, Namespace = "")]
        [Group(@"26f62134ab1693f4bdddc7c70b20d2eb:112")]
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
        public bool DefaultFromAddressSpecified { get; set; }

        private bool _useShortSubjectLine;

        [XmlElement(ElementName = "useShortSubjectLine", IsNullable = false, Namespace = "")]
        [Group(@"26f62134ab1693f4bdddc7c70b20d2eb:112")]
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
        public bool UseShortSubjectLineSpecified { get; set; }

        private bool _useDnInMailBody;

        [XmlElement(ElementName = "useDnInMailBody", IsNullable = false, Namespace = "")]
        [Group(@"26f62134ab1693f4bdddc7c70b20d2eb:112")]
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
        public bool UseDnInMailBodySpecified { get; set; }

    }
}
