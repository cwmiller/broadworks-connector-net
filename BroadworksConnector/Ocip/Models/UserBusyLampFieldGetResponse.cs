using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Replaced by: UserBusyLampFieldGetResponse16sp2
    /// 
    /// Response to UserBusyLampFieldGetRequest.
    /// The table has column headings:
    /// "User Id", "Last Name", "First Name", "Hiragana Last Name", "Hiragana First Name".
    /// <see cref="UserBusyLampFieldGetResponse16sp2"/>
    /// <see cref="UserBusyLampFieldGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:40308""}]")]
    public class UserBusyLampFieldGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _listURI;

        [XmlElement(ElementName = "listURI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40308")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ListURI
        {
            get => _listURI;
            set
            {
                ListURISpecified = true;
                _listURI = value;
            }
        }

        [XmlIgnore]
        protected bool ListURISpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _monitoredUserTable;

        [XmlElement(ElementName = "monitoredUserTable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:40308")]
        public BroadWorksConnector.Ocip.Models.C.OCITable MonitoredUserTable
        {
            get => _monitoredUserTable;
            set
            {
                MonitoredUserTableSpecified = true;
                _monitoredUserTable = value;
            }
        }

        [XmlIgnore]
        protected bool MonitoredUserTableSpecified { get; set; }

    }
}
