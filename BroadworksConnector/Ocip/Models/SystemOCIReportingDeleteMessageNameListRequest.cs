using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a list of reported messages from a host in the OCI Reporting
    /// Access Control List. The response is either a SuccessResponse or an
    /// ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:13876"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:13878""}]}]")]
    public class SystemOCIReportingDeleteMessageNameListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _netAddress;

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:13876")]
        [MinLength(1)]
        [MaxLength(80)]
        public string NetAddress
        {
            get => _netAddress;
            set
            {
                NetAddressSpecified = true;
                _netAddress = value;
            }
        }

        [XmlIgnore]
        protected bool NetAddressSpecified { get; set; }

        protected bool _deleteAllMessageNames;

        [XmlElement(ElementName = "deleteAllMessageNames", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:13878")]
        public bool DeleteAllMessageNames
        {
            get => _deleteAllMessageNames;
            set
            {
                DeleteAllMessageNamesSpecified = true;
                _deleteAllMessageNames = value;
            }
        }

        [XmlIgnore]
        protected bool DeleteAllMessageNamesSpecified { get; set; }

        protected List<string> _messageNameStartsWith = new List<string>();

        [XmlElement(ElementName = "messageNameStartsWith", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:13878")]
        [MinLength(1)]
        [MaxLength(256)]
        public List<string> MessageNameStartsWith
        {
            get => _messageNameStartsWith;
            set
            {
                MessageNameStartsWithSpecified = true;
                _messageNameStartsWith = value;
            }
        }

        [XmlIgnore]
        protected bool MessageNameStartsWithSpecified { get; set; }

    }
}
