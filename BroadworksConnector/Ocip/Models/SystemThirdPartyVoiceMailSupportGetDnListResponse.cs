using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemThirdPartyVoiceMailSupportGetDnListRequest.
    /// Contains a table with a row for each ThirdPartyVoiceMailSupport User DN and column headings:
    /// "Phone Number", "Description"
    /// <see cref="SystemThirdPartyVoiceMailSupportGetDnListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3c311aa5c89c0cf5b46e1cdefd5bc387:157""}]")]
    public class SystemThirdPartyVoiceMailSupportGetDnListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _thirdPartyVoiceMailSupportTable;

        [XmlElement(ElementName = "thirdPartyVoiceMailSupportTable", IsNullable = false, Namespace = "")]
        [Group(@"3c311aa5c89c0cf5b46e1cdefd5bc387:157")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ThirdPartyVoiceMailSupportTable
        {
            get => _thirdPartyVoiceMailSupportTable;
            set
            {
                ThirdPartyVoiceMailSupportTableSpecified = true;
                _thirdPartyVoiceMailSupportTable = value;
            }
        }

        [XmlIgnore]
        protected bool ThirdPartyVoiceMailSupportTableSpecified { get; set; }

    }
}
