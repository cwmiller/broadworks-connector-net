using System;
using System.Xml.Serialization;
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
     
    public class SystemThirdPartyVoiceMailSupportGetDnListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _thirdPartyVoiceMailSupportTable;

        [XmlElement(ElementName = "thirdPartyVoiceMailSupportTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ThirdPartyVoiceMailSupportTable {
            get => _thirdPartyVoiceMailSupportTable;
            set {
                ThirdPartyVoiceMailSupportTableSpecified = true;
                _thirdPartyVoiceMailSupportTable = value;
            }
        }

        [XmlIgnore]
        public bool ThirdPartyVoiceMailSupportTableSpecified { get; set; }
        
    }
}
