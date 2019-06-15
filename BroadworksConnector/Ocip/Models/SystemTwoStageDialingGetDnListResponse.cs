using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemTwoStageDialingGetDnListRequest.
    /// The Two Stage Dialing DN List table column
    /// headings are: "Phone Number",  "Description".
        /// <see cref="SystemTwoStageDialingGetDnListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemTwoStageDialingGetDnListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _phoneNumberTable;

        [XmlElement(ElementName = "phoneNumberTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable PhoneNumberTable {
            get => _phoneNumberTable;
            set {
                PhoneNumberTableSpecified = true;
                _phoneNumberTable = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberTableSpecified { get; set; }
        
    }
}
