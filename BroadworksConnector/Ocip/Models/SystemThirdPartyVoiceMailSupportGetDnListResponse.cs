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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""21e97b8199c6e7eff29a84874335b46e:157""}]")]
    public class SystemThirdPartyVoiceMailSupportGetDnListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _thirdPartyVoiceMailSupportTable;

        [XmlElement(ElementName = "thirdPartyVoiceMailSupportTable", IsNullable = false, Namespace = "")]
        [Group(@"21e97b8199c6e7eff29a84874335b46e:157")]
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
